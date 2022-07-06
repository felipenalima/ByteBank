using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBankAdmin.Employees;

namespace ByteBankAdmin.InternalSystem
{
    public class InternalSystem
    {
        public bool Login(Authenticable employee, string password)
        {
            bool userAuthenticate = employee.Authenticate(password);

            if(userAuthenticate == true)
            {
                Console.WriteLine("Welcome to the system: " + employee.Name);
                return true;
            }
            else
            {
                Console.WriteLine("Wrong Password!");
                return false;
            }


        }
    }
}