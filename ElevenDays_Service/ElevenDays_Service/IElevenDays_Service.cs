using DLL_User;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ElevenDays_Service
{
    [ServiceContract]
    public interface IElevenDays_Service
    {
        // метод будет подбирать для игрока подходящую игру
        [OperationContract(IsOneWay = true)]
        void Start(User user);
        // метод будет удалять игрока из игры в которой он находится
        [OperationContract(IsOneWay = true)]
        void End(User user);
        // метод будет изменять позицию игрока на ту , которая указана в параметрах
        [OperationContract(IsOneWay = true)]
        void Move(User user, PositionPlayer positionPlayer);
    }

    // этот класс описывает игрока
    class PlayerInfo
    {
        // информация об игроке из базы данныъ
        public User User { get; set; }
        // цвет игрока
        public Brush Color { get; set; }
        // позиция игрока относительно карты
        public PositionPlayer PositionPlayer { get; set; }
        // логическая переменная указывающая предатель ли игрок
        public bool IsImposter { get; set; }
    }

    // этот класс описывает позицию игрока
    public class PositionPlayer
    {
        // тут будут координаты но пока хз какие 
        // х , у - будут представлять эти координаты
        public double X { get; set; }
        public double Y { get; set; }

        // конструктор для класса
        public PositionPlayer(double x,double y)
        {
            X = x;
            Y = y;
        }
    }

    // этот класс описывает игру с игроками
    class GameInfo
    {
        // массив игроков с максимальным значением - 10
        public List<PlayerInfo> Players { get; set; } = new List<PlayerInfo>(10);
    }

    // этот класс описывает сессию игр
    class Session
    {
        // массив в котором есть запущеные игры , с вместительством - 1024
        public List<GameInfo> Games { get; set; } = new List<GameInfo>(1024);

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
}
