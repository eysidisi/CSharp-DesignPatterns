using DesignPatterns.CreationalPatterns.FactoryMethodPattern;
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
        public void CreateKnives()
        {
            KnifeStore knifeStore = new SteakKnifeStore();
            Knife knife = knifeStore.OrderKnife("asd");
            Console.WriteLine(knife);
        }
    }
}
