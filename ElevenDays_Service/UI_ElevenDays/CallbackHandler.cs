using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_ElevenDays.ServiceReference2;

namespace UI_ElevenDays
{
    public class CallbackHandler : IElevenDays_GameServiceCallback
    {
        public event Action<Position, string> MoveEvent;
        public event Action<Position, string> NewPlayerArrivedEvent;
        public event Action<GameInfo[]> GamesEvent;

        public void GetGames(GameInfo[] gameInfos)
        {
            GamesEvent?.Invoke(gameInfos);
        }

        public void GetMove(Position position, string login)
        {
            MoveEvent?.Invoke(position, login);
        }

        public void GetNewPlayerArrived(Position position, string login)
        {
            NewPlayerArrivedEvent?.Invoke(position, login);
        }
    }
}
