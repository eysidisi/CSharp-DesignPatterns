using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.MediatorPattern
{
    public class Trader : Collegue
    {
        public Trader(IMediator mediator, string name) : base(mediator, name)
        {
        }
    }
}
