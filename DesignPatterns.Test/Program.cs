using System;
using DesignPatterns.StructuralPatterns;
using DesignPatterns.StructuralPatterns.DecoraterPattern;
using DesignPatterns.StructuralPatterns.ProxyPattern;

namespace DesingPatterns.Test
{
    internal class Program
    {
        enum Pattern
        {
            Composite,
            Proxy,
            Decorator
        }
        static void Main(string[] args)
        {
            Pattern patternToTest = Pattern.Decorator;

            switch (patternToTest)
            {
                case Pattern.Composite:
                    CompositePatternExample();
                    break;
                case Pattern.Proxy:
                    ProxyPatternExample();
                    break;
                case Pattern.Decorator:
                    DecoratorPatternExample();
                    break;
                default:
                    break;
            }
        }

        private static void DecoratorPatternExample()
        {
            BasicWebPage basicWebPage = new BasicWebPage();
            AuthorizedWebPage authorizedWebPage = new AuthorizedWebPage(basicWebPage);
            AuthenticatedWebPage authenticatedWebPage = new AuthenticatedWebPage(authorizedWebPage);

            authenticatedWebPage.Display();
        }

        private static void ProxyPatternExample()
        {
            Warehouse warehouse1 = new Warehouse("warehouse 1 address");
            warehouse1.AddInventory("order1", 1);

            Warehouse warehouse2 = new Warehouse("warehouse 2 address");
            warehouse2.AddInventory("order1", 2);

            Order order = new Order(1, "order1");

            OrderFulfillment orderFulfillment = new OrderFulfillment(new List<Warehouse>() { warehouse1, warehouse2 });
            orderFulfillment.FullFillOrder(order);
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
