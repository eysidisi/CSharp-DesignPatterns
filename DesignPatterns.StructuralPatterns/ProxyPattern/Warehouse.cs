using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.ProxyPattern
{
    public class Warehouse : IOrder
    {
        Dictionary<string, int> stockNameToNumber = new Dictionary<string, int>();
        public string Address { get;private set; }
        public Warehouse(string address)
        {
            Address = address;
        }

        /* Other attributes would go here */

        public void FullFillOrder(Order order)
        {
            string orderName = order.Name;
            int orderNumber = order.Number;

            stockNameToNumber[orderName] -= orderNumber;

            /* Process the order for shipment and delivery */
        }

        public int CurrentInventory(string itemName)
        {
            return stockNameToNumber.ContainsKey(itemName) ? stockNameToNumber[itemName] : 0;
        }

        public void AddInventory(string itemName,int number)
        {
            if (stockNameToNumber.ContainsKey(itemName))
            {
                stockNameToNumber[itemName] += number;
            }

            else
            {
                stockNameToNumber.Add(itemName, number);
            }
        }
    }
}
