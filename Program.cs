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
			Console.WriteLine("===Din bils oplysninger:===");
			Console.WriteLine($"Din bils brændstoftype er: {fuelType}");
			Console.WriteLine($"Din bils KM/l er: {kmPerLiter}km");
			Console.WriteLine($"Dil bil har kørt: {kmAfstand}km");

			Console.ReadLine();


		}
	}
}
