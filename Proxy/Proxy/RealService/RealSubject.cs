using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy.Interfaces;

namespace Proxy.RealService
{
    public class RealSubject : ISubject
    {
        // The RealSubject contains some core business logic. Usually, RealSubjects
        // are capable of doing some useful work which may also be very slow or
        // sensitive - e.g. correcting input data. A Proxy can solve these issues
        // without any changes to the RealSubject's code.

        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}
