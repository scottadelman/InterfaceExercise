using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public bool HasTrunk { get; set; }
        public bool HasLeatherSeats { get; set; }
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }
        public int HorsePower { get; set; }
        public string NameOfCompany { get; set; }
        public string Slogan { get; set; }
    }
}
