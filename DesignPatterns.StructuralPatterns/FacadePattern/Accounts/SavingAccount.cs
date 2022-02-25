namespace DesignPatterns.StructuralPatterns.FacadePattern.Accounts
{
    internal class SavingAccount : IAccount
    {
        public decimal TotalAmount { get; set; }

        public void Deposit(decimal amount)
        {
            // %10 bonus
            TotalAmount += (amount + amount * (decimal)0.1);
        }

        public void Transfer(IAccount toAccount, decimal amount)
        {
            // %10 commission

            TotalAmount -= amount * (decimal)1.1;
            toAccount.Deposit(amount);
        }
    }
}