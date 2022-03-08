namespace DesignPatterns.ArchitecturalPatterns.MVC
{
    public class OrderController
    {
        StoreOrderModel storeOrderModel;

        public OrderController(StoreOrderModel storeOrderModel)
        {
            this.storeOrderModel = storeOrderModel;
        }

        public void AddItem(string name, int price)
        {
            storeOrderModel.AddItem(name, price);
        }

        public void Refresh()
        {
            storeOrderModel.Refresh();
        }

        internal void DeleteItem(string name)
        {
            storeOrderModel.DeleteItem(name);
        }
    }
}