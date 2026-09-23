namespace BookSwap;

public class BookSwapKontroller
{
    private Databas databas; 
    
    public BookSwapKontroller(Databas databas)
    {
        this.databas = databas;
    }

    public void ReserveraAnnons(int annonsId)
    {
        Annons? annons = databas.HamtaAnnons(annonsId);
        Student? student = databas.HamtaStudent(studentId);

        if (annons != null && student != null)
        {
            if (annons.KanReserveras())
            {
                annons.Reservera(student);

                Affär affär = new Affär
                {
                    Datum = DateTime.Now,
                    Status = "reserverad",
                    Köpare = student,
                    Säljare = null,
                    Annons = annons
                };

                databas.LäggTillAffär(affär);
            }
        }
    }
}
