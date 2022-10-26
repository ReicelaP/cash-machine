using System;

namespace CashMachine.Exceptions
{
    public class InvalidCashException : Exception
    {
        public InvalidCashException() :
            base("Machine accepts only 5, 10, 20, 50, 100 notes") { }
    }
}
