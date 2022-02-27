using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.TemplateMethodPattern
{
    public class PenneAlfredo : PastaDish
    {
        protected override void AddSauce()
        {
            Console.WriteLine("Adding alfredo sauce");
        }

        protected override void CookPasta()
        {
            Console.WriteLine("Cooking penne alfredo");
        }
    }
}
