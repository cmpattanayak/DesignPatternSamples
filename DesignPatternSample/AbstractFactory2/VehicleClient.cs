using DesignPatternSample.AbstractFactory2.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.AbstractFactory2
{
    public class VehicleClient
    {
        Bike bike;
        Scooter scooter;

        public VehicleClient(VehicleFactory factory, string type)
        {
            bike = factory.CreateBikeFactory(type);
            scooter = factory.CreateScooterFactory(type);
        }

        public string GetBikeName()
        {
            return bike.Name();
        }

        public string GetScooterName()
        {
            return scooter.Name();
        }
    }
}
