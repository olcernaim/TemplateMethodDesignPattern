using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    public abstract class BeverageMaker
    {
        public virtual void makeBeverage()
        {
            boilWater();
            brew();
            pourInCup();
            addCondiments();
        }
        public abstract void brew();//Demlemek
        public abstract void addCondiments();//Baharat eklemek
        void boilWater()
        {
            Console.WriteLine("Boiling water");
        }
        void pourInCup()
        {
            Console.WriteLine("Poring into cup");
        }
    }
}
