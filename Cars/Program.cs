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
            Console.WriteLine(myCar);
            //Trailer trailer = new Trailer();
            //myCar.AttachTrailer(trailer);
            //Console.WriteLine(myCar);
            //trailer.FillTrailer("Rubbish");
            //trailer.GetContents();
            //trailer.FillTrailer("Dustbin lids");
            //trailer.GetContents();
            //trailer.FillTrailer("Leaves");
            //trailer.GetContents();
            //Console.WriteLine(myCar);

            Car mySecondCar = new Car("Audi", "R8 V10 Plus Audi Sport Performance Parts R8 Edition", 2018, true, "Nardo Grey", "BV35414");
            Console.WriteLine(mySecondCar);

            Trailer myTrailer = new Trailer();
            myTrailer.FillTrailer("Rubbish");
            myTrailer.FillTrailer("Dustbin lids");
            myTrailer.FillTrailer("Leaves");
            myTrailer.FillTrailer("Dead bodies");

        }
    }
}
