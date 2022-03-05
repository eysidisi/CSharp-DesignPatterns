using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.MediatorPattern
{
    public class StockOffer
    {
        public string StockName { get; private set; }
        public int NumOfShares { get; private set; }
        public string OfferOwnerName { get; private set; }
    
        public StockOffer(string stockName, int stockAmount, string offerOwner)
        {
            StockName = stockName;
            NumOfShares = stockAmount;
            OfferOwnerName = offerOwner;
        }
    }
}
