using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.AdapterPattern
{
    public class WebAdapter : IWebRequester
    {
        WebService webService;
        public int Request(object obj)
        {
            var json = ToJson(obj);
            return webService.Request(json);
        }

        public void Connect(WebService webService)
        {
            this.webService = webService;

            // Connects to the web service somehow
        }

        private string ToJson(object obj)
        {
            return obj.ToString();
        }
    }
}
