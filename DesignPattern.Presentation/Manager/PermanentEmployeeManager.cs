using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Presentation.Manager
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 15000;
        }

        public decimal GetPay()
        {
            return 500;
        }
    }
}
