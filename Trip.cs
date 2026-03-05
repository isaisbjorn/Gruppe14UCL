using System;
using MinBilProjekt;

namespace MinBilProjekt
{
	public class Trip // Trip Klasse
	{
		private Car _car; // Snakker med Objektet

		// Properties
		public double Distance { get; private set; }
		public DateTime TripDate { get; private set; }
		public DateTime StartTime { get; private set; }
		public DateTime EndTime { get; private set; }

		public Car Car { get { return _car; } }
		// Get > Værdien kan læses udefra
		// Private set > Vi kan KUN ændre værdien i denne klasse (Altså: Jeg sætter denne property til privat)

		// Konstruktør
		public Trip(Car car, double distance, DateTime startTime, DateTime endTime)
		{
			_car = car;
			Distance = distance;
			StartTime = startTime;
			EndTime = endTime;
			TripDate = startTime.Date;
		}

		public TimeSpan CalculateDuration() // Timespan returnerer tid
		{
			return EndTime - StartTime;
		}

		public double CalculateFuelUsed()
		{
			return Distance / _car.KmPerLiter;
		}

		public double CalculateTripPrice(double literPrice)
		{
			return CalculateFuelUsed() * literPrice;
		}

		public string GetTripDetails()
		{
			return $"Date: {TripDate:d}, Distance: {Distance} km, Duration: {CalculateDuration():hh\\:mm}, Fuel Used: {CalculateFuelUsed():F2} liters";
		}
	}
}