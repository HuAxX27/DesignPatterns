using Proxy.Clients;
using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.RealService
{
    public class AccountBankB : IAccount
    {
        public Account Deposit(Account account, double amount)
        {
            double currentAmount = account._initialAmount + amount + 10;
            account._initialAmount = currentAmount;
            Console.WriteLine("Current amount: $"+account._initialAmount);
            return account;
        }

        public void ShowAmount(Account account)
        {
            account._initialAmount = account._initialAmount - 0.5;
            Console.WriteLine("Current amount: $" + account._initialAmount);
        }

        public Account Withdraw(Account account, double amount)
        {
            double currentAmount = account._initialAmount - amount - 10;
            account._initialAmount = currentAmount;
            Console.WriteLine("Current amount: $" + account._initialAmount);
            return account;
        }
    }
}
