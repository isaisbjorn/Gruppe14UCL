using System;
using System.Collections.Generic;
using System.Text;

namespace Gruppe14
{
    // Trip-klassen repræsenterer én køretur
    public class Trip
    {
        // gemmer hvilken bil turen er kørt i
        private Car _car;

        // hvor lang turen er (i km)
        public double Distance { get; private set; }

        // datoen turen blev kørt
        public DateTime TripDate { get; private set; }

        // start tidspunkt for turen
        public DateTime StartTime { get; private set; }

        // slut tidspunkt for turen
        public DateTime EndTime { get; private set; }

        // giver adgang til bilen
        public Car Car
        {
            get { return _car; }
        }

        // konstruktør
        public Trip(Car car, double distance, DateTime startTime, DateTime endTime)
        {
            _car = car;
            Distance = distance;
            StartTime = startTime;
            EndTime = endTime;
            TripDate = startTime.Date;
        }

        // beregner hvor lang tid turen har taget
        public TimeSpan CalculateDuration()
        {
            return EndTime - StartTime;
        }

        // beregner hvor meget brændstof der blev brugt
        public double CalculateFuelUsed()
        {
            // simpel løsning: virker kun for FuelCar
            FuelCar fuelCar = (FuelCar)_car;
            return Distance / fuelCar.KmPerLiter;
        }

        // beregner hvad turen kostede
        public double CalculateTripPrice(double literPrice)
        {
            return CalculateFuelUsed() * literPrice;
        }

        // laver en tekst med information om turen
        public string GetTripDetails()
        {
            return $"Date: {TripDate}, Distance: {Distance} km, Duration: {CalculateDuration():hh\\:mm\\:ss}";
        }
    }
}