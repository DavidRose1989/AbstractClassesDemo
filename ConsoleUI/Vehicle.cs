using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle                                    //An abstract class is like an incomplete base. Derived classes will define it's own way to complete the incomplete base. Example. Vehicle is to ferarri to what Vehicle is to Tesla. 
    {
        public string Year { get; set; } = "Main Year";               //Use Prop tab tab to get property. 
        public string Make { get; set; } = "Main Make";
        public string Model { get; set; } = "Main Model";


        public abstract void DriveAbstract();                       //DriveAbstract is a stubbed out method because it has no scope or body. Also has no logic. (((((What does an abstract method do?))))))))
                                                                    //If abstract the implentation of method will be in the derived classes. 
        public virtual void DriveVirtual()                          //Virtual methods have to have a scope or body.  (((((What does a virtual Method do?)))))
        {                                                           //Allows the Derived class to choose if they want to use the default method or override it and use their own. 
            Console.WriteLine("The Virtual Drive Method");
        }

    }
}
