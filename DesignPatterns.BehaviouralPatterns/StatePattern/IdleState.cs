using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.StatePattern
{
    public class IdleState : MachineState
    {
        public IdleState(MachineState machineState) : base(machineState)
        {
        }

        public IdleState(int money, int numberOfProducts, int price) : base(money, numberOfProducts, price)
        {
        }

        public override MachineState BuyProduct()
        {
            Console.WriteLine("You need to insert money first!");
            return this;
        }

        public override MachineState EjectMoney()
        {
            Console.WriteLine("You need to insert money first!");
            return this;
        }

        public override MachineState InsertMoney(int amount)
        {
            Console.WriteLine($"Inserted {amount} dollars!");
            money = amount;
            return new DollarState(money, numberOfProducts, price);
        }
    }
}
