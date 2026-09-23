namespace BookSwap;

public class Annons
{
    public string Titel { get; set; } = "";
    public decimal Pris { get; set; }
    public string Skick { get; set; } = "";
    public DateTime Publiceringsdatum { get; set; }
    public string Status { get; set; } = "";

    public bool KanReserveras()
    {
        return Status == "till salu";
    }

    public void Reservera()
    {
        Status = "reserverad";
    }
}