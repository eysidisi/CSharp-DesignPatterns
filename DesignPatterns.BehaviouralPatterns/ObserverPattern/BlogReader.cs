using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.ObserverPattern
{
    public class BlogReader : IObserver
    {
        string name;
        public BlogReader(string name)
        {
            this.name = name;
        }

        public void Update(string article)
        {
            Console.WriteLine(name + " read the article " + article);
        }
    }
}
