using Composite.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Leafs
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Job { get; set; }

        public Employee(string name, string job)
        {
            Name = name;
            Job = job;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"{Name} - {Job}");
        }
    }
}
