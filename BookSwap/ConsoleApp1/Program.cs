using BookSwap;

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            Id = 1,
            Förnamn = "Anna",
            Efternamn = "Andersson",
            Epost = "anna@example.com",
            Telefon = "0701234567"
        };

        Student säljare = new Student
        {
            Id = 2,
            Förnamn = "Erik",
            Efternamn = "Eriksson",
            Epost = "erik@example.com",
            Telefon = "0709999999"
        };

        Annons annons = new Annons
        {
            Id = 1,
            Titel = "Programmering i C#",
            Pris = 200,
            Skick = "Bra",
            Status = "till salu",
            Säljare = säljare
        };

        List<Annons> annonser = new List<Annons>();
        annonser.Add(annons);

        BookSwapKontroller kontroller = new BookSwapKontroller(annonser);

        bool kör = true;

        while (kör)
        {
            Console.Clear();
            Console.WriteLine("=== BookSwap ===");
            Console.WriteLine("1. Visa annonser");
            Console.WriteLine("2. Reservera annons");
            Console.WriteLine("3. Avsluta");
            Console.Write("Välj ett alternativ: ");

            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int val))
            {
                Console.WriteLine();
                Console.WriteLine("Ogiltigt val.");
                Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                Console.ReadKey();
                continue;
            }

            switch (val)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Tillgängliga annonser:");
                    Console.WriteLine();

                    List<Annons> tillgängliga = kontroller.BegärAnnonser();

                    foreach (Annons a in tillgängliga)
                    {
                        Console.WriteLine("ID: " + a.Id);
                        Console.WriteLine("Titel: " + a.Titel);
                        Console.WriteLine("Pris: " + a.Pris + " kr");
                        Console.WriteLine("Skick: " + a.Skick);
                        Console.WriteLine("Status: " + a.Status);
                        Console.WriteLine();
                    }
                    break;

                case 2:
                    Console.WriteLine();

                    kontroller.ReserveraAnnons(annons.Id, student);

                    break;

                case 3:
                    kör = false;
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Ogiltigt val.");
                    break;
            }

            if (kör)
            {
                Console.WriteLine();
                Console.WriteLine("Tryck på valfri tangent för att gå tillbaka till menyn...");
                Console.ReadKey();
            }
        }

        Console.WriteLine();
        Console.WriteLine("Programmet avslutas.");
    }
}
