using Proxy.Clients;
using Proxy.Interfaces;
using Proxy.RealService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Proxies
{
    internal class AccountBankProxy : IAccount
    {

        //private AccountBankA _realBankAccount;
        private IAccount _realBankAccount;

        public AccountBankProxy(IAccount realAccount)
        {
            _realBankAccount = realAccount;
        }


        public Account Deposit(Account account, double amount)
        {
            Console.WriteLine("Proxy Account -- Deposit");
            if (_realBankAccount == null)
            {
                _realBankAccount = new AccountBankA();
                return _realBankAccount.Deposit(account, amount);
            }
            else
            {
                return _realBankAccount.Deposit(account, amount);
            }
        }

        public void ShowAmount(Account account)
        {
            Console.WriteLine("Proxy Account -- Show account");
            if (_realBankAccount == null)
            {
                _realBankAccount= new AccountBankA();
                _realBankAccount.ShowAmount(account);
            }
            else
            {
                _realBankAccount.ShowAmount(account);
            }
        }

        public Account Withdraw(Account account, double amount)
        {
            Console.WriteLine("Proxy Account -- Withdraw");
            if (_realBankAccount == null)
            {
                _realBankAccount = new AccountBankA();
                return _realBankAccount.Withdraw(account, amount);
            }
            else 
            {
                return _realBankAccount.Withdraw(account,amount);
            }
        }
    }
}
