using DesignPatterns.StructuralPatterns.FacadePattern.Accounts;

namespace DesignPatterns.StructuralPatterns.FacadePattern
{
    public class BankService
    {
        Dictionary<int, IAccount> _accounts = new Dictionary<int, IAccount>();
        int nextAccountID = 1;
        public int CreateAccount(string accountType, decimal initialAmount)
        {
            IAccount account = null;

            if (accountType.ToUpper() == "SAVING")
            {
                account = new SavingAccount();
            }
            else if (accountType.ToUpper() == "INVESTMENT")
            {
                account = new InvestmentAccount();
            }
            if (account == null)
            {
                return -1;
            }

            account.Deposit(initialAmount);
            _accounts.Add(nextAccountID, account);

            return nextAccountID++;
        }

        public decimal GetAccAmount(int accID)
        {
            return _accounts[accID].TotalAmount;
        }

        public void TransferMoney(int fromAccID, int toAccID, decimal amount)
        {
            IAccount fromAcc = _accounts[fromAccID];
            IAccount toAcc = _accounts[toAccID];

            fromAcc.Transfer(toAcc, amount);
        }
    }
}