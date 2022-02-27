using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.DecoraterPattern
{
    public class BasicWebPage : IWebPage
    {
        public void Display()
        {
            Console.WriteLine("Basic web page is displaying some stuff");
        }
    }
}
