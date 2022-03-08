using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ArchitecturalPatterns.MVC
{
    public class OrderView : IView
    {
        private OrderController controller;

        public OrderView(OrderController controller)
        {
            this.controller = controller;
        }

        public void CreateUI()
        {
            while (true)
            {
                Console.WriteLine("Press 0 to add an element");
                Console.WriteLine("Press 1 to delete an element");
                Console.WriteLine("Press -1 to quit");

                string input = Console.ReadLine();
                if (input == "0")
                {
                    Console.WriteLine("Enter name");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter price");
                    int price = int.Parse(Console.ReadLine());

                    controller.AddItem(name, price);
                }
                
                else if (input == "1")
                {
                    Console.WriteLine("Enter name");
                    string name = Console.ReadLine();

                    controller.DeleteItem(name);
                }

                else if (input == "-1")
                {
                    Console.WriteLine("Quitting...");
                    break;
                }

                else
                {
                    Console.WriteLine("Undefined command ID");
                }

                Console.WriteLine();
            }
        }

        private void DisplayItems()
        {
            controller.Refresh();
        }

        public void Update(List<string> items, List<int> prices)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i] + " : " + prices[i]);
            }
        }
    }
}
