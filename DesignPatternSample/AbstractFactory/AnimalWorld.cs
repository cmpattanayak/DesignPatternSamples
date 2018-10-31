using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.AbstractFactory
{
    public class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory cf)
        {
            _carnivore = cf.CreateCarnivore();
            _herbivore = cf.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
