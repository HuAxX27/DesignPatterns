using Composite.Clients;
using Composite.Composites;
using Composite.Leafs;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client client = new Client();

            //// This way the client code can support the simple leaf
            //// components...
            //Leaf leaf = new Leaf();
            //Console.WriteLine("Client: I get a simple component:");
            //client.ClientCode(leaf);

            //// ...as well as the complex composites.
            //Composites.Composite tree = new Composites.Composite();
            //Composites.Composite branch1 = new Composites.Composite();
            //branch1.Add(new Leaf());
            //branch1.Add(new Leaf());
            //Composites.Composite branch2 = new Composites.Composite();
            //branch2.Add(new Leaf());
            //tree.Add(branch1);
            //tree.Add(branch2);
            //Console.WriteLine("Client: Now I've got a composite tree:");
            //client.ClientCode(tree);

            //Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            //client.ClientCode2(tree, leaf);


            //////


            Directive directive = new Directive();


            Employee emp1 = new Employee("Empleado 1", "Desarrollador");
            Employee emp2 = new Employee("Empleado 2", "Desarrollador");
            Employee emp3 = new Employee("Empleado 3", "Tester");

            Console.WriteLine("Company employees:");
            directive.DirectiveCode(emp1);
            directive.DirectiveCode(emp2);
            directive.DirectiveCode(emp3);

            Console.WriteLine("--------------------");

            Console.WriteLine("Company Managers:");
            Manager mgr1 = new Manager("Gerente 1", "Gerente de TI");
            mgr1.AddEmployee(emp1);
            mgr1.AddEmployee(emp2);

            Manager mgr2 = new Manager("Gerente 2", "Gerente de QA");
            mgr2.AddEmployee(emp3);

            directive.DirectiveCode(mgr1);
            directive.DirectiveCode(mgr2);

            Console.WriteLine("--------------------");

            Console.WriteLine("Company CEO:");
            Manager generalManager = new Manager("Gerente General", "Gerente General");
            generalManager.AddEmployee(mgr1);
            generalManager.AddEmployee(mgr2);

            directive.DirectiveCode(generalManager);

        }
    }
}