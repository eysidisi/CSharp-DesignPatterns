using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.AdapterPattern
{
    public class WebClient
    {
        IWebRequester webRequester;

        public WebClient(IWebRequester webRequester)
        {
            this.webRequester = webRequester;
        }


        public void DoWork()
        {
            var obj = MakeObject();
            var reqResult = webRequester.Request(obj);

            if (reqResult == 200)
            {

            }

            else if (reqResult == 400)
            {
                throw new HttpRequestException("Bad request".ToUpper());
            }

            else
            {
                throw new HttpRequestException("Somekind of an error".ToUpper());
            }
        }

        private object MakeObject()
        {
            return "An Object";
        }
    }
}
