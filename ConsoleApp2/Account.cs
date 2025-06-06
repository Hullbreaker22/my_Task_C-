using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Account
    {
        public Account(string? name = "Unnamed Account" , double balance = 0.0)
        {
            Name = name;
            Balance = balance;
            
        }

        
        public string? Name { get; set; }
        public double Balance { get; set; }



        public virtual bool Deposite(double ammount)
        {
            if(ammount < 0 )
            {
                return false;
            }
            else 
            {
                this.Balance += ammount;
                return true;
            }
        }

        public virtual bool Withdraw(double ammount)
        {
            if ((ammount > 0 && this.Balance >= ammount))
            {
                this.Balance -= ammount;
                return true;
            }
            else 
            {
                return false;
            }
        }

        public override string ToString()
        {
            return " Account ";
        }



    }
}
