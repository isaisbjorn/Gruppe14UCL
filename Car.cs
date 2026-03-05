using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Gruppe14
{
    public class Car
    {
        // Attributter (private variabler der gemmer data om bilen)
        private string brand;
        private string model;
        private int year;
        private char gear;
        private double odometer;
        private bool isEngineOn;
        private double kmPerLiter;

        // Liste der gemmer alle ture bilen har kørt
        private List<Trip> _trips = new List<Trip>();


        // Konstruktør
        // Bruges når man opretter en ny bil
        public Car(string brand, string model, int year, char gear, FuelType fuelType, double kmPerLiter)
        {
            // Gemmer værdierne i klassens variabler
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.gear = gear;

            FuelType = fuelType;
            this.kmPerLiter = kmPerLiter;

            // Startværdier når bilen oprettes
            this.odometer = 0;
            this.isEngineOn = false;
        }


        // Properties
        // Giver adgang til værdierne uden at andre klasser kan ændre dem direkte
        public string Brand => brand;
        public string Model => model;
        public int Year => year;

        // Gear kan både læses og ændres
        public char Gear
        {
            get { return gear; }
            set { gear = value; }
        }

        // Odometer viser hvor langt bilen har kørt
        public double Odometer => odometer;

        // Hvor langt bilen kører per liter
        public double KmPerLiter => kmPerLiter;

        // Viser om motoren er tændt
        public bool IsEngineOn => isEngineOn;

        // Enum der viser hvilken brændstoftype bilen bruger
        public FuelType FuelType { get; private set; }


        // Returnerer listen med alle ture
        public List<Trip> GetTrips()
        {
            return _trips;
        }


        // Metode der tænder eller slukker motoren
        public void ToggleEngine()
        {
            // Skifter værdien fra true til false eller omvendt
            isEngineOn = !isEngineOn;
        }


        // Metode til at køre bilen en distance
        public void Drive(double distance)
        {
            // Bilen kan kun køre hvis motoren er tændt og distancen er positiv
            if (isEngineOn && distance > 0)
            {
                // Lægger distance til kilometerstanden
                odometer += distance;
            }
        }


        // Beregner hvad en tur koster i brændstof
        public double CalculateTripPrice(double distance, double literPrice)
        {
            // Hvis værdierne er ugyldige returneres 0
            if (distance <= 0 || literPrice <= 0)
                return 0;

            // Beregner hvor meget brændstof der bruges
            double fueldUsed = distance / kmPerLiter;

            // Returnerer prisen for turen
            return fueldUsed * literPrice;
        }


        // Returnerer en tekst med oplysninger om bilen
        public string GetCarDetails()
        {
            return $"{brand} {model} ({year}) - {FuelType} - {odometer} km - Motor: {(isEngineOn ? "Tændt" : "Slukket")}";
        }


        // Metode der tilføjer en tur til bilen
        public void Drive(Trip newTrip)
        {
            // Tjekker at turen tilhører denne bil
            if (newTrip.Car == this)
            {
                // Opdaterer kilometerstanden
                odometer += newTrip.Distance;

                // Gemmer turen i listen
                _trips.Add(newTrip);
            }
            else
            {
                // Hvis turen ikke tilhører bilen vises en fejl
                Console.WriteLine("Fejl: Denne tur tilhører ikke denne bil.");
            }
        }
    }
}

