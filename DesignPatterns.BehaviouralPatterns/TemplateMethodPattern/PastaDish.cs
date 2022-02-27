using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.TemplateMethodPattern
{
    public abstract class PastaDish
    {
        public void MakeRecipe()
        {
            BoilWater();
            AddPasta();
            CookPasta();
            DrainAndPlate();
            AddSauce();
        }

        protected abstract void AddSauce();
        protected abstract void CookPasta();

        private void DrainAndPlate()
        {
            Console.WriteLine("Draining and plating");
        }

        private void AddPasta()
        {
            Console.WriteLine("Adding pasta");
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
    }
}
