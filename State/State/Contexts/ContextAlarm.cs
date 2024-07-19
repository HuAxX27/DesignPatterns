using State.Interfaces;
using State.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Contexts
{
    public class ContextAlarm
    {
        private IAlarmState _alarmState;

        public ContextAlarm() 
        {
            _alarmState = new Vibration();
        }

        public void SetState(IAlarmState alarmState)
        {
            _alarmState = alarmState;
        }

        public void alert()
        {
            _alarmState.alert(this);
        }

        public void ChangeState(IAlarmState state)
        {
            Console.WriteLine($"Context: Change alarm mode to {state.GetType().Name}.");
            SetState(state);
        }
    }
}
