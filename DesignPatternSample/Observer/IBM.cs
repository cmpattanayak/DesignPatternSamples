﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.Observer
{
    public class IBM : Stock
    {
        public IBM(string symbol, double price) : base(symbol, price) { }
    }
}
