namespace CashMachines.Interfaces
{
    public interface IUser
    {
        int Id { get; }
        int AccountBalance { get; set; }
    }
}
