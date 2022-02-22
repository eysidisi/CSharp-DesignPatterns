namespace DesignPatterns.CreationalPatterns.FactoryMethodPattern
{
    public class ChefsKnife : Knife
    {
        public void Cut()
        {
            Console.WriteLine("Chefs knife cuts deep!");
        }
    }
}