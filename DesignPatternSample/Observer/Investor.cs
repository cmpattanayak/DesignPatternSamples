using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.Observer
{
    public class Investor : IInvestor
    {
        private string name;
        private Stock _stock;

        public Stock Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public Investor(string name)
        {
            this.name = name;
        }
        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}", name, stock.Symbol, stock.Price);
        }
    }
}
