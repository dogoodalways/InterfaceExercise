using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany
            Car myfirstCar = new Car { HasTrunk= true, Make = "Toyota", Model = "Camry", Year = "1985" };
            Truck myfirstTruck = new Truck { HasFlatBed = false, Make = "Volvo", Model = "Big", Year = "1987" };
            SUV myfirstSUV = new SUV { HasFourWheelDrive = true, Make = "Honda", Model = "Pilot", Year = "2020" };

            List<IVehicle> vehicles = new List<IVehicle>(); 
            vehicles.Add(myfirstTruck);
            vehicles.Add(myfirstSUV);
            vehicles.Add(myfirstCar);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year} Make: {vehicle.Make} Model: {vehicle.Year}");
                Console.WriteLine();
                vehicle.Drive();
            }


            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
