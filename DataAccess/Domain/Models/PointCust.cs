namespace DataAccess.Domain.Models;

public class PointCust
{
    public decimal Id { get; set; }
    public string? Num { get; set; }
    public DateTime? Dt { get; set; }
    public string? Passowrd { get; set; }
    public decimal? CustId { get; set; }
    public string? Phone { get; set; }
    public string? Mail { get; set; }
    public bool? HasSms { get; set; }
    public bool? HasMail { get; set; }
    public string? Note { get; set; }
    public decimal? BranchId { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}
