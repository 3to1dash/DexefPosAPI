namespace DataAccess.Domain.Models;

public partial class DefaultFilterPeriod
{
    public DefaultFilterPeriod()
    {
        Preferences = new HashSet<Preference>();
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public int? DaysCount { get; set; }

    public virtual ICollection<Preference> Preferences { get; set; }
}
