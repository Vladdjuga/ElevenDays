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
        public event Action<string, string> StateEvent;
        public event Action<string> DisconnectedEvent;
        public int Count = 0;

        public void GetMove(Position position, string login)
        {
            MoveEvent?.Invoke(position, login);
        }

        public void GetNewPlayerArrived(Position position, string login)
        {
            NewPlayerArrivedEvent?.Invoke(position, login);

        }

        public void GetState(string state, string login)
        {
            StateEvent?.Invoke(state, login);
        }

        public void GetDisconected(string login)
        {
            DisconnectedEvent?.Invoke(login);
        }
    }
}
