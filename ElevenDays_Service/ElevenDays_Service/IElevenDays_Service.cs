﻿using DLL_User;
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
    [ServiceContract]
    public interface IElevenDays_GameService
    {
        // метод будет подбирать для игрока подходящую игру
        [OperationContract]
        PlayerInfo Start(User user);
        // метод будет подбирать для игрока подходящую игру
        [OperationContract]
        PlayerInfo StartTest();
        // метод будет удалять игрока из игры в которой он находится
        [OperationContract(IsOneWay = true)]
        void End(User user);
        // метод будет изменять позицию игрока на ту , которая указана в параметрах
        [OperationContract(IsOneWay = true)]
        void Move(User user, Position positionPlayer);
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
        [DataMember]
        public Model Model { get; set; }
        // логическая переменная указывающая предатель ли игрок
        [DataMember]
        public bool IsImposter { get; set; }
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
        Grape,
        Carrot,
        Cabbage,
        Eggplant,
        Orange,
        Cucumber
    }
}
