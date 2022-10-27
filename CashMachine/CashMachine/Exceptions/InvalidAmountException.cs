using System;

namespace CashMachines.Exceptions
{
    public class InvalidAmountException : Exception
    {
        public InvalidAmountException(int amount) : 
            base($"Requested amount {amount} is invalid") { }
    }
}
