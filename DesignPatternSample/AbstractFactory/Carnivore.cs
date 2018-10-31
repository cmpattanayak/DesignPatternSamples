using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.AbstractFactory
{
    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore hv);
    }
}
