using DLL_User;
using ElevenDays_Service.DTOS;
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
    [ServiceContract(CallbackContract = typeof(ICallback))]
    public interface IElevenDays_GameService
    {
        // метод будет проверять есть ли данный юзер
        [OperationContract(IsOneWay = false)]
        UserDTO Login(string login,string password);
        // метод будет проверять есть ли данный юзер
        [OperationContract(IsOneWay = false)]
        bool Register(string login, string email, string password);
        // метод будет подбирать для игрока подходящую игру , будет возвращать ID комнаты
        [OperationContract(IsOneWay = false)]
        string Start(UserDTO userDTO);
        // запускает игрока по ID комнаты
        [OperationContract(IsOneWay = false)]
        bool StartByGameID(string gameid, UserDTO userDTO, string player_Fruit);
        // метод будет удалять игрока из игры в которой он находится
        [OperationContract(IsOneWay = true)]
        void End(string login);
        // метод будет изменять позицию игрока на ту , которая указана в параметрах
        [OperationContract(IsOneWay = true)]
        void Move(string gameid, string login, Position positionPlayer,string state);
        [OperationContract(IsOneWay = true)]
        void ChangePlayerState(string gameid, string login,string currentPlayerState);
        // метод получения всех наявных игр
        [OperationContract(IsOneWay = false)]
        GameInfo GetGame(int ind);
        // метод получения количевства игр
        [OperationContract(IsOneWay = false)]
        int GetGamesCount();
        // метод получения количевства игроков в игре
        [OperationContract(IsOneWay = false)]
        int GetPlayersCount(string game);
        // метод получения всех игроков в введеной игре
        [OperationContract(IsOneWay = false)]
        PlayerInfo GetPlayer(string game,int ind);
        // метод получения всех игроков в введеной игре
        [OperationContract(IsOneWay = false)]
        string GetPlayerString(string game, int ind);
        [OperationContract(IsOneWay = false)]
        string GetPlayerFruit(string game, int ind);
        [OperationContract(IsOneWay = false)]
        Position GetPlayerPosition(string game, int ind);
        // метод получения всех наявных игр
        [OperationContract(IsOneWay = false)]
        string CreateGame();
        //
        [OperationContract(IsOneWay = false)]
        string FindGame();
        //
        [OperationContract(IsOneWay = false)]
        string FindGameById(string id);
        //
        [OperationContract(IsOneWay = false)]
        bool IsAnyWithFruit(string game,string fruit);
        //
        [OperationContract(IsOneWay = false)]
        string PlayerCurrentRoom(string game, int ind);
        //
        [OperationContract(IsOneWay = false)]
        string PlayerCurrentRoomByLogin(string game, string login);
    }

    public interface ICallback
    {
        [OperationContract(IsOneWay = true)]
        void GetMove(Position position,string login);

        [OperationContract(IsOneWay = true)]
        void GetState(string state, string login,string character);

        [OperationContract(IsOneWay = true)]
        void GetNewPlayerArrived(Position position, string login, string character);

        [OperationContract(IsOneWay = true)]
        void GetDisconected(string login);
    }

    [DataContract]
    // этот класс описывает игрока
    public class PlayerInfo
    {
        // информация об игроке из базы данныъ
        [DataMember]
        public User User { get; set; }
        // фрукт игрока
        [DataMember]
        public Player_Fruit Player_Fruit { get; set; }
        // хитбокс игрока в пространстве (фигура в осях которой находится игрок)
        [DataMember]
        public Hitbox Hitbox { get; set; }
        // модель игрока

        public Model Model { get; set; }
        // логическая переменная указывающая предатель ли игрок
        [DataMember]
        public bool IsImposter { get; set; }

        public ICallback Callback { get; set; }

        [DataMember]
        public string PlayerState { get; set; }
        
        [DataMember]
        public string Room { get; set; }
    }

    [DataContract]
    // этот класс описывает игру с игроками
    public class GameInfo
    {
        //[DataMember]
        // массив игроков с максимальным значением - 10
        public List<PlayerInfo> Players { get; set; } = new List<PlayerInfo>(9);

        [DataMember]
        // id комнаты
        public string Id { get; set; }


        public static string RandomString(string Alphabet, int Length)
        {
            Random ran = new Random();
            StringBuilder RandomString = new StringBuilder(Length - 1);
            int Position = 0;
            for (int i = 0; i < Length; i++)
            {
                Position = ran.Next(0, Alphabet.Length - 1);
                RandomString.Append(Alphabet[Position]);
            }
            return RandomString.ToString();
        }

        internal void NotifyAllPlayersAboutState(string state, string login, string character)
        {
            foreach (var item in Players)
            {
                if (item.User.Login != login)
                    item.Callback.GetState(state, login,character);
            }
        }

        internal void NotifyAllPlayersAboutMove(Position positionPlayer, string login)
        {
            foreach (var item in Players)
            {
                if (item.User.Login != login)
                    item.Callback.GetMove(positionPlayer, login);
            }
        }

        internal void NotifyPlayersAboutNewPlayer(Position startPosition, string login, string character)
        {
            foreach (var item in Players)
            {
                if (item.User.Login != login)
                    item.Callback.GetNewPlayerArrived(startPosition, login, character);
            }
        }
    }

    [DataContract]
    // этот класс описывает сессию игр
    public class Session
    {
        // массив в котором есть запущеные игры
        [DataMember]
        public List<GameInfo> Games { get; set; } = new List<GameInfo>();
        // метод который проверяет есть ли указаный пользователь в игре
        public bool IsContainsUser(User user)
        {
            foreach (var game in Games)
            {
                foreach (var player in game.Players)
                {
                    if (player.User.Id == user.Id)
                        return true;
                }
            }
            return false;
        }
    }

    [DataContract]
    public enum Player_Fruit
    {
        Banana,
        Tomato,
        Mango,
        Kiwi,
        Carrot,
        Cabbage,
        Eggplant,
        Orange,
        Cucumber
    }
}
