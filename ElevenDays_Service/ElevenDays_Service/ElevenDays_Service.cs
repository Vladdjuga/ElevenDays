using DLL_User;
using PlayerCordons;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ElevenDays_Service
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class ElevenDays_GameService : IElevenDays_GameService
    {
        Session session = new Session();

        // удаляет игрока из игры
        public void End(User user)
        {
            GameInfo deleteGame = null;
            PlayerInfo deletePlayer = null;

            foreach (var game in session.Games)
            {
                foreach (var player in game.Players)
                {
                    if (player.User.Id == user.Id)
                    {
                        deleteGame = game;
                        deletePlayer = player;
                        break;
                    }
                }
            }
            deleteGame.Players.Remove(deletePlayer);
        }

        // метод для изменения положения игрока
        public void Move(User user, Position positionPlayer)
        {
            foreach (var game in session.Games)
            {
                foreach (var player in game.Players)
                {
                    if (player.User.Id == user.Id)
                    {
                        player.Hitbox.StartPosition = positionPlayer;
                        break;
                    }
                }
            }
        }

        // метод для запуска игрока в игру
        public PlayerInfo Start(User user)
        {
            PlayerInfo pi = null;
            if (!session.IsContainsUser(user))
            {
                foreach (var game in session.Games)
                {
                    if (game.Players.Count < 10)
                    {
                        pi = new PlayerInfo() { User = user, Player_Fruit = Player_Fruit.Banana, IsImposter = false, Hitbox = new Hitbox() { StartPosition = new Position(0, 0), Height = 10, Width = 10 } };
                        game.Players.Add(pi);
                        return pi;
                    }
                }
            }
            if(pi==null)
            {
                pi = new PlayerInfo() { User = user, Player_Fruit = Player_Fruit.Banana, IsImposter = false, Hitbox = new Hitbox() { StartPosition = new Position(0, 0), Height = 10, Width = 10 } };
                GameInfo gameInfo = new GameInfo();
                gameInfo.Players.Add(pi);
                session.Games.Add(gameInfo);
            }
            return pi;
        }

        public PlayerInfo StartTest()
        {
            return null;
        }
    }
}
