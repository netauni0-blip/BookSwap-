using BookSwap;

class Program
{
    static void Main()
    {
        Databas databas = new Databas();

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

            databas.LäggTillStudent(student);
            databas.LäggTillAnnons(annons);
       
          bool kör = true;

        while (kör)
        {
            Console.WriteLine("=== BookSwap ===");
            Console.WriteLine("1. Visa annonser");
            Console.WriteLine("2. Reservera annons");
            Console.WriteLine("3. Avsluta");
            Console.Write("Välj: ");

            string val = Console.ReadLine();

            if (val == "1")
            {
                Console.WriteLine("Visa annonser");
            }
            else if (val == "2")
            {
                Console.WriteLine("Reservera annons");
            }
            else if (val == "3")
            {
                kör = false;
            }
            else
            {
                Console.WriteLine("Ogiltigt val.");
            }

            Console.WriteLine();
        }
    }
}
