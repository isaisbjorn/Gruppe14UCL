namespace Gruppe14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hvilken brændstoftype kører bilen på? ");
            string brændstoftype = Console.ReadLine();
            Console.WriteLine("Hvor langt kører bilen per liter? ");
            double kmperl = double.Parse(Console.ReadLine());
            Console.WriteLine("Hvad er kilometerstanden på bilen? ");
            int kilometerstand = int.Parse(Console.ReadLine());

            Console.WriteLine("Brændstoftype " + brændstoftype);
            Console.WriteLine("KM per liter " + kmperl);
            Console.WriteLine("Kilometerstand " + kilometerstand + "Km");

            Console.ReadLine();

            Console.WriteLine("Hvor langt skal du køre? ");
            int afstand = int.Parse(Console.ReadLine());

            double benzinPris = 13.49;
            double dieselPris = 12.29;
            double benzinForbrug = afstand / kmperl;
            double fuelType = 0;
            double pris = 0;

            // IF ELSE METODE
            // Definer double, int osv uden for if else, så det stadig kan bruges i resten af koden.
            if (brændstoftype.ToLower() == "benzin")
            {
                fuelType = benzinPris;
                pris = benzinForbrug * benzinPris;
                Console.WriteLine("Din tur vil koste: " + pris + "Kr");
            }
            else if (brændstoftype.ToLower() == "diesel")
            {
                fuelType = dieselPris;
                pris = benzinForbrug * dieselPris;
                Console.WriteLine("Din tur vil koste: " + pris + "Kr");
            }
            else
            {
                Console.WriteLine("Ukendt brændstoftype");
                return;
            }
                        
            Console.ReadLine();

            int Nykmantal = kilometerstand + afstand;
            
            Console.ReadLine();

            Console.WriteLine("====BILENS OPLYSNINGER====");
            Console.WriteLine("Brændstoftype: " + brændstoftype);
            Console.WriteLine("Kilometer per liter: " + kmperl);
            Console.WriteLine("Oprindelig kilometerstand " + kilometerstand + "Km");
            Console.WriteLine("Ny kilometerstand " + Nykmantal + "Km");
            Console.WriteLine("Brændstofudgift " + pris + "kr");
            Console.ReadLine();
            */

            // Overskrift
            Console.WriteLine("Bilmærke ".PadRight(15) + "| " + " Model ".PadRight(12) + "|" + " Kilometertal ".PadLeft(12));
            Console.WriteLine("-------------------------------------------------");
            // Række 1
            Console.WriteLine("Toyota ".PadRight(15,'.') + "|" + " Corolla ".PadRight(12) + "|" + " 156.000 ".PadLeft(12));
            // Række 2
            Console.WriteLine("Ford ".PadRight(15) + "|" + " Fiesa ".PadRight(12) + "|" + " 112.000 km ".PadLeft(12));
            Console.ReadLine(); //For en afslutning på denne del.
        }
    }
}
