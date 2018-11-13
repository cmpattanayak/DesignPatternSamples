using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.Strategy
{
    public class QuickSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("Quicksorted list");
        }
    }
}
