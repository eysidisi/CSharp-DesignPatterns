using DesignPatterns.CreationalPatterns.AdapterPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesignPatterns.CreationalPatterns.Tests.AdapterPattern
{
    public class WebServiceTests
    {
        [Fact]
        public void Request_ValidJson_Returns200()
        {
            // Arrange
            WebService webService = new WebService();
            string validJson = "a valid object";
            int expectedOutput = 200;

            // Act
            var actualOutput = webService.Request(validJson);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
