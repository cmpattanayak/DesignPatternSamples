using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.AbstractFactory2.Product_A
{
    public class RegularBike : Bike
    {
        public override string Name()
        {
            return "Regular Bike";
        }
    }
}
