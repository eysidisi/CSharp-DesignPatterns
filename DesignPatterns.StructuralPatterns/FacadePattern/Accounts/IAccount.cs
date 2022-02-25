namespace DesignPatterns.StructuralPatterns.FacadePattern.Accounts
{
    public interface IAccount
    {   
        public void Deposit(int amount);
        public decimal TotalAmount { get; set; }
    }
}