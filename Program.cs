using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace CarappMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til min bilapp");
            Console.WriteLine("Tryk enter for at komme videre til indtastning af oplysninger");
            Console.WriteLine("------------------------------------------");
            Console.ResetColor();
            Console.ReadLine();

            Console.WriteLine("Indtast venligst din bils oplysninger herunder:");
            Console.WriteLine("Hvilket bilmærke? ");
            string bilmærke = Console.ReadLine();
            Console.WriteLine("Hvilken model? ");
            string model = Console.ReadLine();
            Console.WriteLine("Hvilken brændstoftype kører bilen på? ");
            string brændstoftype = Console.ReadLine();
            Console.WriteLine("Hvor langt kører bilen per liter? ");
            double kmperl = double.Parse(Console.ReadLine());
            Console.WriteLine("Hvad er kilometerstanden på bilen? ");
            int kilometerstand = int.Parse(Console.ReadLine());

            double fuelType = 0;
            double pris = 0;
            int Nykmantal = kilometerstand;

            Console.WriteLine("Din bils oplysninger er nu gemt. Tryk på enter for at komme videre til menuen");
            Console.ReadLine();

            // Velkomst til menuen
            ShowWelcome();

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\n==== HOVEDMENU ====");
                Console.WriteLine("1) Introduktion til menuen");
                Console.WriteLine("2) Kør en tur");
                Console.WriteLine("3) Beregn din tur");
                Console.WriteLine("4) Biloplysninger");
                Console.WriteLine("5) Er kilometerstanden palindrom?");
                Console.WriteLine("6) Afslut menuen");
                Console.Write("\nVælg en mulighed ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ShowIntro();
                        break;
                    case "2":
                        drive();
                        break;
                    case "3":
                        lavBeregning(kmperl, fuelType, pris, kilometerstand, brændstoftype);
                        break;
                    case "4":
                        biloplysninger(brændstoftype, kmperl, kilometerstand, bilmærke, model, Nykmantal, pris);
                        break;
                    case "5":
                        bool erPalindrom = IsPalindrome(kilometerstand);
                        if (erPalindrom)
                        {
                            Console.WriteLine("Kilometerstanden er palindrom");
                        }
                        else
                        {
                            Console.WriteLine("Kilometerstanden er ikke et palindrom");
                        }
                            break;
                    case "6":
                        isRunning = false;
                        Console.WriteLine("Programmet afsluttes.");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Fejl under indtastning, prøv igen");
                        break;
                }

            }
            static void ShowWelcome()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("************************************");
                Console.WriteLine("        VELKOMMEN TIL MENUEN        ");
                Console.WriteLine("************************************");
                Console.ResetColor();
                Console.WriteLine("\nTryk på enter for at komme i gang.");
                Console.ReadKey();
            }


            static void ShowIntro()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Dette er en applikation, der kan hjælpe dig med at beregne hvor meget det vil koste dig, at køre en bestemt tur, og hvilken kilometerstand din bil har efter turen");
                Console.ResetColor();
            }


            static void lavBeregning(double kmperl, double fuelType, double pris, int kilometerstand, string brændstoftype)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Hvor langt skal du køre? ");
                int afstand = int.Parse(Console.ReadLine());
                double benzinPris = 13.49;
                double dieselPris = 12.29;
                double benzinForbrug = afstand / kmperl;
                int Nykmantal = kilometerstand + afstand;
                if (brændstoftype.ToLower() == "benzin")
                {
                    fuelType = benzinPris;
                    pris = benzinForbrug * benzinPris;
                    Console.WriteLine("Din tur vil koste: {0} kr", pris);
                }
                else if (brændstoftype.ToLower() == "diesel")
                {
                    fuelType = dieselPris;
                    pris = benzinForbrug * dieselPris;
                    Console.WriteLine(
                        string.Format("Din tur vil koste: {0} kr", pris));
                }
                else
                {
                    Console.WriteLine("Ukendt brændstoftype");
                    return;
                }

                Console.WriteLine("Din nye kilometerstand på bilen vil være " + Nykmantal.ToString("N0", new System.Globalization.CultureInfo("da-DK")));

                Console.ReadLine();


            }

            static void biloplysninger(string brændstoftype, double kmperl, int kilometerstand, string bilmærke, string model, int Nykmantal, double pris)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("====BILENS OPLYSNINGER====");
                Console.WriteLine("Bilmærke: " + bilmærke);
                Console.WriteLine("Bilmodel: " + model);
                Console.WriteLine("Brændstoftype: " + brændstoftype);
                Console.WriteLine("Kilometer per liter: " + kmperl + "Km");
                Console.WriteLine("Kilometerstand " + kilometerstand.ToString("N0", new System.Globalization.CultureInfo("da-DK")) + "Km");
                
            }
            Console.ReadLine();

            static bool IsPalindrome(int kilometerstand)
            {
                Console.Clear();
                int startkm = kilometerstand;
                int omvendtkm = 0;
                while (kilometerstand > 0)
                {
                    int sidsteCiffer = kilometerstand % 10;
                    omvendtkm = omvendtkm * 10 + sidsteCiffer;
                    kilometerstand = kilometerstand / 10;
                }
                if (startkm == omvendtkm)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }

            static bool drive()
            {
                Console.Clear();
                Console.WriteLine("Er bilen tændt? ");
                string IsEngineOn = Console.ReadLine();

                if (IsEngineOn.ToLower() == "ja")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Du er dygtig");
                    Console.ResetColor();
                    return true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Idiot");
                    Console.ResetColor();
                    return false;

                    
                }
                
            }
        
        
        }   


    }
}
