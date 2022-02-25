namespace DesignPatterns.StructuralPatterns.FacadePattern.Accounts
{
    public interface IAccount
    {   
        public void Deposit(decimal amount);
        public void Transfer(IAccount toAccount,decimal amount);
        public decimal TotalAmount { get; set; }
    }
}