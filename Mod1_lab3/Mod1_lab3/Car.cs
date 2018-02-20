using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_lab3
{
    class Car
    {// Defining properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        //Adding a Constructor
        //This constructor instantiates a car() iobject while only having the car's color and year information available

        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            //Everytime the constructor runs, increment "instances"
            instances++;
        }

        //Adding another Constructor
        //This construtor instantiate a Car() object while only having 
        //the car's year and mileage information available
        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            //Everytime the constructor runs, increment "instances"
            instances++;
        }

        //Create integer variable called "instances" and assigns value to 0

        private static int instances = 0;

        public Car()
        {
            //Everytime the constructor runs, increment "instances"
            instances++;
        }

        //Declare static member
        public static int CountCars()
        {
            return instances;
        }
    }
}
    