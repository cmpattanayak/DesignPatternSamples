using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Presentation.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobDescription { get; set; }
        public string Number { get; set; }
        public string Department { get; set; }
        [DisplayName("Employee Type")]
        public int EmployeeTypeId { get; set; }
        public decimal HourlyPay { get; set; }
        public decimal Bonus { get; set; }
    }
}
