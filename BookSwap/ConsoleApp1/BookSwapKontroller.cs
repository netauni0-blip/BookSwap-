namespace BookSwap;

public class BookSwapKontroller
{
    private List<Annons> annonser;

    public BookSwapKontroller(List<Annons> annonser)
    {
        this.annonser = annonser;
    }

    public void ReserveraAnnons(int annonsId, Student student)
    {
        Annons? annons = annonser.FirstOrDefault(a => a.Id == annonsId);

        if (annons == null)
        {
            Console.WriteLine("Annonsen kunde inte hittas.");
            return;
        }

        if (annons.KanReserveras())
        {
            annons.Reservera(student);

            Affär affär = new Affär
            {
                Datum = DateTime.Now,
                Status = "reserverad"
            };

            Console.WriteLine("Annonsen har reserverats.");
        }
        else
        {
            Console.WriteLine("Annonsen kan inte reserveras.");
        }
    }
}
