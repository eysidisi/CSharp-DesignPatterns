using DesignPatterns.CreationalPatterns.FacadePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesignPatterns.CreationalPatterns.Tests.FacadePattern
{
    public class BankServiceTests
    {
        [Fact]
        public void CreateSavingAccount_CreatesSavingAccount()
        {
            // Arrange
            int initialSavingAmount = 100;
            BankService bankService = new BankService();
            
            // Act
            var savingAccId = bankService.CreateAccount("saving", initialSavingAmount);
            decimal expectedAmount = 110;
            decimal actualAmount=bankService.GetAccAmount(savingAccId);

            // Assert
            Assert.Equal(expectedAmount, actualAmount);
        }

        [Fact]
        public void CreateInvestmentAccount_CreatesSavingAccount()
        {
            // Arrange
            int initialSavingAmount = 100;
            BankService bankService = new BankService();

            // Act
            var investmentAccId = bankService.CreateAccount("investment", initialSavingAmount);
            decimal expectedAmount = 100;
            decimal actualAmount = bankService.GetAccAmount(investmentAccId);

            // Assert
            Assert.Equal(expectedAmount, actualAmount);
        }
    }
}
