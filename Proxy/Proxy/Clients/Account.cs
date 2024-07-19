using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Clients
{
    public class Account
    {
        public int _id {  get; set; }
        public string _name { get; set; }
        public double _initialAmount {  get; set; }

        public Account(int id, string name, double initialAmount)
        {
            _id = id;
            _name = name;
            _initialAmount = initialAmount;
        }


    }
}
