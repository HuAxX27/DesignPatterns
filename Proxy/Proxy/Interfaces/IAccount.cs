using Proxy.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Interfaces
{
    public interface IAccount
    {
        Account Withdraw(Account account, double amount);
        Account Deposit(Account account, double amount);
        void ShowAmount(Account account);

    }
}
