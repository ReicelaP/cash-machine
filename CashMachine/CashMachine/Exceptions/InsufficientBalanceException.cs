using System;

namespace CashMachines.Exceptions
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(int amount) :
            base($"Account balance is less than {amount}") { }
    }
}
