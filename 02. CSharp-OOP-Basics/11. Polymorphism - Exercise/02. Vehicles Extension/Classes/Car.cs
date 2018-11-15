﻿
namespace Polymorphism.Classes
{
    public class Car : Vehicle
    {
        private const double airConditionConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity,fuelConsumption, tankCapacity)
        {
            FuelConsumption += airConditionConsumption;
        }

    }
}