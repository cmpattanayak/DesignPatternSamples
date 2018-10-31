using DesignPatternSample.AbstractFactory2.Product_A;
using DesignPatternSample.AbstractFactory2.Product_B;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.AbstractFactory2.Factory
{
    public class HeroFactory : VehicleFactory
    {
        public Bike CreateBikeFactory(string bike)
        {
            switch (bike)
            {
                case "Sports":
                    return new SportsBike();
                case "Regular":
                    return new RegularBike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", bike));
            }
        }

        public Scooter CreateScooterFactory(string scooter)
        {
            switch (scooter)
            {
                case "Sports":
                    return new Scooty();
                case "Regular":
                    return new RegularScooter();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", scooter));
            }
        }
    }
}
