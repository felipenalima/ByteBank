using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBankAdmin.Utils;

namespace ByteBankAdmin.Employees
{
    public class Developer : Employee, IBonificationManager
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