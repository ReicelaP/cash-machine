using CashMachine.Exceptions;
using System.Linq;

namespace CashMachine.Validators
{
    public class Validator
    {
        public static void AccountBalanceValidator(int amount)
        {
            if(amount < 0)
            {
                throw new InvalidBalanceException();
            }
        }

        public static void InsertMoneyValidator(int[] cash)
        {
            int[] valid = { 5, 10, 20, 50, 100 };

            if(!cash.ToList().Intersect(valid).Any())
            {
                throw new InvalidCashException();
            }
        }
    }
}
