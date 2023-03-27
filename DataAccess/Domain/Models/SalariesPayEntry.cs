namespace DataAccess.Domain.Models;

public class SalariesPayEntry
{
    public decimal Id { get; set; }
    public decimal? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? Addition { get; set; }
    public decimal? Deduction { get; set; }
    public decimal? SalaryId { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? Ipay { get; set; }
    public decimal? Iaccount { get; set; }
    public decimal? WorkId { get; set; }
    public decimal? CalcId { get; set; }
    public Guid Rowguid { get; set; }
}