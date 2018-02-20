using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab2
{
    // Declaring the Car() Class
    // This class has 3 properties: Color, Year, and Mileage
    public class Car
    {
        // Defining properties
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
    class Program
    {
        static void Main(string[] args)
        {

            Car Car1 = new Car();

            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            //instantiate Car2
            Car Car2 = new Car("Red", 2008);

            //Access static members
            int carCount = Car.CountCars();

            //Output to the console window
            Console.WriteLine($"There are {carCount} cars on inventory right now.");
        }
    }
}
