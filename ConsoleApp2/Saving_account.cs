using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Saving_account : Account
    {

        public double Intrate { get; set; }

        public Saving_account(string name = "None ", double balance = 0.0, double intrate = 0.2 ) : base(name, balance)
        {
            Intrate = intrate;
        }

        public override bool Withdraw(double ammount)
        {    
            return base.Withdraw(ammount + ( ammount * Intrate));
        }
        
        


        public override string ToString()
        {
            return " Saving account ";
        }

    }
}
