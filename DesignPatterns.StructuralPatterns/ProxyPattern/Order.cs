namespace DesignPatterns.StructuralPatterns.ProxyPattern
{
    public class Order
    {
        public Order(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public int Number { get; private set; }
        public string Name { get; private set; }
    }
}