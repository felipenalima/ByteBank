using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBankAdmin.Utils;

namespace ByteBankAdmin.Employees
{
    public class Assistant : Employee, IBonificationManager
    {
        public Assistant(string cpf) : base(cpf, 2000)
        {
            
        }

        public override double GetBonification()
        {
            return Salary * 0.20;
        }

        public override void SalaryIncrease()
        {
            Salary *= 1.1;
        }
        
    }
}