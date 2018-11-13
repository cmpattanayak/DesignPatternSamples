using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.Strategy
{
    public class MergeSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            Console.WriteLine("Mergrsorted list");
        }
    }
}
