using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethodPattern
{
    public abstract class KnifeStore
    {
        public KnifeStore()
        {

        }
        public Knife OrderKnife(string type)
        {
            Knife knife = CreateKnife(type);

            knife.Sharpen();
            knife.Polish();

            return knife;
        }

        abstract protected Knife CreateKnife(string type);
    }
}
