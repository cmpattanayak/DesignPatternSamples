using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.Strategy
{
    public class SortedList
    {
        private ISortStrategy _sortStrategy;
        private List<string> list = new List<string>();

        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            list.Add(name);
        }

        public void Sort()
        {
            _sortStrategy.Sort(list);

            foreach (string name in list)
            {
                Console.WriteLine(" " + name);
            }
        }
    }
}
