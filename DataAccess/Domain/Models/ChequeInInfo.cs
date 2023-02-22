namespace DataAccess.Domain.Models;

public partial class ChequeInInfo
{
    public int Id { get; set; }
    public string? Ctype { get; set; }
    public int? BranchId { get; set; }
    public int? FromId { get; set; }
    public int? ToId { get; set; }
    public string? CheckNumber { get; set; }
    public string? BankName { get; set; }
    public decimal? Amount { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public DateTime? DueDate { get; set; }
    public string? Owner { get; set; }
    public string? ShipTo { get; set; }
    public decimal? ChequeTotal { get; set; }
    public string? Note { get; set; }
    public bool? Recieve { get; set; }
    public DateTime? RecieveDt { get; set; }
    public bool? GoCust { get; set; }
    public int? GoCustId { get; set; }
    public bool? GoBank { get; set; }
    public int? GoBankType { get; set; }
    public int? GoBankId { get; set; }
    public int? GoBankCapitalId { get; set; }
    public bool? BankDone { get; set; }
    public int? BankDoneId { get; set; }
    public int? BankDoneIndex { get; set; }
    public DateTime? BankDoneDt { get; set; }
    public bool? Returned { get; set; }
    public DateTime? ReturnedDt { get; set; }
    public int? ReturnedId { get; set; }
    public int? ReturnedAccountId { get; set; }
    public int? ReturnedBankId { get; set; }
    public int? ReturnedPayIndex { get; set; }
    public bool? CustReturn { get; set; }
    public Guid Rowguid { get; set; }
    public string? Status { get; set; }
    public bool? Attached { get; set; }
    public bool Deleted { get; set; }
    public bool Updated { get; set; }
    public string DeletedBy { get; set; } = null!;
    public DateTime? LstUpdate { get; set; }
}
