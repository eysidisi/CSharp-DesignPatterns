using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.FacadePattern.Accounts
{
    public class InvestmentAccount : IAccount
    {
        public decimal TotalAmount { get; set; }

        public void Deposit(decimal amount)
        {
            TotalAmount += amount;
        }

        public void Transfer(IAccount toAccount, decimal amount)
        {
            TotalAmount -= amount;
            toAccount.Deposit(amount);
        }
    }
}
