using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.CompositePattern
{
    public interface IStructure
    {
        public string Enter();
        public string Exit();
        public string GetName();
        public string Location();
    }
}
