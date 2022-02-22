using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethodPattern
{
    public abstract class Knife
    {
        public string Name { get; protected set; }
        public void Sharpen()
        {
        }

        public void Polish()
        {
        }
    }
}
