using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Car__engine_and_tires
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tire;

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tire)
        {
            Make = make;
            Model = model;
            Year = year;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            Engine = engine;
            Tire = tire;
        }

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

        public Engine Engine 
        { 
            get => engine; 
            set => engine = value;
        }

        public Tire[] Tire 
        { 
            get => tire; 
            set => tire = value; 
        }

        public void PrintInfo()
        {
            string tireInfo = string.Join(", ", Tire.Select(t => $"[{t.Year}, {t.Pressure}]"));

            Console.WriteLine($"Make: {Make} || Model: {Model} || Year: {Year} || Fuel Quantity: {FuelQuantity} / Fuel Consumption: {FuelConsumption} " +
                $"|| Engine: (Engine Cubics: {Engine.CubicCapacity} / Engine Horse Powers: {Engine.HorsePower}) || Tires: {tireInfo}");
        }
    }
}