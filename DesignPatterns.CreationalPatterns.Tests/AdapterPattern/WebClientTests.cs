using DesignPatterns.CreationalPatterns.AdapterPattern;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesignPatterns.CreationalPatterns.Tests.AdapterPattern
{
    public class WebClientTests
    {
        [Fact]
        public void DoWork_DoesntThrowAnyExceptions_DoesWorkProperly()
        {
            // Arrange
            var webAdapter = new Mock<IWebRequester>();
            webAdapter.Setup(w => w.Request(It.IsAny<object>())).Returns(200);
            WebClient webClient = new WebClient(webAdapter.Object);

            // Act && Assert
            // Expecting not to throw any exceptions
            webClient.DoWork();
        }

        [Fact]
        public void DoWork_ThrowsBadRequest()
        {
            // Arrange
            var webAdapter = new Mock<IWebRequester>();
            webAdapter.Setup(w => w.Request(It.IsAny<object>())).Returns(400);
            WebClient webClient = new WebClient(webAdapter.Object);

            // Act && Assert
            var ex = Assert.Throws<HttpRequestException>(() => webClient.DoWork());
            Assert.Equal("Bad request".ToUpper(), ex.Message);
        }

        [Fact]
        public void DoWork_ThrowsAnError()
        {
            // Arrange
            var webAdapter = new Mock<IWebRequester>();
            webAdapter.Setup(w => w.Request(It.IsAny<object>())).Returns(300);
            WebClient webClient = new WebClient(webAdapter.Object);

            // Act && Assert
            var ex = Assert.Throws<HttpRequestException>(() => webClient.DoWork());
            Assert.Equal("Somekind of an error".ToUpper(), ex.Message);
        }

    }
}
