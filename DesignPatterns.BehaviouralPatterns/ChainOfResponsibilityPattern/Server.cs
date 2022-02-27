using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.ChainOfResponsibilityPattern
{
    public class Server
    {
        RequestHandler requestHandler;

        public Server(RequestHandler requestHandler)
        {
            this.requestHandler = requestHandler;
        }

        public void ProcessRequest(string request)
        {
            requestHandler.Handle(request);
        }
    }
}
