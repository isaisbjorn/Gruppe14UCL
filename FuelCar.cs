using System;

namespace Gruppe14
{
    // FuelCar arver fra Car og implementerer begge interfaces
    public class FuelCar : Car, ISellable, IInsurable
    {
        // Hvilken type brændstof bilen bruger
        public FuelType FuelType { get; private set; }

        // Hvor mange km bilen kører pr. liter
        public double KmPerLiter { get; private set; }

        // Constructor
        public FuelCar(string brand, string model, int year, string licensePlate,
                       FuelType fuelType, double kmPerLiter)
            : base(brand, model, year, licensePlate)
        {
            FuelType = fuelType;
            KmPerLiter = kmPerLiter;
        }

        // Implementerer abstract metode fra Car
        public override void UpdateEnergyLevel(double km)
        {
            // Simpel løsning: gør ingenting endnu
        }

        // IInsurable
        public string RegistrationNumber => LicensePlate;

        public double GetInsuranceRate()
        {
            return 0.07; // Fuel cars lidt dyrere
        }

        // ISellable
        public double Price
        {
            get
            {
                return 150000 - (Odometer * 0.4);
            }
        }

        public string GetSalesSummary()
        {
            return $"Fuel Car: {Brand} {Model} ({Year}) - {Odometer} km - Price: {Price}";
        }
    }
}