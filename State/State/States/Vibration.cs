using State.Contexts;
using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class Vibration : IAlarmState
    {
        public void alert(ContextAlarm contextAlarm)
        {
            Console.WriteLine("Vibration...");
        }

        public void sound(ContextAlarm contextAlarm)
        {
            throw new NotImplementedException();
        }
    }
}
