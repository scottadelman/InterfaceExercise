using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle , ICompany
    {
        public int LengthOfBed { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfWheels { get; set; }
        public int HorsePower { get; set; }
        public string Color { get; set; }
        public string NameOfCompany { get; set; }
        public string Slogan { get; set; }
    }
}
