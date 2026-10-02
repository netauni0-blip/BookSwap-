namespace BookSwap;

public class Affär
{
    public DateTime Datum { get; set; }
    public string Status { get; set; } = "";
    public Student? Köpare { get; set; }
    public Student? Säljare { get; set; }
    public Annons? Annons { get; set; }
}
