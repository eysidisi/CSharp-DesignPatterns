using System;
using DesignPatterns.BehaviouralPatterns.ChainOfResponsibilityPattern;
using DesignPatterns.BehaviouralPatterns.CommandPattern;
using DesignPatterns.BehaviouralPatterns.MediatorPattern;
using DesignPatterns.BehaviouralPatterns.ObserverPattern;
using DesignPatterns.BehaviouralPatterns.StatePattern;
using DesignPatterns.BehaviouralPatterns.TemplateMethodPattern;
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
            Decorator,
            TemplateMethodPattern,
            ChainOfResponsibilityPattern,
            StatePattern,
            CommandPattern,
            MediatorPattern,
            ObserverPattern
        }

        static void Main(string[] args)
        {
            Pattern patternToTest = Pattern.ObserverPattern;

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
                case Pattern.TemplateMethodPattern:
                    TemplateMethodPatternExample();
                    break;
                case Pattern.ChainOfResponsibilityPattern:
                    ChainOfResponsibilityPatternExample();
                    break;
                case Pattern.StatePattern:
                    StatePatternExample();
                    break;
                case Pattern.CommandPattern:
                    CommandPatternExample();
                    break;
                case Pattern.MediatorPattern:
                    MediatorPatternExample();
                    break;
                case Pattern.ObserverPattern:
                    ObserverPatternExample();
                    break;
                default:
                    break;
            }
        }

        private static void ObserverPatternExample()
        {
            Blog blog = new Blog();
            BlogReader reader1 = new BlogReader("reader1");
            BlogReader reader2 = new BlogReader("reader2");
            
            blog.RegisterObserver(reader1);
            blog.RegisterObserver(reader2);

            blog.AddNewArticle("Article 1");

            blog.UnregisterObserver(reader2);

            blog.AddNewArticle("Article 2");
        }

        private static void MediatorPatternExample()
        {
            StockMediator stockMediator = new StockMediator();
            Trader trader1 = new Trader(stockMediator, "Trader 1");
            Trader trader2 = new Trader(stockMediator, "Trader 2");

            trader1.BuyOffer("GOOGLE", 5);
            trader2.SaleOffer("GOOGLE", 5);

            trader2.SaleOffer("GOOGLE", 3);
            trader1.BuyOffer("GOOGLE", 3);
        }

        private static void CommandPatternExample()
        {
            Number number = new Number() { Val = 5 };

            int increaseAmount = 3;
            int multiplyAmount = 2;

            MathOperationCommand addition = new AdditionCommand(number, increaseAmount);
            MathOperationCommand multiply = new MultiplicationCommand(number, multiplyAmount);
            List<MathOperationCommand> commands = new List<MathOperationCommand>() { addition, multiply };

            Console.WriteLine("Before Operations " + number);

            for (int i = 0; i < commands.Count; i++)
            {
                var command = commands[i];
                command.Execute();
            }

            Console.WriteLine("After Operations " + number);

            for (int i = commands.Count - 1; i >= 0; i--)
            {
                var command = commands[i];
                command.Unexecute();
            }

            Console.WriteLine("After Undos " + number);
        }

        private static void StatePatternExample()
        {
            VendingMachine vendingMachine = new VendingMachine(2, 1);
            vendingMachine.InsertMoney(5);
            vendingMachine.BuyProduct();
            vendingMachine.BuyProduct();
            vendingMachine.BuyProduct();
            vendingMachine.InsertMoney(2);
            vendingMachine.EjectMoney();
            vendingMachine.BuyProduct();
            vendingMachine.InsertMoney(1);
            vendingMachine.BuyProduct();
            vendingMachine.AddItems(2);
            vendingMachine.BuyProduct();
        }

        private static void ChainOfResponsibilityPatternExample()
        {
            RequestHandler handler2 = new Handler2(null);
            RequestHandler handler1 = new Handler1(handler2);

            Server server = new Server(handler1);

            server.ProcessRequest("1");
            server.ProcessRequest("2");
            server.ProcessRequest("3");
        }

        private static void TemplateMethodPatternExample()
        {
            PenneAlfredo penneAlfredo = new PenneAlfredo();
            SpaghettiMeatballs spaghettiMeatballs = new SpaghettiMeatballs();
            penneAlfredo.MakeRecipe();
            Console.WriteLine();
            spaghettiMeatballs.MakeRecipe();
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
