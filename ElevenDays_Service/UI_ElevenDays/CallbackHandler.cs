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
        public event Action<Position, string, string,string> NewPlayerArrivedEvent;
        public event Action<string, string, string> StateEvent;
        public event Action<string, string> PlayerChangedEvent;
        public event Action<string> DisconnectedEvent;
        public int Count = 0;

        public void GetMove(Position position, string login)
        {
            MoveEvent?.Invoke(position, login);
        }

        public void GetNewPlayerArrived(Position position, string login, string character,string room)
        {
            NewPlayerArrivedEvent?.Invoke(position, login,character,room);

        }

        public void GetState(string state, string login,string character)
        {
            StateEvent?.Invoke(state, login,character);
        }

        public void GetDisconected(string login)
        {
            DisconnectedEvent?.Invoke(login);
        }

        public void GetPlayerChangedRoom(string login, string room)
        {
            PlayerChangedEvent?.Invoke(login, room);
        }
    }
}
