using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Presentation.Manager
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 10000;
        }

        public decimal GetPay()
        {
            return 300;
        }
    }
}
