using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.CommandPattern
{
    public class AdditionCommand : MathOperationCommand
    {
        public AdditionCommand(Number number, int operationVal) : base(number, operationVal)
        {
        }

        public override void Execute()
        {
            number.Val += operationVal;
        }

        public override void Unexecute()
        {
            number.Val -= operationVal;
        }
    }
}
