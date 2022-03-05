namespace DesignPatterns.BehaviouralPatterns.MediatorPattern
{
    public abstract class Collegue
    {
        IMediator mediator;
        public string Name { get; private set; }
        protected Collegue(IMediator mediator, string name)
        {
            this.mediator = mediator;
            Name = name;
            Console.WriteLine(name + " is ready for trade");
        }

        public void SaleOffer(string stockName, int numOfShares)
        {
            mediator.SaleOffer(stockName, numOfShares, this);
        }

        public void BuyOffer(string stockName, int numOfShares)
        {
            mediator.BuyOffer(stockName, numOfShares, this);
        }
    }
}