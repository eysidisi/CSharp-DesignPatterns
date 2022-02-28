using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.StatePattern
{
    public interface State
    {
        public State InsertMoney(int amount);
        public State EjectMoney();
        public State BuyProduct();
    }
}
