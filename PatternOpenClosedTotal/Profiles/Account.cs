using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternOpenClosedTotal.Class
{
    public class Account
    {
        public string Type { get; set; }
        public double Balance { get; set; }
        public double Interest {  get; set; }

        public Account(string type = null, double balance = 0, double interest = 0)
        {
            Type = type;
            Balance = balance;
            Interest = interest;
        }
    }
}
