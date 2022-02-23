using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethodPattern
{
    public abstract class Knife
    {
        public abstract string Name { get;  }
        public void Sharpen()
        {
        }

        public void Polish()
        {
        }
    }
}
