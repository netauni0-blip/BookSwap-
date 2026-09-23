using BookSwap;

class Program
{
    static void Main()
    {
        Student student = new Student();

        Annons annons = new Annons
        {
            Titel = "Programmering i C#",
            Pris = 200,
            Skick = "Bra",
            Status = "till salu"
        };

        Console.WriteLine("Student och annons skapade.");
    }
}