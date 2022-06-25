using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank
{
    public class CurrentAccount
    {
        public string name;
        public string account;
        public int agencyNumber;  
        public string agencyName;
        public double balance;

        //Withdraw method, check valor and balance
        public bool Withdraw(double value)
        {
            if(value < 0)
            {
                Console.WriteLine("Value can't be less than 0");
                return false;
            }
            else if (balance < value)
            {
                Console.WriteLine("Balance less than withdrawal amount");
                return false;
            }
            else 
            { 
                Console.WriteLine("Withdrawal value: " + value);
                balance -= value;
                return true;
            }
        }

        public void Deposit(double value)
        {
            balance += value;
        }

        public bool Transfer(double value, CurrentAccount transferDestiny)
        {
            if(value < 0)
            {
                return false;
            }
            else if(balance < value)
            {
                return false; 
            }
            else
            {
                balance -= value;
                transferDestiny.balance += value;
                return true; 
            }
        }
    }
}