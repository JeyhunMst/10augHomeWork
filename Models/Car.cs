using System;
using System.Collections.Generic;
using System.Text;

namespace _10AugHomeWork.Models
{
    class Car:Vehicle
    {
        public string Brand;
        public string Model;
        public int FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;

        public Car(int Year,string Color, string Brand,string Model,int FuelCapacity,double FuelFor1Km):base(Year,Color)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.FuelCapacity = FuelCapacity;
            this.FuelFor1Km = FuelFor1Km;
        }
        public Car(int Year, string Color, string Brand, string Model, int FuelCapacity, double FuelFor1Km, double CurrentFuel) : this(Year, Color, Brand, Model, FuelCapacity,FuelFor1Km)
        {
            this.CurrentFuel = CurrentFuel;
        }
        public void ShowInfo() 
        {
            Console.WriteLine($"Year:{Year} Color:{Color} Brand: {Brand} Model: {Model} Fuel capacity: {FuelCapacity} Fuel Cons.: {FuelFor1Km} Current fuel: {CurrentFuel}");
        }
        public double Drive(double DrivingWay) 
        {
            double PossibleWay =CurrentFuel / FuelFor1Km;
            if (PossibleWay > DrivingWay)
            {
                double UsedFuel = DrivingWay * FuelFor1Km;
                return CurrentFuel - UsedFuel;
            }
            else
            {
                return CurrentFuel;
            }

        }
        

    }
}
