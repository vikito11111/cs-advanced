using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Car_Extension
{
    internal class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make 
        { 
            get => make; 
            set => make = value; 
        }

        public string Model 
        { 
            get => model; 
            set => model = value;
        }

        public int Year 
        { 
            get => year; 
            set => year = value; 
        }

        public double FuelQuantity 
        { 
            get => fuelQuantity; 
            set => fuelQuantity = value; 
        }

        public double FuelConsumption 
        { 
            get => fuelConsumption; 
            set => fuelConsumption = value;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
        {
            Make = make;
            Model = model;
            Year = year;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public void Drive(double distance)
        {
            var consumption = distance * this.FuelConsumption / 100.0;

            if (this.FuelQuantity > consumption)
            {
                this.FuelQuantity -= consumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return ($"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L");
        }
    }
}