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
