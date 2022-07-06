using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBankAdmin.Employees
{
    public class Developer : Employee
    {
        public Developer(string cpf) : base(cpf, 3000)
        {
            
        }

        public override double GetBonification()
        {
            return Salary * 0.1;
        }
           

        public override void SalaryIncrease()
        {
            Salary *= 0.15;
        }
    }
}