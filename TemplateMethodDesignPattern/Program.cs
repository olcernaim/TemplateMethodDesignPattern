using System;

namespace TemplateMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making tea");

            BeverageMaker teaMaker = new TeaMaker();
            teaMaker.makeBeverage();

            Console.WriteLine("Making coffee");


            BeverageMaker coffeeMaker = new CoffeeMaker();
            coffeeMaker.makeBeverage();
        }
    }
}
