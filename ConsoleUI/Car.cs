using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle                                            //in order for non abstract to inherit from the base(Vehicle) class you must implement the abstract class. Right click and show potential fixes.
    {
        public bool NiceRims { get; set; }

        public override void DriveAbstract()                                //When you implement method the Abstract(Vehicle) Class. This is the base implementation. Pulling from base class. 
        {
            Console.WriteLine("0 to 60 in 2 seconds");
        }
    }
}
