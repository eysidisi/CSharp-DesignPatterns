namespace DesignPatterns.BehaviouralPatterns.ChainOfResponsibilityPattern
{
    public abstract class RequestHandler
    {
        RequestHandler nextHandler;

        protected RequestHandler(RequestHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        internal void Handle(string request)
        {
            if (ChekRequest(request))
            {
                ProcessRequest(request);
            }

            else if (nextHandler != null)
            {
                nextHandler.Handle(request);
            }
            else
            {
                Console.WriteLine("Request is not valid!");
            }
        }

        protected abstract void ProcessRequest(object request);

        protected abstract bool ChekRequest(string request);
    }
}