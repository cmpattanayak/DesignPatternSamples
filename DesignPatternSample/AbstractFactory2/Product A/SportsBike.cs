using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.AbstractFactory2.Product_A
{
    public class SportsBike : Bike
    {
        public override string Name()
        {
            return "Sports Bike";
        }
    }
}
