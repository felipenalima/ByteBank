using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBankAdmin.Employees;
using ByteBankAdmin.InternalSystem;

namespace ByteBankAdmin.CommercialPartner
{
    public class CommercialPartner : IAuthenticable
    {
        public string Password { get; set; }
        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}