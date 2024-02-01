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
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle *********Done
             * The vehicle class shall have three string properties: Year, Make, and Model *******DONE
             * Set the defaults of the properties to something generic in the Vehicle class ********* DONE
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.*******DONE
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle***********DONE
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle ****DONE
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles*********DONE
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */
            Car car1 = new Car() { HasTrunk = true, IsConvertible = false, Year = 2002, Make = "Toyota", Model = "Camry"};
            Motorcycle motorcycle1 = new Motorcycle() { IsCrusier = false, HasSideCar = false, Year = 1977, Make = "BMW", Model = "RS100"};
            Vehicle vehicle1 = new Car() { HasTrunk = false, IsConvertible = true, Year = 1900, Make = "Ford", Model = "T"};
            Vehicle vehicle2 = new Motorcycle() { HasSideCar = false, IsCrusier = true, Year = 1984, Make = "Honda", Model = "Goldwing"};

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            vehicles.Add(car1);
            vehicles.Add(motorcycle1);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Year}, {vehicle.Make}, {vehicle.Model}");
            }

            // Call each of the drive methods for one car and one motorcycle
            car1.DriveVirtual();
            car1.DriveAbstract();

            motorcycle1.DriveVirtual();
            motorcycle1.DriveAbstract();
            #endregion            
          
        }
    }
}
