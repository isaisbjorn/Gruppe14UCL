using System;

namespace Gruppe14
{
    // House kan både sælges og forsikres
    public class House : ISellable, IInsurable
    {
        // Adresse på huset
        public string Address { get; }

        // Opførelsesår
        public int YearBuilt { get; }

        // Salgspris
        public double Price { get; }

        // Matrikelnummer (bruges som registreringsnummer)
        public string RegistrationNumber { get; }

        // Constructor
        public House(string address, int yearBuilt, double price, string cadastralNumber)
        {
            Address = address;
            YearBuilt = yearBuilt;
            Price = price;
            RegistrationNumber = cadastralNumber;
        }

        // Tekst til salg
        public string GetSalesSummary()
        {
            return $"{Address}, opført {YearBuilt}, pris: {Price:N0} kr";
        }

        // Forsikringssats (ældre huse dyrere)
        public double GetInsuranceRate()
        {
            return YearBuilt < 1980 ? 1.8 : 1.2;
        }
    }
}