using CashMachines.Exceptions;
using System.Linq;

namespace CashMachines.Validators
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

            if(!cash.ToList().All(c => valid.Contains(c)))
            {
                throw new InvalidCashException();
            }
        }

        public static void WithdrawMoneyValidator(int amount)
        {
            if(amount <= 0 || amount % 5 != 0)
            {
                throw new InvalidAmountException(amount);
            }
        }
    }
}
