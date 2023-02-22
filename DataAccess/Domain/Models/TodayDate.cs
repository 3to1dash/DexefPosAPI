namespace DataAccess.Domain.Models;

public partial class TodayDate
{
    public DateTime Dt { get; set; }
    public DateTime? Hijri { get; set; }
    public Guid Rowguid { get; set; }
}
