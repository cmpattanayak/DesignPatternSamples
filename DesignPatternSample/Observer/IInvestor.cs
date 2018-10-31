using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.Observer
{
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
