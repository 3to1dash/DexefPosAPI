namespace DataAccess.Domain.Models;

public class SalariesWork
{
    public decimal Id { get; set; }
    public decimal? WorkId { get; set; }
    public decimal? SalaryId { get; set; }
    public decimal? Salary { get; set; }
    public bool? IsAdd { get; set; }
    public decimal? FixedSalary { get; set; }
    public decimal? CalcType { get; set; }
    public Guid Rowguid { get; set; }
}
