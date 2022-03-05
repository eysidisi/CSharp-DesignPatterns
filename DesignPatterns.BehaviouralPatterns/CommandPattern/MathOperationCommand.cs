using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.CommandPattern
{
    public abstract class MathOperationCommand : ICommand
    {
        protected Number number;
        protected int operationVal;

        protected MathOperationCommand(Number number, int operationVal)
        {
            this.number = number;
            this.operationVal = operationVal;
        }

        public abstract void Execute();
        public abstract void Unexecute();
    }
}
