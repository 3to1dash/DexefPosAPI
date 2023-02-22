namespace DataAccess.Domain.Models;

public partial class PriceScannerNews
{
    public int Id { get; set; }
    public string? News { get; set; }
    public int? ForeColor { get; set; }
    public int? BackColor { get; set; }
}
