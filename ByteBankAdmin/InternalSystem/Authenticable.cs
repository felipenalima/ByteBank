using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBankAdmin.Employees;

namespace ByteBankAdmin.InternalSystem
{
    public abstract class Authenticable : Employee
    {
        public string Password { get; set; }
        protected Authenticable(string cpf, double salary) : base(cpf, salary)
        {

        }
        public bool Authenticate(string password)
        {
            return this.Password == password;
        }
    }
}