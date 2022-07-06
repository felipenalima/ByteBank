using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBankAdmin.InternalSystem;

namespace ByteBankAdmin.Employees
{
    public abstract class EmployeeAuthenticable : Employee, IAuthenticable
    {
        public string Password { get; set; }
        protected EmployeeAuthenticable(string cpf, double salary) : base(cpf, salary)
        {
            
        }

        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}