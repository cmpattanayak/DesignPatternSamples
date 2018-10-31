using DesignPatternSample.AbstractFactory.ProductA;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.AbstractFactory
{
    public class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}
