namespace DataAccess.Domain.Models;

public class ChequeOutInfo
{
    public long Id { get; set; }
    public string? Ctype { get; set; }
    public int? BranchId { get; set; }
    public int? FromId { get; set; }
    public int? ToId { get; set; }
    public int? BankId { get; set; }
    public string? CheckNumber { get; set; }
    public decimal? Amount { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public DateTime? DueDate { get; set; }
    public string? Owner { get; set; }
    public string? ShipTo { get; set; }
    public decimal? ChequeTotal { get; set; }
    public string? Note { get; set; }
    public bool? Recieve { get; set; }
    public bool? BankDone { get; set; }
    public DateTime? BankDoneDt { get; set; }
    public bool? Returned { get; set; }
    public DateTime? ReturnedDt { get; set; }
    public Guid Rowguid { get; set; }
    public string? Status { get; set; }
    public bool? Attached { get; set; }
}