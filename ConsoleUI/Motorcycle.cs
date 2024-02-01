using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool IsCrusier { get; set; }
        public bool HasSideCar {  get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Driving a motorcycle");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("MOTORCYCLE VIRTUAL");
        }

    }
}
/* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle***********DONE
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */