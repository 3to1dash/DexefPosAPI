namespace DataAccess.Domain.Models;

public class Language
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual List<Preference> Preferences { get; set; }
}
