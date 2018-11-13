using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.Strategy
{
    public interface ISortStrategy
    {
        void Sort(List<string> list);
    }
}
