using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Car__engine_and_tires
{
    public class Tire
    {
        private int year;
        private double pressure;

        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }

        public int Year 
        { 
            get => year; 
            set => year = value; 
        }

        public double Pressure 
        { 
            get => pressure; 
            set => pressure = value; 
        }

    }
}