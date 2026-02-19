using System.Runtime.InteropServices;

namespace MinBilProjekt
{
	internal class Program
	{
		static string carType;
		static string carModel;
		static string carYear;
		static string fuelType;
		static double kmPerLiter;
		static int carDistance;

		static bool carCreated = false;
		static bool isEngineOn = false;

		static void Main(string[] args)
		{
			bool isRunning = true;

			while (isRunning)
			{
				Console.Clear();
				showMenu();
				string input = Console.ReadKey(true).KeyChar.ToString();

				switch (input)
				{
					case "1":
						carDetails();
						break;
					case "2":
						calculateFuelPricing();
						break;
					case "3":
						updateDistance();
						break;
					case "4":
						carInformation();
						break;
					case "5":
						exitProgram();
						break;
					case "6":
						Drive(10);
						break;
					case "7":
						StartEngine();
						break;
					case "8":
						StopEngine();
						break;
					case "9":
						Console.Write("Enter a km value to test: ");
						int testKm = int.Parse(Console.ReadLine());
						bool result = IsPalindrome(testKm);
						if (result)
							Console.WriteLine($"{testKm} is a palindrome!");
						else
							Console.WriteLine($"{testKm} is NOT a palindrome!");

						Console.WriteLine("\nPress any key to return...");
						Console.ReadKey(true);
						break;
					default:
						Console.WriteLine("Please type a valid option 1-8");
						break;
				}
			}
		}

		static void showMenu()
		{
			Console.WriteLine("CarApp Menu");
			Console.WriteLine("1) Enter your car's details");
			Console.WriteLine("2) Calculate fuel pricing");
			Console.WriteLine("3) Update your distance");
			Console.WriteLine("4) Your cars information");
			Console.WriteLine("5) Exit");
			Console.WriteLine("6) Go for a Drive");
			Console.WriteLine("7) Start Engine");
			Console.WriteLine("8) Stop Engine");
            Console.WriteLine("9) Check if Odometer is Palindrom");
		}

		static void carDetails()
		{
			Console.WriteLine("=== Enter Car Details ===\n");

			Console.Write("Car Type: ");
			carType = Console.ReadLine();

			Console.Write("Car Model: ");
			carModel = Console.ReadLine();

			Console.Write("Car Year: ");
			carYear = Console.ReadLine();

			Console.Write("Fuel Type: ");
			fuelType = Console.ReadLine();

			Console.Write("KM per Liter: ");
			kmPerLiter = double.Parse(Console.ReadLine());

			Console.Write("Car Distance: ");
			carDistance = int.Parse(Console.ReadLine());

			carCreated = true;

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\n=== Car Details Saved ===");
			Console.ResetColor();

			Console.WriteLine("\nPress any key to return to menu...");
			Console.ReadKey(true);
		}

		static void calculateFuelPricing()
		{
			if (!carCreated)
			{
				Console.WriteLine("You must create a car first.");
				Console.WriteLine("\nPress any key to return to menu...");
				Console.ReadKey(true);
				return;
			}

			Console.Write("Enter distance for the trip: ");
			double distance = double.Parse(Console.ReadLine());

			double literPrice;

			if (fuelType.ToLower() == "benzin")
				literPrice = 13.49;
			else if (fuelType.ToLower() == "diesel")
				literPrice = 12.29;
			else
			{
				Console.WriteLine("Invalid fuel type.");
				Console.WriteLine("\nPress any key to return to menu...");
				Console.ReadKey(true);
				return;
			}

			double price = CalculateTripPrice(distance, literPrice, fuelType);

			Console.WriteLine($"\nTrip price: {price:F2} kr");
			Console.WriteLine("\nPress any key to return to menu...");
			Console.ReadKey(true);
		}

		static double CalculateTripPrice(double distance, double literPrice, string fuelType)
		{
			if (kmPerLiter == 0)
			{
				Console.WriteLine("KM per liter cannot be 0.");
				return 0;
			}

			if (fuelType.ToLower() != "benzin" && fuelType.ToLower() != "diesel")
			{
				Console.WriteLine("Invalid fuel type.");
				return 0;
			}

			double literUsed = distance / kmPerLiter;
			double totalPrice = literUsed * literPrice;

			return totalPrice;
		}

		static void updateDistance()
		{

		}

		static void carInformation()
		{
			if (!carCreated)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Fill in info before you can see your details");
				Console.ResetColor();
				Console.WriteLine("\nPress any key to return to menu...");
				Console.ReadKey(true);
				return;
			}

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Your car's information:\n");
			Console.ResetColor();

			Console.WriteLine($"CarType: {carType}");
			Console.WriteLine($"Car Model: {carModel}");
			Console.WriteLine($"Car Year: {carYear}");
			Console.WriteLine($"Fuel Type: {fuelType}");
			Console.WriteLine($"KM per Liter: {kmPerLiter}");
			Console.WriteLine($"Car Distance: {carDistance}");

