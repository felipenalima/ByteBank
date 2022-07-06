using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBankAdmin.Employees
{
    public abstract class Employee
    {
        public string Name { get; set; }    
        public string Cpf { get; private set; }
        public double Salary { get; protected set; }
        public static int TotalEmployess { get; private set; }
        public Employee(string cpf, double salary)
        {
            this.Cpf = cpf;
            this.Salary = salary;
            TotalEmployess++;
        }

        public abstract double GetBonification();
   
        public abstract void SalaryIncrease();
       
    }
}