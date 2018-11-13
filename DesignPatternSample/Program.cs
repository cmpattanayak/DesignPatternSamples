using DesignPatternSample.AbstractFactory;
using DesignPatternSample.Adapter;
using DesignPatternSample.Builder;
using DesignPatternSample.Facade;
using DesignPatternSample.Factory;
using DesignPatternSample.Observer;
using DesignPatternSample.Strategy;
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
            //Mortgage mortgage = new Mortgage();

            //Customer customer = new Customer("Ann McKinsey");
            //bool eligible = mortgage.IsEligible(customer, 125000);

            //Console.WriteLine("\n" + customer.Name +" has been " + (eligible ? "Approved" : "Rejected"));
            #endregion Facade Pattern

            #region Observer Pattern
            ////Create IBM stock and attach investors

            //IBM ibm = new IBM("IBM", 120.00);
            //ibm.Attach(new Investor("Sorros"));
            //ibm.Attach(new Investor("Berkshire"));

            ////Fluctuating prices will notify investors

            //ibm.Price = 120.10;
            //ibm.Price = 121.00;
            //ibm.Price = 120.50;
            //ibm.Price = 120.75;
            #endregion Observer Pattern

            #region Unit-of-Work
            //UnitOfWork.Customer customerobj = new UnitOfWork.Customer();// record 1 Customer
            //customerobj.Id = 1000;
            //customerobj.CustomerName = "shiv";

            //Supplier SupplierObj = new Supplier(); // Record 2 Supplier
            //Supplierobj.Id = 2000;
            //Supplierobj.SupplierName = "xxxx";

            //UnitOfWork.Client<UnitOfWork.Customer> client = new UnitOfWork.Client<UnitOfWork.Customer>();
            //client.Add(customerobj); // record 1 added to inmemory
            //client.Add(cupplierobj); // record 1 added to inmemory
            //client.Committ(); // The full inmemory collection is sent for final committ 
            #endregion Unit-of-Work

            #region Adapter Pattern
            //ITarget Itarget = new EmployeeAdapter();
            //ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
            //client.ShowEmployeeList();
            #endregion Adapter Pattern

            #region Builder pattern
            //var vehicleCreator = new VehicleCreator(new HeroBuilder());
            //vehicleCreator.CreateVehicle();
            //var vehicle = vehicleCreator.GetVehicle();
            //vehicle.ShowInfo();

            //Console.WriteLine("---------------------------------------------");

            //vehicleCreator = new VehicleCreator(new HondaBuilder());
            //vehicleCreator.CreateVehicle();
            //vehicle = vehicleCreator.GetVehicle();
            //vehicle.ShowInfo();
            #endregion Builder Pattern

            #region Strategy Pattern
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
            #endregion Strategy Pattern

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
