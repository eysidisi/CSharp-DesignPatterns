using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethodPattern.SteakKnives
{
    public class SteakKnifeStore : KnifeStore
    {
        protected override Knife CreateKnife(string type)
        {
            Knife knife = null;

            if (type.ToUpper()=="GOOD")
            {
                knife =new GoodSteakKnife();
            }
            else if (type.ToUpper()=="BAD")
            {
                knife = new BadSteakKnife();
            }

            return knife;
        }
    }
}
