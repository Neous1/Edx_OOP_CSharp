using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinksMachine myMachine = new DrinksMachine();
            myMachine.Location = "Kitchen";
            myMachine.Model = "DM1000";

            Console.WriteLine(myMachine.Location);
            myMachine.MakeCappucino();
        }
    }
}
