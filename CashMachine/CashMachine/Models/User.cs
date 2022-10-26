using CashMachine.Interfaces;
using CashMachine.Validators;

namespace CashMachine.Models
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
