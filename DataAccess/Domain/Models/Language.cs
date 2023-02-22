namespace DataAccess.Domain.Models;

public partial class Language
{
    public Language()
    {
        Preferences = new HashSet<Preference>();
    }

    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual ICollection<Preference> Preferences { get; set; }
}
