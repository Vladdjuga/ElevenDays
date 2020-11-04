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
        public void GetMove(Position position, string login)
        {
            MoveEvent?.Invoke(position, login);
        }
    }
}
