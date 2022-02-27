using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.ChainOfResponsibilityPattern
{
    public class Handler1 : RequestHandler
    {
        public Handler1(RequestHandler nextHandler) : base(nextHandler)
        {
        }

        protected override bool ChekRequest(string request)
        {
            if (request == "1")
            {
                return true;
            }
            return false;
        }

        protected override void ProcessRequest(object request)
        {
            Console.WriteLine("Handler 1 handled request");
        }
    }
}
