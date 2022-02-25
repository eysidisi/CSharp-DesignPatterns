using System;
using DesignPatterns.StructuralPatterns;
namespace DesingPatterns.Test
{
    internal class Program
    {
        enum Pattern
        {
            Composite
        }
        static void Main(string[] args)
        {
            Pattern patternToTest = Pattern.Composite;

            switch (patternToTest)
            {
                case Pattern.Composite:
                    CompositePatternExample();
                    break;
                default:
                    break;
            }

        }

        private static void CompositePatternExample()
        {
            string houseAddress = "A house address";
            Housing housing = new Housing(houseAddress);

            int numOfRooms = 3;
            List<Room> rooms = new List<Room>();

            for (int i = 0; i < numOfRooms; i++)
            {
                Room room = new Room("Room " + i);
                rooms.Add(room);
                housing.AddStructure(room);
            }

            Console.WriteLine(housing.GetName());
            Console.WriteLine(housing.Location());

            Console.WriteLine(housing.Enter());
            Console.WriteLine(housing.Exit());

            Console.WriteLine(rooms[0].Enter());
        }
    }
}
