namespace DataAccess.Domain.Models;

public class PotMail
{
    public decimal Id { get; set; }
    public decimal? Custid { get; set; }
    public DateTime? Dt { get; set; }
    public string? Subject { get; set; }
    public Guid Rowguid { get; set; }
}
