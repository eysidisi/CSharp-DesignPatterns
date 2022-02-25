using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns
{
    public class Room : IStructure
    {
        string name;

        public Room(string name)
        {
            this.name = name;
        }

        public string Enter()
        {
            return $"you entered room {GetName()}";
        }

        public string Exit()
        {
            return $"you exited room {GetName()}";
        }

        public string GetName()
        {
            return name;
        }

        public string Location()
        {
            return $"You are currently in {GetName}";
        }
    }
}
