using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank
{
    public class InsufficientBalanceException : FinancialOperationException
    {
        public InsufficientBalanceException(string message) : base(message)
        {
            
        }
    }
}