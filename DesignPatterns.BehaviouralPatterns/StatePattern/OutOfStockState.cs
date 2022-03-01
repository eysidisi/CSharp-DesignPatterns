using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.StatePattern
{
    public class OutOfStockState : MachineState
    {
        public OutOfStockState(int money, int numberOfProducts, int price) : base(money, numberOfProducts, price)
        {
        }

        public override MachineState BuyProduct()
        {
            Console.WriteLine("Can't buy product. Need more items");
            return this;
        }

        public override MachineState EjectMoney()
        {
            Console.WriteLine($"Ejected {money} dollars");
            money = 0;
            return this;
        }

        public override MachineState InsertMoney(int amount)
        {
            Console.WriteLine($"Inserted {amount} dollars");
            money += amount;
            return this;
        }

        public override MachineState AddItems(int amount)
        {
            numberOfProducts += amount;
            Console.WriteLine("Added 1 item");
            if (money > 0)
            {
                return new DollarState(this);
            }
            return new IdleState(this);

        }
    }
}
