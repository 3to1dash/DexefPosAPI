namespace DataAccess.Domain.Models;

public partial class YearFinancialRole
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public int? OpenStatus { get; set; }
    public int? PeriodId { get; set; }
    public int? RoleId { get; set; }
    public string? UseAdd { get; set; }
    public string? UseEdit { get; set; }
    public string? UseDelete { get; set; }
    public string? UsePrint { get; set; }
    public int? AddDays { get; set; }
    public int? EditDays { get; set; }
    public int? DeleteDays { get; set; }
    public int? PrintDays { get; set; }
    public bool? Active { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? Dt { get; set; }

    public virtual YearFinancial? Period { get; set; }
}
