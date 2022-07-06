using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBankAdmin.InternalSystem;
using ByteBankAdmin.Utils;

namespace ByteBankAdmin.Employees
{
    public class Director : EmployeeAuthenticable, IBonificationManager
    {   

        public Director(string cpf) : base(cpf, 5000)
        {
            
        }

        public override double GetBonification()
        {
            return Salary * 0.5;
        }

        public override void SalaryIncrease()
        {
            this.Salary *= 1.15;
        }
    }
}