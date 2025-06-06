using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Checking_account: Account
    {
        public  double Fee { get; set; }
        public Checking_account(string? name = " Non", double balance = 0.0) : base(name,balance)
        {
            Fee = 1.50;
        }

        public override bool Withdraw(double ammount)
        {
            return base.Withdraw(ammount + Fee);
        }

        public override string ToString()
        {
            return " Checking Account ";
        }

    }
}
