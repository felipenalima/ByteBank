using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBankAdmin.Employees
{
    public class Employee
    {
        public string Name { get; set; }    
        public string Cpf { get; set; }
        public double Salary { get; set; }

        public double GetBonification()
        {
            return Salary*0.1;
        }
    }
}