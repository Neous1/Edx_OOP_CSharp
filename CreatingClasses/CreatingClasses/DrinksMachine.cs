using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses
{
    class DrinksMachine
    {
        private string _location;
        private string _make;
        private string _model;

        public string Location
        {
            get
            {
                return _location;
            }

            set
            {
                _location = value;
            }
        }

        // The following stattements declasre plucblck mehtods 
        public void MakeCappucino()
        {
            Console.WriteLine("Cappucino is ready");
        }

        public void MakeEsspressso()
        {
            //Method logi goes here
        }
    }
}
