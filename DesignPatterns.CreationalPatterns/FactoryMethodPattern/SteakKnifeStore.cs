using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethodPattern
{
    public class SteakKnifeStore : KnifeStore
    {
        protected override Knife CreateKnife(string name)
        {
            return new SteakKnife() { Name = name };
        }
    }
}
