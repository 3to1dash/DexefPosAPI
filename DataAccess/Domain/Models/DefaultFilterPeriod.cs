namespace DataAccess.Domain.Models;

public class DefaultFilterPeriod
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? DaysCount { get; set; }

    public virtual List<Preference> Preferences { get; set; }
}