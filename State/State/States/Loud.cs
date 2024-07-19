using State.Contexts;
using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class Loud : IAlarmState
    {
        public void alert(ContextAlarm contextAlarm)
        {
            Console.WriteLine("Hace ruido...");
            sound(contextAlarm);
        }

        public void sound(ContextAlarm contextAlarm)
        {
            Console.WriteLine("Volumen alto");
        }
    }
}
