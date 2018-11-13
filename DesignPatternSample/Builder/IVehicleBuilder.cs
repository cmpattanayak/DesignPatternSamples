using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.Builder
{
    /// <summary>
    /// Builder Interface
    /// </summary>
    public interface IVehicleBuilder
    {
        void SetModel();
        void SetEngine();
        void SetTransmission();
        void SetBody();
        void SetAccessories();

        Vehicle GetVehicle();
    }
}
