namespace DataAccess.Domain.Models;

public partial class CustDonation
{
    public int CustId { get; set; }
    public bool? Active { get; set; }
    public string? Memo { get; set; }
    public Guid Rowguid { get; set; }
}
