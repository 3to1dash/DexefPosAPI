namespace DataAccess.Domain.Models;

public partial class Preference
{
    public int Id { get; set; }
    public int? CustId { get; set; }
    public int? LanguageId { get; set; }
    public int? DefaultFilterPeriodId { get; set; }

    public virtual DefaultFilterPeriod? DefaultFilterPeriod { get; set; }
    public virtual Language? Language { get; set; }
}
