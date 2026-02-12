namespace MinBilProjekt
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("===CARAPP===");

			// Din bils oplysninger
			Console.Write("Brændstof Type: ");
			string fuelType = Console.ReadLine();

			Console.Write("KM per liter: ");
			double kmPerLiter = double.Parse(Console.ReadLine()); // gem som double

			Console.Write("Hvor langt har din bil kørt?: ");
			int kmAfstand = int.Parse(Console.ReadLine());

			// Output
			Console.WriteLine();
			Console.WriteLine("===Din bils oplysninger:====");
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



			Console.ReadLine();


			

		}
	}
}
