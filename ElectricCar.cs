using System;
using System.Collections.Generic;
using System.Text;

namespace Gruppe14
{
    public class ElectricCar : Car, ISellable, IInsurable
    {
        // Hvor mange km bilen kan køre pr. kWh
        public double KmPerKwh { get; private set; }

        // Constructor
        public ElectricCar(string brand, string model, int year, string licensePlate,
                           double kmPerKwh)
            : base(brand, model, year, licensePlate)
        {
            KmPerKwh = kmPerKwh;
        }

        // Implementerer abstract metode fra Car
        public override void UpdateEnergyLevel(double km)
        {
            // Simpel løsning: gør ingenting endnu
        }
        public string RegistrationNumber => LicensePlate;

        public double Price => 250000 - (Odometer * 0.3);

        public string GetSalesSummary()
        {
            return $"Electric Car: {Brand} {Model} ({Year}) - {Odometer} km - Price: {Price}";
        }

        public double GetInsuranceRate()
        {
            return 0.05; // elbil billigere
        }
    }
}