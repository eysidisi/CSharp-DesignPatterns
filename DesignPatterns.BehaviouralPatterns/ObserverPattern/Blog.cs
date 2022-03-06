using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.ObserverPattern
{
    public class Blog : Subject
    {
        List<string> articles = new List<string>();

        public IReadOnlyList<string> Articles => articles;

        public void AddNewArticle(string article)
        {
            articles.Add(article);
            Notify();
        }

        protected override void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(articles.Last());
            }
        }
    }
}
