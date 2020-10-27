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
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class ElevenDays_Service : IElevenDays_Service
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
        public void Move(User user, PositionPlayer positionPlayer)
        {
            foreach (var game in session.Games)
            {
                foreach (var player in game.Players)
                {
                    if (player.User.Id == user.Id)
                    {
                        player.PositionPlayer = positionPlayer;
                        break;
                    }
                }
            }
        }

        // метод для запуска игрока в игру
        public void Start(User user)
        {
            if (!session.IsContainsUser(user))
            {
                foreach (var game in session.Games)
                {
                    if (game.Players.Count < 10)
                    {
                        game.Players.Add(new PlayerInfo() { User = user, Color = Brushes.Black, IsImposter = false, PositionPlayer = new PositionPlayer(0, 0) });
                    }
                }
            }
        }
    }
}
