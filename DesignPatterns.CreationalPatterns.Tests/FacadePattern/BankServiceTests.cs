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
            decimal initialSavingAmount = 100;
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
            decimal initialSavingAmount = 100;
            BankService bankService = new BankService();

            // Act
            var investmentAccId = bankService.CreateAccount("investment", initialSavingAmount);
            decimal expectedAmount = 100;
            decimal actualAmount = bankService.GetAccAmount(investmentAccId);

            // Assert
            Assert.Equal(expectedAmount, actualAmount);
        }

        [Fact]
        public void TransferMoney_TranfersMoney()
        {
            // Arrange
            decimal initialSavingAmount = 100;
            BankService bankService = new BankService();
            decimal transferVal = 20;

            // Act
            var investmentAccId1 = bankService.CreateAccount("investment", initialSavingAmount);
            var investmentAccId2 = bankService.CreateAccount("investment", initialSavingAmount);

            bankService.TransferMoney(investmentAccId1, investmentAccId2, transferVal);

            // Assert
            Assert.Equal(80, bankService.GetAccAmount(investmentAccId1));
            Assert.Equal(120, bankService.GetAccAmount(investmentAccId2));
        }

    }
}
