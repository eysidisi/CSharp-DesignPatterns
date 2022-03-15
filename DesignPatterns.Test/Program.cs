using System;
using DesignPatterns.ArchitecturalPatterns.MVC;
using DesignPatterns.BehaviouralPatterns.ChainOfResponsibilityPattern;
using DesignPatterns.BehaviouralPatterns.CommandPattern;
using DesignPatterns.BehaviouralPatterns.MediatorPattern;
using DesignPatterns.BehaviouralPatterns.ObserverPattern;
using DesignPatterns.BehaviouralPatterns.StatePattern;
using DesignPatterns.BehaviouralPatterns.TemplateMethodPattern;
using DesignPatterns.CreationalPatterns.FactoryMethodPattern;
using DesignPatterns.CreationalPatterns.FactoryMethodPattern.ChefsKnives;
using DesignPatterns.CreationalPatterns.FactoryMethodPattern.SteakKnives;
using DesignPatterns.CreationalPatterns.SingletonPattern;
using DesignPatterns.StructuralPatterns.AdapterPattern;
using DesignPatterns.StructuralPatterns.CompositePattern;
using DesignPatterns.StructuralPatterns.DecoraterPattern;
using DesignPatterns.StructuralPatterns.FacadePattern;
using DesignPatterns.StructuralPatterns.ProxyPattern;

namespace DesingPatterns.Test
{
    internal class Program
    {
        enum Pattern
        {
            Singleton,
            Factory,
            Adapter,
            Composite,
            Decorator,
            Facade,
            Proxy,
            ChainOfResponsibility,
            Command,
            Mediator,
            Observer,
            State,
            TemplateMethod,
            MVC
        }

        static void Main(string[] args)
        {
            Pattern patternToTest = Pattern.Facade;

            switch (patternToTest)
            {
                case Pattern.Singleton:
                    SingletonPatternExample();
                    break;
                case Pattern.Factory:
                    FactoryPatternExample();
                    break;
                case Pattern.Adapter:
                    AdapterPatternExample();
                    break;
                case Pattern.Composite:
                    CompositePatternExample();
                    break;
                case Pattern.Decorator:
                    DecoratorPatternExample();
                    break;
                case Pattern.Facade:
                    FacadePatternExample();
                    break;
                case Pattern.Proxy:
                    ProxyPatternExample();
                    break;
                case Pattern.ChainOfResponsibility:
                    ChainOfResponsibilityPatternExample();
                    break;
                case Pattern.Command:
                    CommandPatternExample();
                    break;
                case Pattern.Mediator:
                    MediatorPatternExample();
                    break;
                case Pattern.Observer:
                    ObserverPatternExample();
                    break;
                case Pattern.State:
                    StatePatternExample();
                    break;
                case Pattern.TemplateMethod:
                    TemplateMethodPatternExample();
                    break;
                case Pattern.MVC:
                    MVCPatternExample();
                    break;
                default:
                    break;
            }
        }

        private static void FacadePatternExample()
        {
            BankService bankService = new BankService();

            var savingAccID = bankService.CreateAccount("SAVING", 10);
            var investmentAccID = bankService.CreateAccount("INVESTMENT", 10);

            Console.WriteLine("Money in acc 1 with bonuses: " + bankService.GetAccAmount(savingAccID));
            Console.WriteLine("Money in acc 2 with bonuses: " + bankService.GetAccAmount(investmentAccID));

            Console.WriteLine("Transferring 5 dollars from acc1 to acc2 with transaction fees");

            bankService.TransferMoney(savingAccID, investmentAccID, 5);

            Console.WriteLine("Money in acc 1 with bonuses: " + bankService.GetAccAmount(1));
            Console.WriteLine("Money in acc 2 with bonuses: " + bankService.GetAccAmount(2));
        }

        private static void AdapterPatternExample()
        {
            WebAdapter adapter = new WebAdapter();

            WebClient webClient = new WebClient(adapter);

            WebService webService = new WebService();

            adapter.Connect(webService);

            webClient.DoWork();
        }

        private static void MVCPatternExample()
        {
            StoreOrderModel storeOrderModel = new StoreOrderModel();
            OrderController orderController = new OrderController(storeOrderModel);
            OrderView orderView = new OrderView(orderController);
            storeOrderModel.Subscribe(orderView);
            orderView.CreateUI();
        }

        private static void FactoryPatternExample()
        {
            KnifeStore chefsKnifeStore = new ChefsKnifeStore();
            KnifeStore steakKnifeStore = new SteakKnifeStore();

            var chefsKnife = chefsKnifeStore.OrderKnife("good");
            Console.WriteLine(chefsKnife.Name);

            var steakKnife = steakKnifeStore.OrderKnife("good");
            Console.WriteLine(steakKnife.Name);
        }

        private static void SingletonPatternExample()
        {
            SingletonClass singletonClass = SingletonClass.GetInstance();
            Console.WriteLine(singletonClass.AnInteger);
            singletonClass.IncreaseInteger();
            Console.WriteLine(singletonClass.AnInteger);
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
