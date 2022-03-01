using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.StatePattern
{
    public class DollarState : MachineState
    {
        public DollarState(MachineState machineState) : base(machineState)
        {
        }

        public DollarState(int money, int numberOfProducts, int price) : base(money, numberOfProducts, price)
        {
        }

        public override MachineState BuyProduct()
        {
            if (money >= price)
            {
                Console.WriteLine("Bought 1 item");
                money -= price;
                numberOfProducts--;
            }

            else
            {
                Console.WriteLine($"Need {price - money} dollars");
            }

            Console.WriteLine($"Remaining money {money} dollars");

            if (numberOfProducts == 0)
            {
                return new OutOfStockState(money, 0, price);
            }

            return this;
        }

        public override MachineState EjectMoney()
        {
            Console.WriteLine($"{money} dollars are ejected");
            return new IdleState(0, numberOfProducts, price);
        }

        public override MachineState InsertMoney(int amount)
        {
            Console.WriteLine($"{amount} dollars is inserted");
            money += amount;
            return this;
        }
    }
}
