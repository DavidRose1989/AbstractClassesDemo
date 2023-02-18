using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * done Create an abstract class called Vehicle
             * done The vehicle class shall have three string properties Year, Make, and Model
             * done Set the defaults to something generic in the Vehicle class
             * done Vehicle shall have an abstract method called DriveAbstract with no implementation
             * done Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * done Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * done Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * done Provide the implementations for the abstract methods
             * done Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            var whip = new List<Vehicle>();  // This is how you create a list

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            Car vehicle = new Car();                    //instantiating vehicle. 
            vehicle.Year = "1989";                      //dot notation
            vehicle.Make = "Chevy";
            vehicle.Model = "Corvette";
            vehicle.NiceRims = true;

            Motorcycle bike = new Motorcycle()          //object initializer syntax
            { Make = "Ninja", LedHeadlights = true, Year = "2022", Model = "Yamaha"};

            Vehicle vehicle1= new Car();                //You cannot create an instants from an abstract class. cannot use new Vehicle because it is an abstract class. You must use one of the derived classes since they're not abstract. 
            vehicle1.Year = "2021";
            vehicle1.Make = "Tesla";
            vehicle1.Model = "Model X";


            Vehicle vehicle2= new Motorcycle()
            {Make = "Ford", Model = "F150", Year = "2009"};

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            whip.Add(vehicle);
            whip.Add(vehicle2);
            whip.Add(vehicle1);
            whip.Add(bike);

            foreach (var automobile in whip)                    //This for loop will allow each vehicle in the list to be displayed to the console. 
            {
                Console.WriteLine($"{automobile.Year}");
                Console.WriteLine($"{automobile.Model}");
                Console.WriteLine($"{automobile.Make}");
                Console.WriteLine();

            }




            // Call each of the drive methods for one car and one motorcycle

            vehicle.DriveAbstract();                                    //This method was called through the variable vehicle because I instantiated the class that it was in. 
                                                                        //If I don't instantiate then I can't call the method unless it's static.
            bike.DriveVirtual();

            
            #endregion            
            Console.ReadLine();
        }
    }
}
