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

        Annons annons = new Annons
        {
            Id = 1,
            Titel = "Programmering i C#",
            Pris = 200,
            Skick = "Bra",
            Status = "till salu"
        };

        List<Annons> annonser = new List<Annons>();
        annonser.Add(annons);

        BookSwapKontroller kontroller = new BookSwapKontroller(annonser);

        bool kör = true;

        while (kör)
        {
            Console.Clear();
            Console.WriteLine("=== BookSwap ===");
            Console.WriteLine("1. Visa annons");
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
                    Console.WriteLine("Annons:");
                    Console.WriteLine("ID: " + annons.Id);
                    Console.WriteLine("Titel: " + annons.Titel);
                    Console.WriteLine("Pris: " + annons.Pris + " kr");
                    Console.WriteLine("Skick: " + annons.Skick);
                    Console.WriteLine("Status: " + annons.Status);
                    Console.WriteLine();
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
