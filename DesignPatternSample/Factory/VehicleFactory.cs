using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.Factory
{
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);
    }
}
