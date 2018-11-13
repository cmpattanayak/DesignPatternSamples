using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.Adapter
{
    /// <summary>
    /// The Client Class
    /// </summary>
    public class ThirdPartyBillingSystem
    {
        private ITarget employeeSource;

        public ThirdPartyBillingSystem(ITarget employeeSource)
        {
            this.employeeSource = employeeSource;
        }

        public void ShowEmployeeList()
        {
            List<string> employee = employeeSource.GetEmployeeList();
            //To DO: Implement your business logic

            Console.WriteLine("######### Employee List ##########");
            foreach (var item in employee)
            {
                Console.Write(item);
            }
        }
    }
}
