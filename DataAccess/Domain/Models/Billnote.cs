namespace DataAccess.Domain.Models;

public partial class Billnote
{
    public decimal Id { get; set; }
    public string? Note { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
}
