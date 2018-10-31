using DesignPatternSample.AbstractFactory;
using DesignPatternSample.Facade;
using DesignPatternSample.Factory;
using DesignPatternSample.Observer;
using System;
using System.Threading.Tasks;
using abfac2 = DesignPatternSample.AbstractFactory2;

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
            //VehicleFactory factory = new ConcreteVehicleFactory();

            //IFactory scooter = factory.GetVehicle("Scooter");
            //scooter.Drive(10);

            //IFactory bike = factory.GetVehicle("Bike");
            //bike.Drive(20);
            #endregion Factory Pattern

            #region Abstract Factory Pattern
            //ContinentFactory africa = new AfricaFactory();
            //AnimalWorld world = new AnimalWorld(africa);
            //world.RunFoodChain();

            //ContinentFactory america = new AmericaFactory();
            //world = new AnimalWorld(america);
            //world.RunFoodChain();

            //abfac2.Factory.VehicleFactory honda = new abfac2.Factory.HondaFactory();
            //abfac2.VehicleClient hondaClient = new abfac2.VehicleClient(honda, "Regular");
            //Console.WriteLine("******* Honda **********");
            //Console.WriteLine(hondaClient.GetBikeName());
            //Console.WriteLine(hondaClient.GetScooterName());

            //hondaClient = new abfac2.VehicleClient(honda, "Sports");
            //Console.WriteLine(hondaClient.GetBikeName());
            //Console.WriteLine(hondaClient.GetScooterName());

            //abfac2.Factory.VehicleFactory hero = new abfac2.Factory.HeroFactory();
            //abfac2.VehicleClient heroclient = new abfac2.VehicleClient(hero, "Regular");

            //Console.WriteLine("******* Hero **********");
            //Console.WriteLine(heroclient.GetBikeName());
            //Console.WriteLine(heroclient.GetScooterName());

            //heroclient = new abfac2.VehicleClient(hero, "Sports");
            //Console.WriteLine(heroclient.GetBikeName());
            //Console.WriteLine(heroclient.GetScooterName());

            #endregion Abstract Factory Pattern

            #region Facade Pattern
            //Facade
            Mortgage mortgage = new Mortgage();

            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name +" has been " + (eligible ? "Approved" : "Rejected"));
            #endregion Facade Pattern

            #region Observer Pattern
            //Create IBM stock and attach investors

            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            //Fluctuating prices will notify investors

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
            #endregion Observer Pattern

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
