using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.AbstractFactory.ProductA
{
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore hv)
        {
            Console.WriteLine(this.GetType().Name + " eats " + hv.GetType().Name);
        }
    }
}