			Console.WriteLine("\nPress any key to return to menu...");
			Console.ReadKey(true);
		}

		static void exitProgram()
		{
			Environment.Exit(0);
		}

		static void Drive(double distance)
		{
			if (!isEngineOn)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("TURN ON THE FUCKING CAR.");
				Console.ResetColor();
				Console.WriteLine("\nPress any key to return to menu...");
				Console.ReadKey(true);
				return;
			}

			carDistance += (int)distance;

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"You drove {distance} km.");
			Console.WriteLine($"New odometer reading: {carDistance} km.");
			Console.ResetColor();

			Console.WriteLine("\nPress any key to return to menu...");
			Console.ReadKey(true);
		}

		static void StartEngine()
		{
			if (isEngineOn)
				Console.WriteLine("Engine is already on.");
			else
			{
				isEngineOn = true;
				Console.WriteLine("Engine started.");
			}

			Console.WriteLine("\nPress any key to return to menu...");
			Console.ReadKey(true);
		}

		static void StopEngine()
		{
			if (!isEngineOn)
				Console.WriteLine("Engine is already off.");
			else
			{
				isEngineOn = false;
				Console.WriteLine("Engine stopped.");
			}

			Console.WriteLine("\nPress any key to return to menu...");
			Console.ReadKey(true);
		}

		static bool IsPalindrome(int km)
		{
			string text = km.ToString();

			for (int i = 0; i < text.Length / 2; i++)
			{
				if (text[i] != text[text.Length - 1 - i])
				{
					return false;
				}
			}

			return true;
		}


		/* === GAMMEL KODE TIL DATA ===
        Console.WriteLine("===CARAPP===");

        // Din bils oplysninger
        Console.Write("Bil Type: ");
        string carType = Console.ReadLine();

        Console.Write("Bil Model: ");
        string carModel = Console.ReadLine();

        Console.Write("Bilens årgang: ");
        string carYear = Console.ReadLine();

        Console.Write("Brændstof Type: ");
        string fuelType = Console.ReadLine();

        Console.Write("KM per liter: ");
        double kmPerLiter = double.Parse(Console.ReadLine());

        Console.Write("Hvor langt har din bil kørt?: ");
        int kmAfstand = int.Parse(Console.ReadLine());

        // Output
        Console.WriteLine();
        Console.WriteLine("===Din bils oplysninger:====");
        Console.WriteLine($"Din bil type: {carType}");
        Console.WriteLine($"Din bil model: {carModel}");
        Console.WriteLine($"Din bils brændstoftype er: {fuelType}");
        Console.WriteLine($"Din bils KM/l er: {kmPerLiter}km");
        Console.WriteLine($"Dil bil har kørt: {kmAfstand}km");

        Console.WriteLine();

        // Benzin/disel priser
        double benzinPris = 13.49;
        double dieselPris = 12.29;

        Console.WriteLine($"Pris på benzin: {benzinPris}pr liter");
        Console.WriteLine($"Pris på disel: {dieselPris}pr liter");

        double totalForbrug = kmAfstand / kmPerLiter;
        double brændstofType = 0;

        if (fuelType.ToLower() == "benzin")
        {
            brændstofType = benzinPris;
        }
        else if (fuelType.ToLower() == "diesel")
        {
            brændstofType = dieselPris;
        }
        else
        {
            Console.WriteLine("Ukendt brændstoftype.");
            return;
        }

        double totalPris = totalForbrug * brændstofType;

        Console.WriteLine($"Den totale pris for {kmAfstand} km er: {totalPris:F0} kr");

        Console.WriteLine();

        Console.Write("Indtast din nuværende Kilometer Afstand: ");
        double gammelKMAfstand = double.Parse(Console.ReadLine());

        double nyKmAfstand = gammelKMAfstand + kmAfstand;
        int afrundetAfstand = (int)Math.Round(nyKmAfstand);

        Console.WriteLine($"Din nye KM Afstand er: {afrundetAfstand}");

        Console.WriteLine();
        Console.WriteLine(" === OPDATERET INFO === ");
        Console.WriteLine($"Bil Type: {carType}");
        Console.WriteLine($"Bilens Model: {carModel}");
        Console.WriteLine($"Bilens Årgang: {carYear}");
        Console.WriteLine($"Brændstof type: {fuelType}");
        Console.WriteLine($"Km/l: {kmPerLiter}");
        Console.WriteLine($"Originale Afstand: {gammelKMAfstand}");
        Console.WriteLine($"Nye Afstand {afrundetAfstand}");
        Console.WriteLine($"Brændstof Udgift: {totalPris}");

        int carPrice = 20000;
        int carInsurance = 5000;
        Console.WriteLine(String.Format("Prisen på bilen er \n-{0} og forsikring koster \n-{1}", carPrice, carInsurance));
        */
	}
}
