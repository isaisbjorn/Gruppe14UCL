using System.Security.Cryptography.X509Certificates;

namespace Gruppe14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opretter to Car objekter med forskellige oplysninger
            Car myCar1 = new Car("Toyota", "Corolla", 2020, 'A', FuelType.Benzin, 22.5);
            Car myCar2 = new Car("Nissan", "Qashqai", 2017, 'M', FuelType.Diesel, 17.8);

            // Udskriver information om bilerne
            Console.WriteLine(myCar1.GetCarDetails());
            Console.WriteLine(myCar2.GetCarDetails());

            // Starter motoren på bilen
            myCar1.ToggleEngine();

            // Kører en tur på 120 km
            myCar1.Drive(120);

            // Udskriver nye oplysninger efter kørslen
            Console.WriteLine("\n Efter Kørsel:");
            Console.WriteLine(myCar1.GetCarDetails());

            // Beregner hvad turen kostede i brændstof
            double tripPrice = myCar1.CalculateTripPrice(120, 14.5);
            Console.WriteLine($"Turen kostede: {tripPrice} kr.");

            // Stopper programmet indtil brugeren trykker enter
            Console.ReadLine();


            // Opretter endnu en bil
            Car myCar3 = new Car("Toyota", "Corolla", 2020, 'A', FuelType.Benzin, 22.5);

            // Starter motoren
            myCar3.ToggleEngine();


            // Opretter en liste med ture
            List<Trip> trips = new List<Trip>
        {
            new Trip(myCar3, 50, DateTime.Now, DateTime.Now.AddHours(1)),
            new Trip(myCar3, 30, DateTime.Now, DateTime.Now.AddMinutes(30)),
            new Trip(myCar3, 100, DateTime.Now, DateTime.Now.AddHours(2))
        };

            // Gennemgår listen og sender hver tur til bilen
            foreach (var trip in trips)
            {
                myCar3.Drive(trip);
            }

            // Udskriver alle ture som bilen har kørt
            Console.WriteLine("\n Alle ture for bilen");
            foreach (var trip in myCar3.GetTrips())
            {
                Console.WriteLine(trip.GetTripDetails());
            }


            // Spørger brugeren om oplysninger om en bil
            Console.WriteLine("Hvilket bilmærke? ");
            string bilmærke = Console.ReadLine();

            Console.WriteLine("Hvilken model? ");
            string model = Console.ReadLine();

            Console.WriteLine("Hvilken brændstoftype kører bilen på? ");
            string brændstoftype = Console.ReadLine();

            Console.WriteLine("Hvor langt kører bilen per liter? ");
            double kmperl = double.Parse(Console.ReadLine());

            Console.WriteLine("Hvad er kilometerstanden på bilen? ");
            int kilometerstand = int.Parse(Console.ReadLine());

            // Udskriver de værdier brugeren har indtastet
            Console.WriteLine("Brændstoftype " + brændstoftype);
            Console.WriteLine("KM per liter " + kmperl + "Km");
            Console.WriteLine("Kilometerstand " + kilometerstand + "Km");


            // Spørger hvor langt brugeren vil køre
            Console.WriteLine("Hvor langt skal du køre? ");
            int afstand = int.Parse(Console.ReadLine());

            // Brændstofpriser
            double benzinPris = 13.49;
            double dieselPris = 12.29;

            // Beregner hvor meget brændstof turen bruger
            double benzinForbrug = afstand / kmperl;

            double fuelType = 0;
            double pris = 0;

            // IF/ELSE der afgør hvilken pris der skal bruges
            if (brændstoftype.ToLower() == "benzin")
            {
                fuelType = benzinPris;
                pris = benzinForbrug * benzinPris;

                Console.WriteLine("Din tur vil koste: {0} kr", pris);
            }
            else if (brændstoftype.ToLower() == "diesel")
            {
                fuelType = dieselPris;
                pris = benzinForbrug * dieselPris;

                Console.WriteLine(string.Format("Din tur vil koste: {0} kr", pris));
            }
            else
            {
                // Hvis brugeren skriver noget andet end benzin eller diesel
                Console.WriteLine("Ukendt brændstoftype");
                return;
            }

            Console.ReadLine();

            // Beregner ny kilometerstand efter turen
            int Nykmantal = kilometerstand + afstand;

            Console.ReadLine();

            // Udskriver en oversigt over bilens oplysninger
            Console.WriteLine("====BILENS OPLYSNINGER====");
            Console.WriteLine("Brændstoftype: " + brændstoftype);
            Console.WriteLine("Kilometer per liter: " + kmperl + "Km");
            Console.WriteLine("Oprindelig kilometerstand " + kilometerstand + "Km");
            Console.WriteLine("Ny kilometerstand " + Nykmantal + "Km");
            Console.WriteLine("Brændstofudgift " + pris + "kr");

            Console.ReadLine();


            // Laver en tabel med forskellige biler
            Console.WriteLine("Bilmærke ".PadRight(15) + "| " + " Model ".PadRight(12) + "|" + " Kilometertal ".PadLeft(14));
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Toyota ".PadRight(15) + "| " + " Corolla ".PadRight(12) + "|" + " 156.000 km ".PadLeft(14));
            Console.WriteLine("Ford ".PadRight(15) + "| " + " Fiesa ".PadRight(12) + "|" + " 112.000 km ".PadLeft(14));
            Console.WriteLine("Skoda ".PadRight(15) + "| " + " Citigo ".PadRight(12) + "|" + " 225.000 km ".PadLeft(14));
            Console.WriteLine("Tesla ".PadRight(15) + "| " + " Model Y ".PadRight(12) + "|" + " 100.000 km ".PadLeft(14));
            Console.WriteLine("Audi ".PadRight(15) + "| " + " E-Tron ".PadRight(12) + "|" + " 75.000 km ".PadLeft(14));

            // Udskriver også bilen som brugeren har indtastet
            Console.WriteLine(bilmærke.PadRight(15) + "| " + " " + model.PadRight(11) + "|" +
                kilometerstand.ToString("N0", new System.Globalization.CultureInfo("da-DK")).PadLeft(10) + " km");

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("\nTryk enter for at fortsætte");
            Console.ReadLine();


            // Laver en tabel med alle oplysninger om bilen
            Console.WriteLine("Info ".PadRight(15) + "| " + "Værdier ".PadRight(12) + "|" + "Måleenheder ".PadLeft(14));
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Bilmærke ".PadRight(15) + "| " + bilmærke.PadRight(12) + "|" + " ".PadLeft(14));
            Console.WriteLine("Model ".PadRight(15) + "| " + model.PadRight(12) + "|" + " ".PadLeft(14));
            Console.WriteLine("Kilometerstand ".PadRight(15) + "| " +
                kilometerstand.ToString("N0", new System.Globalization.CultureInfo("da-DK")).PadRight(12) + "|" + "km ".PadRight(14));

            Console.WriteLine("Brændstoftype ".PadRight(15) + "| " + brændstoftype.PadRight(12) + "|" + " ".PadLeft(14));
            Console.WriteLine("Kilometer pr/l ".PadRight(15) + "| " + kmperl.ToString().PadRight(12) + "|" + "km/l ".PadRight(14));

            Console.WriteLine("Ny km stand ".PadRight(15) + "| " +
                Nykmantal.ToString("N0", new System.Globalization.CultureInfo("da-DK")).PadRight(12) + "|" + "km ".PadRight(14));

            Console.WriteLine("Pris for turen ".PadRight(15) + "| " + pris.ToString().PadRight(12) + "|" + "kr ".PadRight(14));

            Console.WriteLine("-----------------------------------------------------");

            // Stopper programmet før det lukker
            Console.ReadLine();
        }
    }
}
