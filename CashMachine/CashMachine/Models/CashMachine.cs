using CashMachines.Exceptions;
using CashMachines.Interfaces;
using CashMachines.Validators;
using System.Linq;

namespace CashMachines.Models
{
    public class CashMachine : ICashMachine
    {
        private readonly IUser _user;

        public CashMachine(IUser user)
        {
            _user = user;
        }

        public void Insert(int[] cash)
        {
            Validator.InsertMoneyValidator(cash);
            _user.AccountBalance += cash.Sum();
        }

        public int Withdraw(int amount)
        {
            Validator.WithdrawMoneyValidator(amount);

            if (_user.AccountBalance >= amount)
            {
                _user.AccountBalance -= amount;
                return amount;
            }

            throw new InsufficientBalanceException(amount);
        }
    }
}
