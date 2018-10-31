using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.AbstractFactory2.Product_B
{
    public class RegularScooter : Scooter
    {
        public override string Name()
        {
            return "Regular Scooter";
        }
    }
}
