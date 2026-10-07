namespace MethodCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////skapa en lista med olika desitinationer och städer
            //List<Destinationer> destinations = new List<Destinationer>
            //{
            //    new Destinationer { countrys = "Malta", citys = "Valleta" },
            //    new Destinationer { countrys = "Spanien", citys = "Barcelona" },
            //    new Destinationer { countrys = "Italien", citys = "Rome" },
            //    new Destinationer { countrys = "Switzerland", citys = "Bern" }
            //};

            ////visa alla destinationer
            //foreach (var destination in destinations)
            //{
            //    destination.ShowDestination();
            //}



            //övning 1
            //Skapa en instans av ArrayExersice
            //new ArrayExersice();


            //övning 2. Söka efter en bok genom titel och visa dess detaljer.

            //BookManager bookManager = new BookManager();
            //bool keepRunning = true;

            //while (keepRunning)
            //{
            //    // Jag skapar en meny
            //    Console.Clear();
            //    DisplayMeny();

            //    // Läs användarens val
            //    string usersChoice = Console.ReadLine()!;

            //    // Använd switch för att hantera användarens val
            //    switch (usersChoice)
            //    {
            //        // LÄGGA TILL EN BOK
            //        case "1":
            //            // FRÅGA ANVÄNDAREN OM TITEL, FÖRFATTARE OCH ÅRTAL
            //            bookManager.AddBookMetod();
            //            break;

            //        case "2":
            //            Console.WriteLine("Här är alla våra böcker : ");
            //            bookManager.ShowAllBooks();
            //            break;

            //        case "3":
            //            bookManager.SearchBookByTitle();
            //            break;

            //        case "4":
            //            Console.WriteLine("Avslutar programmet...");
            //            keepRunning = false;
            //            break;
            //    }
            //}




            //Skapa en konsolapplikation som hanterar en samling böcker.
            //Skapa en klass Bok med egenskaper:
            //Titel(string)
            //Författare(string)
            //YearPublished(int)
            //Skapa en List < Bok > för att lagra böcker.
            //I menyn ska användaren kunna:
            //📗 Lägga till en bok(be om titel, författare och årtal).
            //📖 Visa alla böcker i samlingen.
            //🔍 Söka efter en bok genom titel och visa dess detaljer.

            //💡 Tips:
            //Använd foreach för att visa alla böcker.
            //Använd if och ToLower() för enkel sökning utan att vara känslig för stora / små bokstäver.
            //}

            //private static void DisplayMeny()
            //{
            //    Console.WriteLine("Välkommen till bokhanteraren!");

            //    Console.WriteLine("Välj ett alternativ:");
            //    Console.WriteLine("1 : Lägga till en bok");
            //    Console.WriteLine("2 : Visa alla böcker");
            //    Console.WriteLine("3 : Söka efter en bok genom titel");
            //    Console.WriteLine("4 : Avsluta");






            //Övning 3. Dictionary (studentbetyg
            //Skapa en Dictionary som lagrar studenters namn (string) och deras betyg (int).
            //Dictionary<string, int> studenter = new Dictionary<string, int>();

            ////Lägga till studenters namn och betyg
            ////Startdata
            //studenter.Add("Alice", 85);
            //studenter.Add("Bob", 92);
            //studenter.Add("Sarah", 78);

            ////Fråga i terminalen vad användaren vill göra
            //Console.WriteLine("Välj ett av följande altenativ");
            //Console.WriteLine("1: Lägg till en ny student och betyg");
            //Console.WriteLine("2: Uppdatera en students betyg");
            //Console.WriteLine("3: Visa alla elever och deras betyg");
            //Console.WriteLine("4: Beräkna och visa medelvärde");

            //int choice = Convert.ToInt32(Console.ReadLine());

            //string namn;

            //switch (choice)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("Ange studentens namn:");
            //            namn = Console.ReadLine();
            //            Console.WriteLine("Ange studentens betyg:");
            //            int betyg = Convert.ToInt32(Console.ReadLine());
            //            studenter.Add(namn, betyg);
            //            Console.WriteLine($"Studenten {namn} med betyget {betyg} har lagts till.");
            //            break;
            //        }

            //    case 2:
            //        {
            //            Console.WriteLine("Ange studentens namn:");
            //            namn = Console.ReadLine();
            //            Console.WriteLine("Ange det nya betyget:");
            //            int nyttBetyg = Convert.ToInt32(Console.ReadLine());
            //            studenter[namn] = nyttBetyg;
            //            Console.WriteLine($"Studenten {namn} har uppdaterat betyg till {nyttBetyg}.");
            //            break;
            //        }

            //    case 3:
            //        {
            //            Console.WriteLine("Alla elever och deras betyg:");
            //            foreach (var student in studenter)
            //            {
            //                Console.WriteLine($"Namn: {student.Key}, Betyg: {student.Value}");
            //            }
            //            break;
            //        }

            //    case 4:
            //        {
            //            double medelbetyg = 0;
            //            foreach (var student in studenter)
            //            {
            //                medelbetyg += student.Value;
            //            }
            //            medelbetyg /= studenter.Count;
            //            Console.WriteLine($"Medelbetyg: {medelbetyg:F2}");
            //            break;
            //        }

            //    default:
            //        {
            //            Console.WriteLine("Ogiltigt val.");
            //            break;
            //        }




            //Övning 4 - QUEUE
            //skapa en kö för att implementera enkelt uppgiftshanteringssystem. 
            //Queue<string> uppgiftshanteringssystem = new Queue<string>();

            ////lägg till uppgifter i kön
            ////startdata
            //uppgiftshanteringssystem.Enqueue("Städa rummet");
            //uppgiftshanteringssystem.Enqueue("Skriv en rapport");
            //uppgiftshanteringssystem.Enqueue("Laga mat");

            ////fråga terminalen vad användaren vill göra
            //Console.WriteLine("Välj ett av följande alternativ:");
            //Console.WriteLine("1: Lägg till en ny uppgift");
            //Console.WriteLine("2: Visa nästa uppgift");
            //Console.WriteLine("3: slutföra en uppgift");
            //Console.WriteLine("4: Visa alla återstående uppgifter i kön");
            //int val = Convert.ToInt32(Console.ReadLine());

            //switch (val)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("Ange den nya uppgiften:");
            //            string nyUppgift = Console.ReadLine();
            //            uppgiftshanteringssystem.Enqueue(nyUppgift);
            //            Console.WriteLine($"Uppgiften '{nyUppgift}' har lagts till i kön.");
            //            break;
            //        }
            //    case 2:
            //        {
            //            if (uppgiftshanteringssystem.Count > 0)
            //            {
            //                Console.WriteLine($"Nästa uppgift: {uppgiftshanteringssystem.Peek()}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Kön är tom.");
            //            }
            //            break;
            //        }
            //    case 3:
            //        {
            //            if (uppgiftshanteringssystem.Count > 0)
            //            {
            //                string slutfördUppgift = uppgiftshanteringssystem.Dequeue();
            //                Console.WriteLine($"Uppgiften '{slutfördUppgift}' har slutförts och tagits bort från kön.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Kön är tom. Ingen uppgift att slutföra.");
            //            }
            //            break;
            //        }
            //    case 4:
            //        {
            //            if (uppgiftshanteringssystem.Count > 0)
            //            {
            //                Console.WriteLine("Återstående uppgifter i kön:");
            //                foreach (var uppgift in uppgiftshanteringssystem)
            //                {
            //                    Console.WriteLine(uppgift);
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Kön är tom.");
            //            }
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("Ogiltigt val.");
            //            break;
            //}







            //Övning 5 - Stack (text och "Ångra" funktion)
            //Skpa en stack för att lagra textinmatningar med en "ångra" funktion.
            Stack<string> textStack = new Stack<string>();

            //Lägg till några starttexter i stacken
            textStack.Push("Första texten");
            textStack.Push("andra texten");
            textStack.Push("tredje texten");


            //Fråga användaren vad de vill göra
            Console.WriteLine("Välj ett av följande alternativ:");
            Console.WriteLine("1: Lägg till en text");
            Console.WriteLine("2: Ångra senaste inmatningen");
            Console.WriteLine("3: Visa aktuell text");
            int val = Convert.ToInt32(Console.ReadLine());

            //1. Lägg till en text (push)
            if (val == 1)
            {
                Console.WriteLine("Ange texten du vill lägga till:");
                string nyText = Console.ReadLine();
                textStack.Push(nyText);
                Console.WriteLine($"Texten '{nyText}' har lagts till.");
            }
            //2. Ångra senaste inmatningen (pop)
            else if (val == 2)
            {
                if (textStack.Count > 0)
                {
                    string ångradText = textStack.Pop();
                    Console.WriteLine($"Texten '{ångradText}' har ångrats.");
                }
                else
                {
                    Console.WriteLine("Ingen text att ångra.");
                }
            }
            //3. Visa aktuell text (peek)
            else if (val == 3)
            {
                if (textStack.Count > 0)
                {
                    Console.WriteLine("Aktuell text (från senaste till äldsta):");
                    foreach (var text in textStack)
                    {
                        Console.WriteLine(text);
                    }
                }
                else
                {
                    Console.WriteLine("Ingen text att visa.");
                }
            }
        }

    }
}

    

