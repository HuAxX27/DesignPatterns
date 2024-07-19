using State.Contexts;
using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class Silent : IAlarmState
    {
        public void alert(ContextAlarm contextAlarm)
        {
            Console.WriteLine("Silent...");
        }

        public void sound(ContextAlarm contextAlarm)
        {
            throw new NotImplementedException();
        }
    }
}
