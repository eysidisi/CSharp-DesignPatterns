using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.CommandPattern
{
    public class MultiplicationCommand : MathOperationCommand
    {
        public MultiplicationCommand(Number number, int operationVal) : base(number, operationVal)
        {
        }

        public override void Execute()
        {
            number.Val *= operationVal;
        }

        public override void Unexecute()
        {
            number.Val /= operationVal;
        }
    }
}
