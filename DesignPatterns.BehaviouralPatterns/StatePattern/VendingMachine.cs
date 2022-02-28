using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.StatePattern
{
    public class VendingMachine
    {
        State state;

        public VendingMachine()
        {
            state = new IdleState();
        }
        public void InsertMoney(int amount)
        {
            state = state.InsertMoney(amount);
        }

        public void EjectMoney()
        {
            state = state.EjectMoney();
        }

        public void BuyProduct()
        {
            state = state.BuyProduct();
        }
    }
}
