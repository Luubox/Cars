﻿using System;
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
        private bool _benzin;
        private string _colour;
        private string _licensePlate;

        private Trailer _trailer;

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
        public bool Benzin
        {
            get { return _benzin; }
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

        //public Trailer Trailer
        //{
        //    get { return _trailer; }
        //    set { _trailer = value; }
        //}

        public void AttachTrailer(Trailer trailer)
        {
            _trailer = trailer;
        }

        public Car(string make, string model, int year, bool benzin, string colour, string licensePlate) : this(make,model,year)
        {
            _benzin = benzin;
            _colour = colour;
            _licensePlate = licensePlate;
        }
    
        public Car(string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year;
        }

        public double Drive()
        {
            return 1;
        }

        public void Gear()
        {
            
        }

        //Ebbe stringbuilder løsning
        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine("+-----------------------+");
        //    sb.Append("| Make: ");
        //    sb.Append("\t");
        //    sb.Append(_make);
        //    sb.Append("\t|");
        //    if (_trailer != null) sb.Append(_trailer.ToString());
        //    return sb.ToString();

        //    //string s = "+------...";
        //    //s += "| blahblah...";
        //}

        public override string ToString()
        {
            string FuelType = null;
            if (_benzin) FuelType = "Petrol";
            else FuelType = "Diesel, other brands are available..";
            //:TODO non asssigned boolean fix

            return "+-------------------------------------------------------------------+\n" +
                   $"| Make:\t\t{Make,-52}|\n" +
                   $"| Model:\t{Model,-52}|\n" +
                   $"| Year:\t\t{Year,-52}|\n" +
                   $"| Colour:\t{Colour,-52}|\n" +
                   $"| Fuel:\t\t{FuelType,-52}|\n" +
                   $"| Reg:\t\t{LicensePlate,-52}|\n" +
                   "+-------------------------------------------------------------------+";
        }
    }
}
