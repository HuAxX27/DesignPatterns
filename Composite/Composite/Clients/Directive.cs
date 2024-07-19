using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Components;
using Composite.Composites;
using Composite.Leafs;

namespace Composite.Clients
{
    public class Directive
    {
        public void DirectiveCode(Employee employee)
        {
            employee.DisplayEmployeeDetails();
        }

        public void DirectiveCode(Manager manager)
        {
            
            Console.WriteLine($"Manager Details:");
            manager.DisplayEmployeeDetails();
        }
    }
}
