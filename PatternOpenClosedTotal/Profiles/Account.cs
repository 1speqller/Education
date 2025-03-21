using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternOpenClosedTotal.Class
{
    public class Account
    {
        public double Balance { get; set; }
        public double Interest {  get; set; }

        public Account(double balance = 0, double interest = 0)
        {
            Balance = balance;
            Interest = interest;
        }
    }
}
