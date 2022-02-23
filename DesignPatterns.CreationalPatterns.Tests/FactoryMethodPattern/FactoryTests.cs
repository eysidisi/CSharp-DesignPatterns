using DesignPatterns.CreationalPatterns.FactoryMethodPattern;
using DesignPatterns.CreationalPatterns.FactoryMethodPattern.ChefsKnives;
using DesignPatterns.CreationalPatterns.FactoryMethodPattern.SteakKnives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesignPatterns.CreationalPatterns.Tests.FactoryMethodPattern
{
    public class FactoryTests
    {
        [Fact]
        public void OrderKnife_CreateSteakKnife_GetsKnife()
        {
            // Arrange
            KnifeStore knifeStore = new SteakKnifeStore();
            Knife goodKnife = knifeStore.OrderKnife("good");
            Knife badKnife = knifeStore.OrderKnife("BaD");

            // Act Assert
            Assert.Equal(goodKnife.Name, "Good Steak Knife");
            Assert.Equal(badKnife.Name, "Bad Steak Knife");
        }

        [Fact]
        public void OrderKnife_CreateChefsKnife_GetsKnife()
        {
            // Arrange
            KnifeStore knifeStore = new ChefsKnifeStore();
            Knife goodKnife = knifeStore.OrderKnife("good");
            Knife badKnife = knifeStore.OrderKnife("bad");

            // Act Assert
            Assert.Equal(goodKnife.Name, "Good Chefs Knife");
            Assert.Equal(badKnife.Name, "Bad Chefs Knife");
        }
    }
}
