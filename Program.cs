namespace MinBilProjekt
{
	internal class Program
	{
		static void Main(string[] args)
		{
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
			double kmPerLiter = double.Parse(Console.ReadLine()); // gem som double

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

			// Ouput
			Console.WriteLine($"Pris på benzin: {benzinPris}pr liter");
			Console.WriteLine($"Pris på disel: {dieselPris}pr liter");

			// Prisen på total kilometer kørt

			double totalForbrug = kmAfstand / kmPerLiter;
			double brændstofType = 0;


			// Eneste måde, jeg lige kunne komme på en løsning (Conditional Statement)
			if (fuelType.ToLower() == "benzin") // ToLower sikrer, at koden virker, hvis der er stavefejl
			{
				brændstofType = benzinPris; //benzinPris == 13.49
			}
			else if (fuelType.ToLower() == "diesel") // ToLower sikrer, at koden virker, hvis der er stavefejl
			{
				brændstofType = dieselPris; // diselPris == 12.29
			}
			else
			{
				Console.WriteLine("Ukendt brændstoftype.");
				return;
			}

			double totalPris = totalForbrug * brændstofType;

			Console.WriteLine($"Den totale pris for {kmAfstand} km er: {totalPris:F0} kr");

			Console.WriteLine();

			// Opdateret Kilometerafstand
			Console.Write("Indtast din nuværende Kilometer Afstand: ");
			double gammelKMAfstand = double.Parse(Console.ReadLine());

			double nyKmAfstand = gammelKMAfstand + kmAfstand;
			int afrundetAfstand = (int)Math.Round(nyKmAfstand);

			Console.WriteLine(($"Din nye KM Afstand er: {afrundetAfstand}"));

			// Opdateret info Output
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
			Console.WriteLine();

			// String format

			// Tabel over Bil Info
			Console.WriteLine("TABEL MED DIN INFORMATION");
			Console.WriteLine();
			Console.WriteLine("==============================================================");
			Console.WriteLine("| " + "Felt".PadRight(22) + "| " + "Værdi".PadRight(20) + "| " + "Enhed".PadRight(8) + "|");
			Console.WriteLine("==============================================================");

			// Kolonner
			Console.WriteLine("| " + "Bil Type:".PadRight(22) + "| " + carType.PadRight(20) + "| " + "-".PadRight(8) + "|");
			Console.WriteLine("| " + "Model:".PadRight(22) + "| " + carModel.PadRight(20) + "| " + "-".PadRight(8) + "|");
			Console.WriteLine("| " + "Bilens årgang:".PadRight(22) + "| " + carYear.ToString().PadRight(20) + "| " + "-".PadRight(8) + "|");
			Console.WriteLine("| " + "Brændstof type:".PadRight(22) + "| " + fuelType.PadRight(20) + "| " + "-".PadRight(8) + "|");
			Console.WriteLine("| " + "Km/l:".PadRight(22) + "| " + kmPerLiter.ToString("F2").PadRight(20) + "| " + "km/l".PadRight(8) + "|");
			Console.WriteLine("| " + "Original afstand:".PadRight(22) + "| " + gammelKMAfstand.ToString().PadRight(20) + "| " + "km".PadRight(8) + "|");
			Console.WriteLine("| " + "Ny afstand:".PadRight(22) + "| " + afrundetAfstand.ToString().PadRight(20) + "| " + "km".PadRight(8) + "|");
			Console.WriteLine("| " + "Brændstof udgift:".PadRight(22) + "| " + totalPris.ToString("F2").PadRight(20) + "| " + "kr".PadRight(8) + "|");
			Console.WriteLine("==============================================================");
			Console.WriteLine();



			Console.ReadLine();


		}
	}
}
