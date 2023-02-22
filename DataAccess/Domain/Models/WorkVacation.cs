namespace DataAccess.Domain.Models;

public partial class WorkVacation
{
    public int Id { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public int? EmplId { get; set; }
    public string? RequestNumber { get; set; }
    public int? TimeOffId { get; set; }
    public DateTime? FromDt { get; set; }
    public DateTime? ToDt { get; set; }
    public decimal? Period { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public bool? Attach { get; set; }
    public Guid Rowguid { get; set; }
}
