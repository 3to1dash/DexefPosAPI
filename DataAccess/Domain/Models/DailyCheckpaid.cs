namespace DataAccess.Domain.Models;

public class DailyCheckpaid
{
    public decimal Id { get; set; }
    public bool? Idcheck { get; set; }
    public string? Dealing { get; set; }
    public string? State { get; set; }
    public string? Num { get; set; }
    public DateTime? Dt { get; set; }
    public DateTime? RequireDate { get; set; }
    public string? Bankid { get; set; }
    public decimal? Custid { get; set; }
    public string? Main { get; set; }
    public string? Owner { get; set; }
    public decimal? Value { get; set; }
    public string? Currency { get; set; }
    public decimal? Currencyvalue { get; set; }
    public decimal? Total { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? Fromid { get; set; }
    public decimal? Toid { get; set; }
    public decimal? Workid { get; set; }
    public decimal? Regnum { get; set; }
    public string? Temp { get; set; }
    public string? Deal { get; set; }
    public string? EnDealing { get; set; }
    public string? Banknum { get; set; }
    public string? Bankname { get; set; }
    public string? Bankbranch { get; set; }
    public decimal? Cpu { get; set; }
    public decimal? BranchId { get; set; }
    public Guid Rowguid { get; set; }
}