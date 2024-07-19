using Observer.Interfaces;
using Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observers
{
    public class ObserverA : IObserver
    {
        private double exchangeRate = 17.92;
        public void Update(ISubject subject)
        {

            //if ((subject as Subject).State < 3)
            //{
            //    Console.WriteLine("ObserverA: Reacted to the event.");
            //}



            Console.WriteLine("ObserverA: change $" + (subject as Subject).State + "USD to MXN");
            Console.WriteLine("ObserverA: MXN $" + (subject as Subject).State * exchangeRate);

        }
    }
}
