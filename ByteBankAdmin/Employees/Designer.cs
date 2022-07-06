using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBankAdmin.Utils;

namespace ByteBankAdmin.Employees
{
    public class Designer : Employee, IBonificationManager
    {  
       public Designer(string cpf) : base(cpf, 3000)
       {
        
       }

        public override double GetBonification()
        {
            return Salary * 0.17;
        }

        public override void SalaryIncrease()
        {
            Salary *= 1.11;
        }
    }
}