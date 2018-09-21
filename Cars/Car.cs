using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Car
    {
        private string _make;
        private string _model;
        private int _year;
        private bool _fuelType;
        private string _colour;
        private string _licensePlate;

        public string Make
        {
            get { return _make; } //behøver ikke set, skal ikke kunne ændres efterfølgende
        }
        public string Model
        {
            get { return _model; }
        }
        public int Year
        {
            get { return _year; }
        }
        public bool FuelType
        {
            get { return _fuelType; }
        }
        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }
        public string LicensePlate
        {
            get { return _licensePlate; }
            set { _licensePlate = value; }
        }

        public double Drive()
        {
            return 0.0;
        }

        public void Gear()
        {
            
        }
    }
}
