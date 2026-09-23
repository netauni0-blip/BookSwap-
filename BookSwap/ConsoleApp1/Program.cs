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
            Console.WriteLine("=== BookSwap ===");
            Console.WriteLine("1. Visa annons");
            Console.WriteLine("2. Reservera annons");
            Console.WriteLine("3. Avsluta");
            Console.Write("Välj: ");

            string? val = Console.ReadLine();

            if (val == "1")
            {
                Console.WriteLine();
                Console.WriteLine("Annons:");
                Console.WriteLine("ID: " + annons.Id);
                Console.WriteLine("Titel: " + annons.Titel);
                Console.WriteLine("Pris: " + annons.Pris + " kr");
                Console.WriteLine("Skick: " + annons.Skick);
                Console.WriteLine("Status: " + annons.Status);
                Console.WriteLine();
            }
            else if (val == "2")
            {
                kontroller.ReserveraAnnons(1, student);
                Console.WriteLine();
            }
            else if (val == "3")
            {
                kör = false;
            }
            else
            {
                Console.WriteLine("Ogiltigt val.");
            }
        }
    }
}
