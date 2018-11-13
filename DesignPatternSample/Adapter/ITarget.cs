using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.Adapter
{
    public interface ITarget
    {
        List<string> GetEmployeeList();
    }
}
