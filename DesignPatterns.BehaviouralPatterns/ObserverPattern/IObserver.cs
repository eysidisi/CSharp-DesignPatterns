using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.ObserverPattern
{
    public interface IObserver
    {
        public void Update(string article);
    }
}
