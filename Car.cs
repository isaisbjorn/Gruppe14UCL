using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Gruppe14
{
    
        public class Car
        {
            // Attributter og indkapsling
            private string brand;
            private string model;
            private int year;
            private char gear;
            private double odometer;
            private bool isEngineOn;
            private double kmPerLiter;
            //Liste der gemmer alle ture bilen har kørt
            private List<Trip> _trips = new List<Trip>();

            // Konstruktør
            public Car(string brand, string model, int year, char gear, FuelType fuelType, double kmPerLiter)

            {
                this.brand = brand;
                this.model = model;
                this.year = year;
                this.gear = gear;
                this.kmPerLiter = kmPerLiter;
                FuelType = fuelType;
                this.kmPerLiter = kmPerLiter;
                // Startværdier
                this.odometer = 0;
                this.isEngineOn = false;
            }

            // Properties (get / set)
            public string Brand => brand;
            public string Model => model;
            public int Year => year;

            public char Gear
            {
                get { return gear; }
                set { gear = value; }
            }

            public double Odometer => odometer;
            public double KmPerLiter => kmPerLiter;
            public bool IsEngineOn => isEngineOn;

            public FuelType FuelType { get; private set; }
            public List<Trip> GetTrips()
            {
                return _trips;
            }

            //Metode: Tænd/sluk motor
            public void ToggleEngine()
            {
                isEngineOn = !isEngineOn;
            }

            // Kør bilen
            public void Drive(double distance)
            {
                 if (isEngineOn && distance > 0)
                    {
                        odometer += (int)distance;
                    }
            }
            
            // Beregn turprisen
            public double CalculateTripPrice(double distance, double literPrice) 
            {
                if (distance <= 0 || literPrice <= 0)
                    return 0;

                double fueldUsed = distance / kmPerLiter;
                return fueldUsed * literPrice; 

            }
            
            public string GetCarDetails()
            {
                return $"{brand} {model} ({year}) - {FuelType} - {odometer} km - Motor: {(isEngineOn ? "Tændt" : "Slukket")}";
            }
            
            public void Drive(Trip newTrip)
            {
                if (newTrip.Car == this)
                {
                odometer += newTrip.Distance;

                _trips.Add(newTrip);
                }
                else
                {
                Console.WriteLine("Fejl: Denne tur tilhører ikke denne bil.");
                }
            }
        }
    }


