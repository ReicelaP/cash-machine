using CashMachine.Interfaces;
using CashMachine.Validators;
using System.Linq;

namespace CashMachine
{
    public class CashMachineService
    {
        private readonly IUser _user;

        public CashMachineService(IUser user)
        {
            _user = user;
        }

        public void InsertMoney(int[] amount)
        {
            Validator.InsertMoneyValidator(amount);
            _user.AccountBalance += amount.Sum();
        }

        public void WithdrawMoney(int amount)
        {
            
        }
    }
}
