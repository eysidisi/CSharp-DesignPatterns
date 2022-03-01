using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.StatePattern
{
    public class VendingMachine
    {
        MachineState state;

        public VendingMachine(int numberOfProducts, int price)
        {
            state = new IdleState(0, numberOfProducts, price);
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

        public void AddItems(int numberOfItems)
        {
            state = state.AddItems(numberOfItems);
        }
    }
}
