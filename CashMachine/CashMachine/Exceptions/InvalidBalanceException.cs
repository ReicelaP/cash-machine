using System;

namespace CashMachines.Exceptions
{
    public class InvalidBalanceException : Exception
    {
        public InvalidBalanceException() :
            base($"Amount should be greater than 0") { }
    }
}
