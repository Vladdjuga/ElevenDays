using AutoMapper;
using DLL_User;
using ElevenDays_Service.DTOS;
using PlayerCordons;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;

namespace ElevenDays_Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
                     ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class ElevenDays_GameService : IElevenDays_GameService
    {
        Session session = new Session();
        Model_Users model_Users = new Model_Users();
        Mapper mapperTo;
        Mapper mapperFrom;

        public ElevenDays_GameService()
        {
            model_Users.Users.Any();

            mapperTo = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>()));
            mapperFrom = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<UserDTO, User>()));
        }

        // удаляет игрока из игры
        public void End(string login)
        {
            GameInfo deleteGame = null;
            PlayerInfo deletePlayer = null;

            foreach (var game in session.Games)
            {
                foreach (var player in game.Players)
                {
                    if (player.User.Login == login)
                    {
                        deleteGame = game;
                        deletePlayer = player;
                        break;
                    }
                }
            }
            deleteGame.Players.Remove(deletePlayer);
        }

        public UserDTO Login(string login, string password)
        {
            string hash = Model_Users.GetHash(SHA256.Create(), password);
            if (model_Users.Users.Any(el => el.Login == login && el.PasswordHash == hash))
            {
                UserDTO userDTO = mapperTo.Map<UserDTO>(model_Users.Users.FirstOrDefault(el => el.Login == login && el.PasswordHash == hash));
                return userDTO;
            }
            return null;
        }

        // метод для изменения положения игрока
        public void Move(string gameid, string login, Position positionPlayer)
        {
            GameInfo gameInfo = session.Games.FirstOrDefault(el => el.Id == gameid);
            foreach (var player in gameInfo.Players)
            {
                if (player.User.Login == login)
                {
                    player.Hitbox.StartPosition = positionPlayer;                 
                    break;
                }
            }
            if(gameInfo!=null)
            gameInfo.NotifyAllPlayersAboutMove(positionPlayer, login);
        }

        public bool Register(string login, string email, string password)
        {
            if (!model_Users.Users.Any(el => el.Login==login))
            {
                User user = new User() { Login = login, Email = email, PasswordHash = Model_Users.GetHash(SHA256.Create(), password) };
                model_Users.Users.Add(user);
                model_Users.SaveChanges();
                return true;
            }
            return false;
        }

        // метод для запуска игрока в игру
        public string Start(UserDTO userDTO)
        {
            User user = mapperFrom.Map<User>(userDTO);

            PlayerInfo pi = null;
            if (!session.IsContainsUser(user))
            {
                foreach (var game in session.Games)
                {
                    if (game.Players.Count < 10)
                    {
                        pi = new PlayerInfo() { User = user, Player_Fruit = Player_Fruit.Banana, IsImposter = false, Hitbox = new Hitbox() { StartPosition = new Position(0, 0), Height = 10, Width = 10 } };
                        game.Players.Add(pi);
                        game.NotifyPlayersAboutNewPlayer(pi.Hitbox.StartPosition,pi.User.Login);
                        return game.Id;
                    }
                }
            }
            if (pi == null)
            {
                pi = new PlayerInfo() { User = user, Player_Fruit = Player_Fruit.Banana, IsImposter = false, Hitbox = new Hitbox() { StartPosition = new Position(0, 0), Height = 10, Width = 10 } };
                GameInfo gameInfo = new GameInfo() { Id = CreateGameInfoID() };
                gameInfo.Players.Add(pi);
                session.Games.Add(gameInfo);
                return gameInfo.Id;
            }
            return "";
        }

        public bool StartByGameID(string gameid, UserDTO userDTO)
        {
            PlayerInfo pi = null;
            User user = mapperFrom.Map<User>(userDTO);
            GameInfo gameInfo = GetGameInfoByID(gameid);

            if (gameInfo != null)
            {
                pi = new PlayerInfo() { User = user, Player_Fruit = Player_Fruit.Banana, IsImposter = false, Hitbox = new Hitbox() { StartPosition = new Position(0, 0), Height = 10, Width = 10 } };
                gameInfo.Players.Add(pi);
                return true;
            }
            return false;
        }

        private string CreateGameInfoID()
        {
            string id = GameInfo.RandomString("ABCDEFGHTUQINMLOP", 5);
            while(session.Games.Any(el=>el.Id==id))
            {
                id = GameInfo.RandomString("ABCDEFGHTUQINMLOP", 5);
            }
            return id;
        }
        private GameInfo GetGameInfoByID(string id)
        {
            foreach (var item in session.Games)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }

        public Session GetGames()
        {
            return session;
        }

        public string CreateGame()
        {
            GameInfo gameInfo = new GameInfo() { Id = CreateGameInfoID() };
            session.Games.Add(gameInfo);
            return gameInfo.Id;
        }

        public GameInfo GetGame(int ind)
        {
            return session.Games[ind];
        }

        public int GetGamesCount()
        {
            return session.Games.Count;
        }

        public PlayerInfo GetPlayer(string game, int ind)
        {
            GameInfo gameInfo = GetGameInfoByID(game);
            return gameInfo.Players[ind];
        }

        public int GetPlayersCount(string game)
        {
            GameInfo gameInfo = GetGameInfoByID(game);
            return gameInfo.Players.Count;
        }

        public string GetPlayerString(string game, int ind)
        {
            GameInfo gameInfo = GetGameInfoByID(game);
            return gameInfo.Players[ind].User.Login;
        }
    }
}
