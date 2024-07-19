using State.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Interfaces
{
    public interface IAlarmState
    {
        public void alert (ContextAlarm contextAlarm);

        public void sound(ContextAlarm contextAlarm);
    }
}
