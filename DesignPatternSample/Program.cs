using DesignPatternSample.Factory;
using System;
using System.Threading.Tasks;

namespace DesignPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Singleton Pattern
            //Parallel.Invoke(
            //        () => PrintEmployeeDetails(),
            //        () => PrintStudentdetails()
            //    );
            #endregion Singleton Pattern

            #region Factory Pattern
            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(20);
            #endregion Factory Pattern

            Console.ReadLine();
        }

        private static void PrintEmployeeDetails()
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
        }

        private static void PrintStudentdetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
