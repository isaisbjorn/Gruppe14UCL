using System;
using System.Collections.Generic;
using System.Text;

namespace Gruppe14
{
    public abstract class Car
    {
        // Grundlæggende bilinfo
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public string LicensePlate { get; private set; }

        // Kilometerstand kan ændres i subklasser
        public double Odometer { get; protected set; }

        // Motorstatus
        public bool IsEngineOn { get; private set; }

        // Liste over ture
        private List<Trip> _trips = new List<Trip>();

        // Constructor
        public Car(string brand, string model, int year, string licensePlate)
        {
            Brand = brand;
            Model = model;
            Year = year;
            LicensePlate = licensePlate;
        }

        // Abstrakt metode → skal implementeres i subklasser
        public abstract void UpdateEnergyLevel(double km);

        // Simpel metode til at tænde/slukke motor
        public void ToggleEngine()
        {
            IsEngineOn = !IsEngineOn;
        }

        // Kør en tur
        public void Drive(Trip trip)
        {
            if (IsEngineOn)
            {
                Odometer += trip.Distance;
                UpdateEnergyLevel(trip.Distance);
                _trips.Add(trip);
            }
            else
            {
                Console.WriteLine("Fejl: Motoren er ikke tændt.");
            }
        }

        // Hent alle ture
        public List<Trip> GetTrips()
        {
            return _trips;
        }

        // Hent ture på en bestemt dato
        public List<Trip> GetTripsByDate(DateTime date)
        {
            List<Trip> result = new List<Trip>();

            foreach (Trip trip in _trips)
                if (trip.TripDate.Date == date.Date)
                    result.Add(trip);

            return result;
        }

        // Info om bilen
        public string GetCarDetails()
        {
            return $"{Brand} {Model} ({Year}) - {LicensePlate} - KM: {Odometer}";
        }
    }
}