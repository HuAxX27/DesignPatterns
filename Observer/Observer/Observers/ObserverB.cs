using Observer.Interfaces;
using Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observers
{
    public class ObserverB : IObserver
    {
        private double exchangeRate = 4003.07;
        public void Update(ISubject subject)
        {
            //if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            //{
            //    Console.WriteLine("ObserverB: Reacted to the event.");
            //}

            Console.WriteLine("ObserverB: change $" + (subject as Subject).State + "USD to COP");
            Console.WriteLine("ObserverB: COP $" + (subject as Subject).State * exchangeRate);
        }
    }
}
