using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.DecoraterPattern
{
    public abstract class WebPageDecorater : IWebPage
    {
        protected IWebPage webPage;

        protected WebPageDecorater(IWebPage webPage)
        {
            this.webPage = webPage;
        }

        public virtual void Display()
        {
            webPage.Display();
        }
    }
}
