using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBankAdmin.Employees;

namespace ByteBankAdmin.Utils
{
    public class TotalBonification : IBonificationManager
    {
        public double totalBonification { get; set; }

        public void Register(Employee employee)
        {
            this.totalBonification += employee.GetBonification();
        }

        public double GetBonification()
        {
            return totalBonification;
        }
      
    }
}