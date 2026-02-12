namespace Gruppe14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvilken brændstoftype kører bilen på? ");
            string brændstoftype = Console.ReadLine();
            Console.WriteLine("Hvor langt kører bilen per liter? ");
            double kmperl = double.Parse(Console.ReadLine());
            Console.WriteLine("Hvad er kilometerstanden på bilen? ");
            int kilometerstand = int.Parse(Console.ReadLine());

            Console.WriteLine("Brændstoftype " + brændstoftype);
            Console.WriteLine("KM per liter " + kmperl);
            Console.WriteLine("Kilometerstand " + kilometerstand);

            Console.ReadLine();

            Console.WriteLine("Hvor langt skal du køre? ");
            int afstand = int.Parse(Console.ReadLine());

            double benzinPris = 13.49;
            double dieselPris = 12.29;
            double benzinForbrug = afstand / kmperl;
            double fuelType = 0;

            // IF ELSE METODE
            if (brændstoftype.ToLower() == "benzin")
            {
                fuelType = benzinPris;
                double pris = benzinForbrug * benzinPris;
                Console.WriteLine("Din tur vil koste: " + pris);
            }
            else if (brændstoftype.ToLower() == "diesel")
            {
                fuelType = dieselPris;
                double pris = benzinForbrug * dieselPris;
                Console.WriteLine("Din tur vil koste: " + pris);
            }
            else
            {
                Console.WriteLine("Ukendt brændstoftype");
                return;
            }
              
            
            
            Console.ReadLine();

            int Nykmantal = kilometerstand + afstand;
            Console.WriteLine("Ny kilometer stand: " + Nykmantal);

            Console.ReadLine();

        }
    }
}
