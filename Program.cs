namespace Gruppe14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvilken brændstoftype kører bilen på? ");
            string brændstoftype = Console.ReadLine();
            Console.WriteLine("Hvor langt kører bilen per liter? ");
            int kmperl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hvad er kilometerstanden på bilen? ");
            string kilometerstand = Console.ReadLine();

            Console.WriteLine("Brændstoftype " + brændstoftype);
            Console.WriteLine("KM per liter " + kmperl);
            Console.WriteLine("Kilometerstand " + kilometerstand);

            Console.ReadLine();

            Console.WriteLine("Hvor langt skal du køre? ");

        }
    }
}
