using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.Factory
{
    public class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
        }
    }
}
