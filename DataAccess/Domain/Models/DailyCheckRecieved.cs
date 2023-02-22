namespace DataAccess.Domain.Models;

public partial class DailyCheckRecieved
{
    public decimal Id { get; set; }
    public int? ChequeId { get; set; }
    public string? Dealing { get; set; }
    public DateTime? Dt { get; set; }
    public string? BillNum { get; set; }
    public int? AccountId { get; set; }
    public string? AccountType { get; set; }
    public decimal? TaskId { get; set; }
    public Guid Rowguid { get; set; }
}
