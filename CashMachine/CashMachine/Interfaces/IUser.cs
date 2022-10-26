namespace CashMachine.Interfaces
{
    public interface IUser
    {
        int Id { get; }
        int AccountBalance { get; set; }
    }
}
