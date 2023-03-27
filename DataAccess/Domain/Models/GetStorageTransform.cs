namespace DataAccess.Domain.Models;

public class GetStorageTransform
{
    public string? FromBranch { get; set; }
    public string? ToBranch { get; set; }
    public decimal Id { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public int? Num { get; set; }
    public int? FromId { get; set; }
    public int? ToId { get; set; }
    public string? Ship { get; set; }
    public int? ToBranchId { get; set; }
    public byte? PayFrom { get; set; }
    public byte? PayTo { get; set; }
    public decimal? Value { get; set; }
    public decimal? TransferValue { get; set; }
    public decimal? Rate { get; set; }
    public string? Currency { get; set; }
    public string? ToCurrency { get; set; }
    public decimal? FromRate { get; set; }
    public decimal? FromTotal { get; set; }
    public decimal? ToRate { get; set; }
    public decimal? ToTotal { get; set; }
    public decimal? Total { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdateBy { get; set; }
    public int? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public int? TransferId { get; set; }
    public int? TransferPercId { get; set; }
    public decimal? TransferPerc { get; set; }
    public bool? IsMultiBranch { get; set; }
    public bool? PercFromTarget { get; set; }
    public int? SecondRegNum { get; set; }
    public int? TaxId { get; set; }
    public decimal? TaxPerc { get; set; }
    public decimal? Taxes { get; set; }
    public string? RefNumber { get; set; }
    public bool? Attached { get; set; }
}