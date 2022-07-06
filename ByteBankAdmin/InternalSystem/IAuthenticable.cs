using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBankAdmin.Employees;

namespace ByteBankAdmin.InternalSystem
{
    public interface IAuthenticable 
    {
        public bool Authenticate(string password);
    }
}