using Proxy.Clients;
using Proxy.RealService;
using Proxy.Proxies;
using Proxy.Interfaces;

namespace Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Client client = new Client();

            //Console.WriteLine("Client: Executing the client code with a real subject:");
            //RealSubject realSubject = new RealSubject();
            //client.ClientCode(realSubject);

            //Console.WriteLine();

            //Console.WriteLine("Client: Executing the same client code with a proxy:");
            //Proxies.Proxy proxy = new Proxies.Proxy(realSubject);
            //client.ClientCode(proxy);


            Account Client1 = new Account(1, "Rich man", 1000);

            IAccount accountProxy = new AccountBankProxy(new AccountBankA());

            IAccount accountReal = new AccountBankA();
            //IAccount accountProxy = new AccountBankProxy();
            accountProxy.ShowAmount(Client1);

            Client1 = accountProxy.Deposit(Client1, 500);
            Client1 = accountProxy.Withdraw(Client1, 1000);
            accountProxy.ShowAmount(Client1);

            accountReal.ShowAmount(Client1);



        }
    }
}
