using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Template.StarbuzzExample
{
    public abstract class CaffeineBeverageWithHook
    {
        protected void PrepareRecipe()
        {
            this.BoilWater();
            this.Brew();
            this.PourInCup();
            if (this.CustomerWantsCondiments())
            {
                this.AddCondiments();
            }
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        public void BoilWater()
        {
            Console.WriteLine("Boiling Water.");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup.");
        }

        public bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}
