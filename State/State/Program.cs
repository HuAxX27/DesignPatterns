using State.Contexts;
using State.States;

namespace State
{
    public class Program
    {
        static void Main(string[] args)
        {
            //// The client code.
            //var context = new Context(new ConcreteStateA());
            //context.Request1();
            //context.Request2();


            ContextAlarm alarm = new ContextAlarm();
            alarm.alert();
            alarm.alert();
            alarm.ChangeState(new Silent());
            alarm.alert();
            alarm.alert();
            alarm.ChangeState(new Vibration());
            alarm.alert();
            alarm.alert();
            alarm.ChangeState(new Loud());
            alarm.alert();
            alarm.alert();

        }
    }
}