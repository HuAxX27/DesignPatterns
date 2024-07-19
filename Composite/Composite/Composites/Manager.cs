using Composite.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Composites
{
    public class Manager : IEmployee
    {
        private List<IEmployee> _employees = new List<IEmployee>();

        public string Name { get; set; }
        public string Job { get; set; }

        public Manager(string name, string job)
        {
            Name = name;
            Job = job;
        }

        public void AddEmployee(IEmployee employee)
        {
            _employees.Add(employee);
        }

        public void RemoveEmployee(IEmployee employee)
        {
            _employees.Remove(employee);
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"{Name} - {Job}");
            Console.WriteLine("Reporting People:");
            foreach (var employee in _employees)
            {
                employee.DisplayEmployeeDetails();
            }
        }
    }
}
