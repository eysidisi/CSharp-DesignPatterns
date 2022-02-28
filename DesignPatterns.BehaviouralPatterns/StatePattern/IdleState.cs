using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.StatePattern
{
    public class IdleState : State
    {
        public State BuyProduct()
        {
            Console.WriteLine("You need to insert money first!");
            return this;
        }

        public State EjectMoney()
        {
            Console.WriteLine("You need to insert money first!");
            return this;
        }

        public State InsertMoney(int amount)
        {
            Console.WriteLine($"Inserted {amount} dollars!");
            return new DollarState(amount);
        }
    }
}
