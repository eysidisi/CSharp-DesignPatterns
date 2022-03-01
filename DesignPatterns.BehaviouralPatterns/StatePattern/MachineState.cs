using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.StatePattern
{
    public abstract class MachineState
    {
        protected int money;
        protected int numberOfProducts;
        protected int price;

        protected MachineState(int money, int numberOfProducts, int price)
        {
            this.money = money;
            this.numberOfProducts = numberOfProducts;
            this.price = price;
        }
        protected MachineState(MachineState machineState)
        {
            money = machineState.money;
            numberOfProducts = machineState.numberOfProducts;
            price = machineState.price;
        }
        public abstract MachineState InsertMoney(int amount);
        public abstract MachineState EjectMoney();
        public abstract MachineState BuyProduct();
        public virtual MachineState AddItems(int numberOfAddedProducts)
        {
            Console.WriteLine("Added items");
            numberOfProducts += numberOfAddedProducts;
            return this;
        }

    }
}
