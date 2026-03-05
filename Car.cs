using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MinBilProjekt
{
	public class Car
	{
		// Min kodes felter(fields) - Også kladet for intern lagring af gemte data i objektet (I think?)
		private string brand;
		private string model;
		private string year;
		private double kmPerLiter;
		private int odometer;
		private bool isEngineOn;
		private List<Trip> _trips = new List<Trip>();


		// Properties - Når vi benytter Encapsulation, så gemmer vi data som Private (offentlig adgang, til private felter)
		// Vi sikrer sikker og kontrolleret adgang til felter
		// Beskytter objektets tilstand, altså at det ikke er let at ændre (positivt)
		public string Brand { get => brand; set => brand = value; }
		public string Model { get => model; set => model = value; }
		public string Year { get => year; set => year = value; }
		public FuelType FuelType { get; private set; } // Vi gemmer brændstoftypen som en Enum-Værdi i stedet for tekst (henfør Fueltype.CS)
		public double KmPerLiter { get => kmPerLiter; set => kmPerLiter = value; }
		public int Odometer { get => odometer; set => odometer = value; }
		public bool IsEngineOn { get => isEngineOn; }
		// get > læs data
		// set > ændr data
		// private set > kun klassen selv må ændre data


		public Car(string brand, string model, string year, FuelType fuelType, double kmPerLiter) // Konstruktør
		{

			this.brand = brand;
			this.model = model;
			this.year = year;
			FuelType = fuelType; // Enum værdien
			this.kmPerLiter = kmPerLiter;

			odometer = 0;
			isEngineOn = false;
		}

		public void Drive(Trip newTrip)
		{
			if (newTrip.Car == this)
			{
				Odometer += (int)newTrip.Distance;
				_trips.Add(newTrip);
			}
			else
			{
				Console.WriteLine("Fejl: Denne tur tilhører ikke denne bil.");
			}
		}

		public List<Trip> GetTrips()
		{
			return _trips;
		}

		public void StartEngine()
		{
			if (!isEngineOn)
			{
				isEngineOn = true;
				Console.WriteLine("Engine started.");
			}
			else
				Console.WriteLine("Engine already on.");
		}

		public void StopEngine()
		{
			if (isEngineOn)
			{
				isEngineOn = false;
				Console.WriteLine("Engine stopped.");
			}
			else
				Console.WriteLine("Engine already off.");
		}

		public void Drive(double distance)
		{
			if (!isEngineOn)
			{
				Console.WriteLine("Start engine first.");
				return;
			}

			odometer += (int)distance;

			Console.WriteLine($"You drove {distance} km.");
			Console.WriteLine($"New odometer reading: {odometer} km.");
		}

		public double CalculateTripPrice(double distance, double literPrice)
		{
			if (kmPerLiter == 0)
				return 0;

			double literUsed = distance / kmPerLiter;
			return literUsed * literPrice;
		}

		public double GetTotalDistance()
		{
			double total = 0;

			foreach (Trip trip in _trips)
			{
				total += trip.Distance;
			}

			return total;
		}

		public double GetTotalFuelUsed()
		{
			double total = 0;

			foreach (Trip trip in _trips)
			{
				total += trip.CalculateFuelUsed();
			}

			return total;
		}

	}
}