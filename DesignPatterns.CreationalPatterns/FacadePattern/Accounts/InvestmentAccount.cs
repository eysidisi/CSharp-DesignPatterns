using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FacadePattern.Accounts
{
    public class InvestmentAccount : IAccount
    {
        public decimal TotalAmount { get; set; }

        public void Deposit(int amount)
        {
            TotalAmount += amount;
        }
    }
}
