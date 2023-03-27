namespace DataAccess.Domain.Models;

public class DailySalary
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? WorkId { get; set; }
    public bool? Done { get; set; }
    public string? Dealing { get; set; }
    public decimal? BaseSalary { get; set; }
    public decimal? Aword { get; set; }
    public decimal? Extra { get; set; }
    public decimal? Product { get; set; }
    public decimal? Badl { get; set; }
    public decimal? OtherIn { get; set; }
    public decimal? Solfa { get; set; }
    public decimal? Insurance { get; set; }
    public decimal? Tax { get; set; }
    public decimal? Discount { get; set; }
    public decimal? Absent { get; set; }
    public decimal? OtherOut { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? SalaryId { get; set; }
    public Guid Rowguid { get; set; }
}