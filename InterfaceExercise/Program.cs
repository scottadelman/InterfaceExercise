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

            //Create 3 classes called Car , Truck , & SUV

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
            var car1 = new Car()
            {
                HasLeatherSeats = true,
                HasTrunk = true,
                Color = "Red",
                NumberOfWheels = 4,
                NameOfCompany = "Toyota",
                Slogan = "Lets go places!",
                HorsePower = 285
            };

            var truck1 = new Truck()
            {
                LengthOfBed = 6,
                NumberOfDoors = 4,
                Color = "Blue",
                NumberOfWheels = 4,
                NameOfCompany = "Chevy",
                Slogan = "Insert chevy slogan here",
                HorsePower = 450
            };

            var suv1 = new SUV()
            {
                HasLeatherSeats = false,
                HasTrunk = true,
                Color = "Green",
                NumberOfWheels = 4,
                NameOfCompany = "Lexus",
                Slogan = "Insert Lexus slogan here",
                HorsePower = 900000
            };


            var vehicles = new List<IVehicle>();
            vehicles.Add(car1);
            vehicles.Add(truck1);
            vehicles.Add(suv1);
            
            Console.WriteLine( $"Here's some info on the first car! \n {car1.HorsePower} horsepower, {car1.NumberOfWheels} wheels, and it's {car1.Color}");
            Console.WriteLine($"Here's some info on the second car! \n {truck1.HorsePower} horsepower, {truck1.NumberOfWheels} wheels, and it's {truck1.Color}");
            Console.WriteLine($"Here's some info on the third car! \n {suv1.HorsePower} horsepower, {suv1.NumberOfWheels} wheels, and it's {suv1.Color}");
            Console.WriteLine("\nIf you'd like more information, please contact our head of sales, Scott");
            //Creatively display and organize their values



        }
    }
}
