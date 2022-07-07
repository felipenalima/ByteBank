using System.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank
{
    public class CurrentAccount
    {
        //Fields
        private double balance;
        //Properties
        public Client Client { get; set; }
        public string AgencyName { get; set; }
        public int Account {get;}
        public int AgencyNumber {get;}
        public static int TotalAccountsCreated { get; set; }
        public static double OperationFee { get; private set; }
        public int CountTransferNotAllowed { get; private set; }
        public int CountWithdrawNotAllowed { get; set; }

        //Method Constructor
        public CurrentAccount(int agencyNumber, int account)
        {
            AgencyNumber = agencyNumber;
            Account = account;

            if(agencyNumber <= 0)
            {
                throw new ArgumentException("Agency number cannot be less than zero ", nameof(agencyNumber));
            }
            if(account <= 0)
            {
                throw new ArgumentException("Account cannot be less than zero ", nameof(account));
            }

            TotalAccountsCreated++;
            OperationFee = 30 / TotalAccountsCreated;
            
        }
        //Withdraw method, check valor and balance
        public bool Withdraw(double value)
        {
            if(value < 0)
            {
                CountWithdrawNotAllowed++;
                throw new InsufficientBalanceException("Value can't be less than 0");
            }
            else if (balance < value)
            {
                CountWithdrawNotAllowed++;
                throw new InsufficientBalanceException("Balance less than withdrawal amount");
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
            try
            {
                Withdraw(value);
            }
            catch(InsufficientBalanceException ex)
            {
                CountTransferNotAllowed++;
                throw new FinancialOperationException("Operation not realized", ex);
            }

            balance -= value;
            transferDestiny.balance += value;
            return true; 

        }


        public void SetBalance(double value)
        {
            if(value < 0){
                return;
            }
            balance = value;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}