using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.MediatorPattern
{
    public interface IMediator
    {
        public void SaleOffer(string stockName, int numberOfShares, Collegue collegue);
        public void BuyOffer(string stockName, int numberOfShares, Collegue collegue);
    }
}
