using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.MediatorPattern
{
    public class StockMediator : IMediator
    {
        List<StockOffer> buyStockOffers = new List<StockOffer>();
        List<StockOffer> saleStockOffers = new List<StockOffer>();

        public void BuyOffer(string stockName, int numOfShares, Collegue collegue)
        {
            bool isOfferSatisfied = false;

            foreach (var sellOffer in saleStockOffers)
            {
                if (sellOffer.StockName == stockName && sellOffer.NumOfShares == numOfShares)
                {
                    isOfferSatisfied = true;
                    Console.WriteLine($"{collegue.Name} has bought {numOfShares}" +
                        $" {stockName} stocks from {sellOffer.OfferOwnerName}");
                }
            }

            if (isOfferSatisfied == false)
            {
                StockOffer stockOffer = new StockOffer(stockName, numOfShares, collegue.Name);
                buyStockOffers.Add(stockOffer);
            }
        }

        public void SaleOffer(string stockName, int numOfShares, Collegue collegue)
        {
            bool isOfferSatisfied = false;

            foreach (var buyOffer in buyStockOffers)
            {
                if (buyOffer.StockName == stockName && buyOffer.NumOfShares == numOfShares)
                {
                    isOfferSatisfied = true;
                    Console.WriteLine($"{collegue.Name} has sold {numOfShares}" +
                        $" {stockName} stocks to {buyOffer.OfferOwnerName}");
                }
            }

            if (isOfferSatisfied == false)
            {
                StockOffer stockOffer = new StockOffer(stockName, numOfShares, collegue.Name);
                saleStockOffers.Add(stockOffer);
            }
        }
    }
}
