namespace DataAccess.Domain.Models;

public partial class SmsalertEntry
{
    public int Id { get; set; }
    public int? AlertId { get; set; }
    public int? CustId { get; set; }
}
