using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.DecoraterPattern
{
    public class AuthenticatedWebPage : WebPageDecorater
    {
        public AuthenticatedWebPage(IWebPage webPage) : base(webPage)
        {
        }

        public override void Display()
        {
            base.Display();
            DoAuthentication();
        }

        private void DoAuthentication()
        {
            Console.WriteLine("AuthenticatedWebPage doing some stuff"); 
        }
    }
}
