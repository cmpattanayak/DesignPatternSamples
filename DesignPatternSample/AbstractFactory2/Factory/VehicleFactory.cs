using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.AbstractFactory2.Factory
{
    public interface VehicleFactory
    {
        Bike CreateBikeFactory(string bike);
        Scooter CreateScooterFactory(string scooter);
    }
}
