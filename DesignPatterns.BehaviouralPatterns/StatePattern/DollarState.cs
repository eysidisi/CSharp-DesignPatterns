using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.StatePattern
{
    public class DollarState : State
    {
        int money;
        int numberOf
        public DollarState(int money)
        {
            this.money = money;
        }

        public State BuyProduct()
        {
            throw new NotImplementedException();
        }

        public State EjectMoney()
        {
            throw new NotImplementedException();
        }

        public State InsertMoney(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
