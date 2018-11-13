using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.Strategy
{
    public class ShellSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            Console.WriteLine("Shellsorted list");
        }
    }
}
