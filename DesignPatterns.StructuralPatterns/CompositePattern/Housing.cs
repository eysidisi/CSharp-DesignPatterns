using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.CompositePattern
{
    public class Housing : IStructure
    {
        private string address;
        List<IStructure> structures;

        public Housing(string address)
        {
            this.address = address;
            structures = new List<IStructure>();
        }

        public int AddStructure(IStructure structure)
        {
            structures.Add(structure);
            return structures.Count - 1;
        }

        public string Enter()
        {
            return $"You entered house {GetName()}";
        }

        public string Exit()
        {
            return $"You exited house {address}";
        }

        public string Location()
        {
            string output = $"You are currently at {address} ";
            output += " It has:";

            foreach (var structure in structures)
            {
                output += $" {structure.GetName()} ";
            }

            return output;
        }

        public string GetName()
        {
            return $"House at {address}";
        }
    }
}
