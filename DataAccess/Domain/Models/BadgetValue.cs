namespace DataAccess.Domain.Models;

public partial class BadgetValue
{
    public int Id { get; set; }
    public int? BadgetId { get; set; }
    public int? BadgetItemId { get; set; }
}
