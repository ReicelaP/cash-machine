using CashMachines.Interfaces;
using CashMachines.Validators;

namespace CashMachines.Models
{
    public class User : IUser
    {
        public User(int id, int accountBalance)
        {
            Id = id;

            Validator.AccountBalanceValidator(accountBalance);
            AccountBalance = accountBalance;
        }

        public int Id { get; }
        public int AccountBalance { get; set; }
    }
}
