using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle         //in order for non abstract class to inherit from the base(Vehicle) class you must implement the abstract class. Right click and show potential fixes.
    {                                           //In a non abstract class is used basically to complete an abstract base class in it's own way. Basically what an Farri is to vehicle versus Tesla to Vehichle.

        public bool LedHeadlights { get; set; }
        public override void DriveAbstract()                    //This method is the base implementation. Pulling from base class. 
        {                                                       //The differences in the vehicles will be executed in the derived class. 
            Console.WriteLine("Doing wheelies");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motocycle does not stop behind traffic");
        }
    }

}