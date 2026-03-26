using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace Gruppe14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opretter en benzinbil
            Car car = new FuelCar("Toyota", "Corolla", 2020, "AB12345", FuelType.Benzin, 18);

            // Tænder motoren
            car.ToggleEngine();

            // Opretter nogle ture
            Trip trip1 = new Trip(car, 50, DateTime.Now, DateTime.Now.AddHours(1));
            Trip trip2 = new Trip(car, 30, DateTime.Now, DateTime.Now.AddMinutes(40));

            // Kører turene
            car.Drive(trip1);
            car.Drive(trip2);

            // Udskriver info om bilen
            Console.WriteLine(car.GetCarDetails());

            // Udskriver alle ture
            Console.WriteLine("\nAlle ture:");
            foreach (var trip in car.GetTrips())
            {
                Console.WriteLine(trip.GetTripDetails());
            }

            Console.ReadLine();

            // Opretter et hus
            House h = new House("Strandvejen 42, 2900 Hellerup", 1965, 4200000, "1234-AB");

            // Opretter biler
            FuelCar fc = new FuelCar("Toyota", "Corolla", 2022, "AB12345", FuelType.Benzin, 18);
            ElectricCar ec = new ElectricCar("Tesla", "Model 3", 2023, "CD67890", 6.5);

            // Samler dem i en liste af ISellable (polymorfi)
            List<ISellable> forSale = new List<ISellable> { fc, ec };
            // Samler biler i en liste af IInsureable
            List<IInsurable> insured = new List<IInsurable> { fc, ec };
            // Tilføjer huse
            forSale.Add(h);
            insured.Add(h);


            // Udskriver salgsinformation for hver bil
            foreach (ISellable s in forSale)
            {
                Console.WriteLine(s.GetSalesSummary());
            }

            // Beregner samlet salgspris
            double total = 0;

            foreach (ISellable s in forSale)
            {
                total += s.Price;
            }

            Console.WriteLine($"Samlet beholdningsværdi: {total:N0} kr");

            // Udskriv forsikringsinfo
            foreach (IInsurable i in insured)
            {
                Console.WriteLine($"Reg.nr: {i.RegistrationNumber} - Forsikringssats: {i.GetInsuranceRate():P}");
            }
            // Beregner gennemsnitlig forsikringssats
            double sum = 0;
            
            foreach (IInsurable i in insured)
            {
                sum += i.GetInsuranceRate();
            }

            double average = sum / insured.Count;

            Console.WriteLine($"Gennemsnitlig forsikringssats: {average:P}");
        }
        
    }
}