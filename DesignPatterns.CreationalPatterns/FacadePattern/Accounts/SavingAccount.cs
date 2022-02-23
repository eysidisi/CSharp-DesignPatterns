namespace DesignPatterns.CreationalPatterns.FacadePattern.Accounts
{
    internal class SavingAccount : IAccount
    {
        public decimal TotalAmount { get; set; }

        public void Deposit(int amount)
        {
            // %10 Bonus
            TotalAmount += (amount + amount * (decimal)0.1);
        }
    }
}