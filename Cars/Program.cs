using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Citroën", "C4 Cactus", 2014);
            Car mySecondCar = new Car("Audi", "R8 V10 Plus Audi Sport Performance Parts R8 Edition", 2018, true, "Nardo Grey", "BV35414");
            //Console.WriteLine(mySecondCar.Colour);
            //Console.WriteLine(mySecondCar.Make);
            Console.WriteLine(mySecondCar);
            Console.WriteLine(myCar);
        }
    }
}
