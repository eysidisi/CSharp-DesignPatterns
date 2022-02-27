using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.ProxyPattern
{
    public class OrderFulfillment : IOrder
    {
        private List<Warehouse> warehouses;

        public OrderFulfillment(List<Warehouse> warehouses)
        {
            this.warehouses = warehouses;
        }

        public void FullFillOrder(Order order)
        {
            foreach (var warehouse in warehouses)
            {
                if (CheckWarehouse(warehouse, order))
                {
                    warehouse.FullFillOrder(order);
                    Console.WriteLine($"{warehouse.Address} fulfilled the order!");
                }
            }
        }

        private bool CheckWarehouse(Warehouse warehouse, Order order)
        {
            if (warehouse.CurrentInventory(order.Name) > order.Number)
            {
                return true;
            }

            return false;
        }
    }
}
