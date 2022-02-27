using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.TemplateMethodPattern
{
    public class SpaghettiMeatballs : PastaDish
    {
        protected override void AddSauce()
        {
            Console.WriteLine("Adding tomato paste");        
        }

        protected override void CookPasta()
        {
            Console.WriteLine("Cooking for spaghetti with meatballs");        
        }
    }
}
