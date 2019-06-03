using System;

namespace GætEtTal3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            AppInfo();

            MødSpiller();

            while (true)
            {

                Random random = new Random();

                int gæt = 0;

                int forsøg = 0;

                // Spørger bruger om at skrive 2 tal, som han så skal gætte et tal imellem
                Console.WriteLine("Skriv de tal du vil gætte et tal imellem");

                Console.ResetColor();

                // Tallet brugeren skriver bliver gemt i variablen
                string førsteTal = Console.ReadLine();
                int _førsteTal = 0;


                // Det andet tal bruger skriver bliver gemt i variablen
                string andetTal = Console.ReadLine();
                int _andetTal = 0;

                Console.ForegroundColor = ConsoleColor.Green;

                // tjek at brugeren skriver to tal
                if ((!Int32.TryParse(førsteTal, out _førsteTal)) || (!Int32.TryParse(andetTal, out _andetTal))){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fejl til og fra skal skrives som tal \n De bliver nu default sat til 1 og 100");
                    _førsteTal = 1;
                    _andetTal = 100;
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                // Laver et tilfældigt tal mellem de tal brugeren har valgt, og gemmer det i variablen
                int tal = random.Next(_førsteTal, _andetTal);

                // Fortæller brugeren at han har valgt at gætte et tal mellem de to selvvalgte tal
                Console.WriteLine("Du har valgt at gætte et tal mellem {0} og {1}", _førsteTal, _andetTal);

                // Spørger brugeren om at gætte et nummer
                Console.WriteLine("Gæt et tal mellem {0} og {1}", _førsteTal, _andetTal);

                // Mens gæt ikke er lig med det tilfældige tal
                while (gæt != tal)
                {
                    Console.ResetColor();

                    // Får brugerens input
                    string input = Console.ReadLine();

                    // Tjek at brugeren skriver et tal
                    if (!int.TryParse(input, out gæt))
                    {
                        PrintFarveBesked(ConsoleColor.Red, "Du skal skrive et tal");

                        continue;
                    }

                    // Hvis brugerens gæt er større end det tilfældige tal
                    if (gæt > tal)
                    {
                        forsøg++;
                        PrintFarveBesked(ConsoleColor.Red, "Tallet er lavere end " + gæt.ToString() + ", du har brugt " + forsøg.ToString() + " forsøg");
                    }
                    // Eller hvis brugerens gæt er lavere end det tilfældige tal
                    else if (gæt < tal)
                    {
                        forsøg++;
                        PrintFarveBesked(ConsoleColor.Red, "Tallet er højere end " + gæt.ToString() + ", du har brugt " + forsøg.ToString() + " forsøg");

                    }
                    // Eller hvis brugerens gæt er det rigtige tal
                    else if (gæt == tal)
                    {
                        forsøg++;
                        PrintFarveBesked(ConsoleColor.Yellow, "TILLYKKE!!! Du gættede rigtigt, tallet var " + tal.ToString() + ", du brugte " + forsøg.ToString() + " forsøg");
                    }
                }
                // Spørger om brugeren vil spille igen
                Console.WriteLine("Spil igen? [J eller N]");

                // Det brugeren skriver bliver laver om til stor skrift, og gemt i variablen
                string svar = Console.ReadLine().ToUpper();

                // Hvis bruger svarer J altså ja
                if (svar == "J")
                {
                    continue;
                }
                // Eller hvis brugeren svarer N altså nej 
                else if (svar == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void AppInfo()
        {
            string appNavn = "Gæt et tal";
            string appVersion = "3.0.0";
            string appUdvikler = "Emil Andersen";

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("{0}: Version {1} af {2}", appNavn, appVersion, appUdvikler);
        }

        static void MødSpiller()
        { 
            Console.ForegroundColor = ConsoleColor.Green;


            Console.WriteLine("Hvad er dit navn");

            Console.ResetColor();

            // Det brugeren skriver bliver gemt i variablen
            string inputNavn = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Hej {0}, lad os spille et spil...", inputNavn);
        }

        static void PrintFarveBesked(ConsoleColor color, string besked)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(besked);
            Console.ResetColor();
        }
    }
}
