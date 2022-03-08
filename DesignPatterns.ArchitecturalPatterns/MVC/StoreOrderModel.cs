namespace DesignPatterns.ArchitecturalPatterns.MVC
{
    public class StoreOrderModel
    {
        public IReadOnlyList<string> Items => items;
        public IReadOnlyList<int> Prices => prices;

        private List<IView> views = new List<IView>();
        private List<string> items = new List<string>();
        private List<int> prices = new List<int>();

        public string GetItem(int num)
        {
            return items[num];
        }

        public int GetPrice(int num)
        {
            return prices[num];
        }

        public void AddItem(string name, int price)
        {
            items.Add(name);
            prices.Add(price);
            Notify();
        }

        internal void DeleteItem(string name)
        {
            Predicate<string> predicate = (string x) => x.Equals(name);
            var index = items.FindIndex(predicate);
            items.RemoveAt(index);
            prices.Remove(index);
            Notify();
        }

        public void Subscribe(IView view)
        {
            views.Add(view);
        }
        public void Unsubscribe(IView view)
        {
            views.Remove(view);
        }

        public void Refresh()
        {
            Notify();
        }

        private void Notify()
        {
            foreach (var view in views)
            {
                view.Update(new List<string>(items), new List<int>(prices));
            }
        }
    }
}
