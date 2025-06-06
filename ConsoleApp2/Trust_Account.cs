using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Trust_Account: Account
    {
        static DateTime Creation_date = DateTime.Now;
        DateTime Max_Time = Creation_date.AddYears(1);

        int counter = 0;
        const int conter_max = 3;
        public double Intrate { get; set; }

        public Trust_Account(string name = " Non", double balance = 0.0, double intrate = 1, DateTime creation_time = default) : base(name,balance)
        {
           Intrate = intrate; 
           Creation_date = creation_time;
          
        }

        


        public override bool Deposite(double ammount)
        {
            if (ammount >= 5000.00 )
            {
                return base.Deposite(ammount + 50.00);
                            
            }
            else
            {                
                return base.Deposite(ammount);
            }
        }


        public override bool Withdraw(double ammount)
        {
            if(Creation_date<Max_Time)
            { 
            double s = this.Balance * 0.2;
            if (counter < conter_max)
            {
                counter++;               
                if (ammount < s)
                {
                    return base.Withdraw(ammount);
                    
                }
                else
                    return false;
            }
            else
            {
                return false;
            }
            }
            return false;
        }

        public override string ToString()
        {
            return " Trust account ";
        }



    }
}
