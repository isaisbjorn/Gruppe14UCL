namespace CarappISA
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ShowWelcome();
			ShowMenu();

			static void ShowWelcome()
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.WriteLine("==========================================");
				Console.WriteLine("        VELKOMMEN TIL ISA'S CARAPP        ");
				Console.WriteLine("==========================================");
				Console.WriteLine("\nTryk på en tast for at starte...");
				Console.ReadKey();
				Console.Clear();
			}

			static void ShowMenu()
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("==========================================");
				Console.WriteLine("                   MENU                   ");
				Console.WriteLine("==========================================");
				Console.WriteLine("\nVælg en valgmuligheder");
				Console.WriteLine("1. Overblik over din bils oplysninger");
				Console.WriteLine("2. Simulér en køretur");
				Console.WriteLine("3. Beregn pris for en køretur");
				Console.WriteLine("4. Se et cute billede :)");
				Console.WriteLine("5. Afslut programmet");
				Console.Write("\nIndtast dit valg (1-5): ");

				string userInput = Console.ReadLine(); // Læs brugerens input


				switch (userInput)
				{
					case "1":
						BrugerensBilInput();
						Console.WriteLine("Tryk på en tast for at vende tilbage til menuen...");
						Console.ReadKey();
						Console.Clear();
						ShowMenu();
						
						break;

					case "2":
						SimulerKøretur();
					
						
						Console.WriteLine("Tryk på en tast for at vende tilbage til menuen...");
						Console.ReadKey();
						Console.Clear();
						ShowMenu();
						
						break;

					case "3":
						PrisPaKoretur();
						Console.WriteLine("Tryk på en tast for at vende tilbage til menuen...");
						Console.ReadKey();
						Console.Clear();
						ShowMenu();
						
						break;

					case "4":
						Console.WriteLine("Her er et cute billede af en ugle! 🦉");
						Console.WriteLine("  ,_,\r\n (o,o)\r\n /)  )\r\n  \" \"\r\n");
						Console.WriteLine("Tryk på en tast for at vende tilbage til menuen...");
						Console.ReadKey();
						Console.Clear();
						ShowMenu();

						break;

					case "5":
						AfslutProgram();
						break;

					default:
						Console.WriteLine("Ugyldigt valg, prøv igen.");
						break;

						
						static void returnToMenuFunction()
						{
							Console.WriteLine("Tryk på en tast for at vende tilbage til menuen...");
							Console.ReadKey();
							Console.Clear();
							ShowMenu();
						}

						static void AfslutProgram()
						{
							Console.WriteLine("Tak for at bruge ISA's CarApp! Farvel!");
							Environment.Exit(0);
						}
						//Denne variabel bliver ikke brugt, da det er nemmere at bruge Console.ReadKey() direkte i casesne
						String returnToMenu = Console.ReadKey().ToString();
						Console.WriteLine("Tryk på 'Enter' for at vende tilbage til menuen...");
						if (returnToMenu == "Enter")
						{
							Console.Clear();
							ShowMenu();
						}


						static void PrisPaKoretur()
						{
							Console.WriteLine("Prisberegning for køretur er under udvikling. Kom tilbage senere!");
						}

						static bool IsPalindrome(int km)
						{
							string original = km.ToString();

							char[] array = original.ToCharArray();

							Array.Reverse(array);

							string reversed = new string(array);

							return original == reversed;
						}


						static void SimulerKøretur()
						{
							Console.Clear();

							Console.WriteLine("==========================================");
							Console.WriteLine("           SIMULÉR EN KØRETUR            ");
							Console.WriteLine("==========================================");

							Console.Write("Er motoren tændt? (ja/nej): ");
							string engineInput = Console.ReadLine().ToLower();
							bool isEngineOn = engineInput == "ja";

							Console.Write("Indtast bilens nuværende km-stand: ");
							double odometer = double.Parse(Console.ReadLine());

							Console.Write("Hvor mange km vil du køre?: ");
							double distance = double.Parse(Console.ReadLine());

							if (isEngineOn)
							{
								odometer = odometer + distance;

								Console.WriteLine("Motoren var tændt.");
								Console.WriteLine($"Du kørte {distance} km.");
								Console.WriteLine($"Ny km-stand er: {odometer} km.");

								// Palindrom-tjek efter turen
								bool resultat = IsPalindrome((int)odometer);

								if (resultat)
								{
									Console.WriteLine("Km-standen er et palindrom!");
								}
								else
								{
									Console.WriteLine("Km-standen er IKKE et palindrom.");
								}
							}
							else
							{
								Console.WriteLine("Motoren er slukket. Bilen kan ikke køre.");
								Console.WriteLine($"Km-stand er stadig: {odometer} km.");
							}
						}
				}
							}

						}

						static void BrugerensBilInput()
						{
							Console.WriteLine("Indtast bilmærke:");
							string brand = Console.ReadLine();

							Console.WriteLine("Indtast kilometer på literen:");
							string kmPrL = Console.ReadLine();
							double kmPrLDouble = double.Parse(kmPrL);

							Console.WriteLine("Indtast brændstoftype:");
							string fuelType = Console.ReadLine();

							Console.WriteLine("Indtast hvor langt du skal køre:");
							string distance = Console.ReadLine();
							double distanceDouble = double.Parse(distance);

							Console.WriteLine("Indtast hvor langt bilen allerede har kørt i alt:");
							string totalDistance = Console.ReadLine();
							double totalDistanceDouble = double.Parse(totalDistance);



							double benzinPrice = 13.49;

							double dieselPrice = 12.29;

							double totalCost = 0;

							if (fuelType.ToLower() == "benzin")
							{
								totalCost = distanceDouble / kmPrLDouble * benzinPrice;
								Console.WriteLine(string.Format("Du skal betale {0} kr. for at køre {1} km i en {2} med benzin.", totalCost, distanceDouble, brand));

							}
							else if (fuelType.ToLower() == "diesel")
							{
								totalCost = distanceDouble / kmPrLDouble * dieselPrice;
								Console.WriteLine(string.Format("Du skal betale {0} kr. for at køre {1} km i en {2} med diesel.", totalCost, distanceDouble, brand));
							}
							else
							{
								Console.WriteLine("Ukendt brændstoftype.");
								return;
							}


							double totalDistanceAfterTrip = totalDistanceDouble + distanceDouble;
							Console.WriteLine(string.Format("Efter turen vil bilen have kørt i alt {0} km.", totalDistanceAfterTrip));

							string fuelTypeLower = fuelType.ToLower();
							double pricePerLiter = (fuelTypeLower == "benzin") ? benzinPrice : dieselPrice;
							double litersUsed = distanceDouble / kmPrLDouble;

							// Pænt skema
							Console.Clear();
							Console.ForegroundColor = ConsoleColor.Magenta;
							Console.WriteLine();
							Console.WriteLine("==============================================");
							Console.WriteLine("            Din bils oplysninger              ");
							Console.WriteLine("==============================================");

							string col1 = "Hvad?".PadRight(22);
							string col2 = "Værdi".PadRight(22);
							Console.WriteLine(col1 + "| " + col2);
							Console.WriteLine(new string('-', 46));

							Console.WriteLine("Bilmærke".PadRight(22) + "| " + brand);
							Console.WriteLine("Brændstoftype".PadRight(22) + "| " + fuelTypeLower);
							Console.WriteLine("Km pr. liter".PadRight(22) + "| " + kmPrLDouble.ToString("F2"));
							Console.WriteLine("Tur (km)".PadRight(22) + "| " + distanceDouble.ToString("F2"));
							Console.WriteLine("Km-stand før".PadRight(22) + "| " + totalDistanceDouble.ToString("F2"));
							Console.WriteLine(new string('-', 46));
							Console.WriteLine("Pris pr. liter".PadRight(22) + "| " + pricePerLiter.ToString("F2") + " kr");
							Console.WriteLine("Forbrug (liter)".PadRight(22) + "| " + litersUsed.ToString("F2") + " L");
							Console.WriteLine("Turpris".PadRight(22) + "| " + totalCost.ToString("F2") + " kr");
							Console.WriteLine("Km-stand efter".PadRight(22) + "| " + totalDistanceAfterTrip.ToString("F2"));
							Console.WriteLine("==============================================");
							Console.WriteLine();
						}
				}
			}
		
	


