using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Trailer
    {
        private string _load;
        private int _counter = 0;

        //this method takes the original newLoad, adds a comma followed by the newLoad parameter
        public void FillTrailer(string newLoad)
        {
            if (_counter != 3)
            {
                _load += newLoad + ", ";
                _counter++;
                GetContents();
            }
            else
            {
                Console.WriteLine($"Trailer is full, cannot add {newLoad}!");
            }
        }

        public void GetContents()
        {
            Console.WriteLine($"Trailer is filled with: {_load}");
        }
    }
}
