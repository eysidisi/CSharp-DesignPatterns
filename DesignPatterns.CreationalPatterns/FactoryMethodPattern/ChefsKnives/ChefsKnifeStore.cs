using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethodPattern.ChefsKnives
{
    public class ChefsKnifeStore : KnifeStore
    {
        protected override Knife CreateKnife(string type)
        {
            Knife knife = null;

            if (type.ToUpper() == "GOOD")
            {
                knife = new GoodChefsKnife();
            }
            else if (type.ToUpper() == "BAD")
            {
                knife = new BadChefsKnife();
            }

            return knife;
        }
    }
}
