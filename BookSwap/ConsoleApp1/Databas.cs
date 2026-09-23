namespace BookSwap;

public class Databas
{
    private List<Annons> annonser = new List<Annons>();
    private List<Student> studenter = new List<Student>();
    private List<Affär> affärer = new List<Affär>();

    public Annons? HamtaAnnons(int id)
    {
        return annonser.FirstOrDefault(a => a.Id == id);
    }

    public void LäggTillAnnons(Annons annons)
    {
        annonser.Add(annons);
    }

    public Student? HamtaStudent(int id)
    {
        return studenter.FirstOrDefault(s => s.Id == id);
    }

    public void LäggTillStudent(Student student)
    {
        studenter.Add(student);
    }
    
    public void LäggTillAffär(Affär affär)
    {
        affärer.Add(affär);
    }
}
