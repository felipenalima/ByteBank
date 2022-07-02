using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBankAdmin.Employees
{
    public class Director : Employee
    {   
        public override double GetBonification()
        {
            return Salary;
        }
    }
}