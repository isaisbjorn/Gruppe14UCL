using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Gruppe14
{
    // Trip-klassen repræsenterer én køretur
    public class Trip
    {
        // gemmer hvilken bil turen er kørt i
        // jeg bruger den senere til at finde bilens KmPerLiter
        private Car _car;

        // hvor langt turen er kørt (i km)
        public double Distance { get; private set; }

        // datoen turen blev kørt
        public DateTime TripDate { get; private set; }

        // start tidspunkt for turen
        public DateTime StartTime { get; private set; }

        // slut tidspunkt for turen
        public DateTime EndTime { get; private set; }

        // giver adgang til bilen, men man kan ikke ændre den udefra
        public Car Car
        {
            get { return _car; }
        }

        // konstruktør - bruges når man opretter en ny tur
        public Trip(Car car, double distance, DateTime startTime, DateTime endTime)
        {
            // gemmer bilen i variablen
            _car = car;

            // gemmer hvor langt turen er
            Distance = distance;

            // gemmer start og slut tidspunkt
            StartTime = startTime;
            EndTime = endTime;

            // tager datoen fra startTime
            TripDate = startTime.Date;
        }

        // beregner hvor lang tid turen har taget
        public TimeSpan CalculateDuration()
        {
            // trækker start tidspunkt fra slut tidspunkt
            return EndTime - StartTime;
        }

        // beregner hvor meget brændstof der blev brugt
        public double CalculateFuelUsed()
        {
            // distance delt med bilens km pr liter
            return Distance / _car.KmPerLiter;
        }

        // beregner hvad turen kostede i brændstof
        public double CalculateTripPrice(double literPrice)
        {
            // bruger metoden ovenfor og ganger med literprisen
            return CalculateFuelUsed() * literPrice;
        }

        // laver en tekst med information om turen
        // kan bruges til at printe i konsollen
        public string GetTripDetails()
        {
            return $"Date: {TripDate:dd/mm/yyyy}, Distance: {Distance} km, Duration: {CalculateDuration()}";
        }
    }
}

