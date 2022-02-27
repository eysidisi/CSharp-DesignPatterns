using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.DecoraterPattern
{
    public class AuthorizedWebPage : WebPageDecorater
    {
        public AuthorizedWebPage(IWebPage webPage) : base(webPage)
        {
        }

        public override void Display()
        {
            base.Display();
            DoAuthorization();
        }

        private void DoAuthorization()
        {
            Console.WriteLine("AuthorizedWebPage doing some stuff");
        }
    }
}
