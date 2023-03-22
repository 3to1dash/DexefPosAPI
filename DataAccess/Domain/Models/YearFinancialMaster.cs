namespace DataAccess.Domain.Models;

public class YearFinancialMaster
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime? FromDt { get; set; }
    public DateTime? ToDt { get; set; }
    public int? Days { get; set; }
    public int? Period { get; set; }
    public bool? AutoClose { get; set; }
    public int? ArchiveDays { get; set; }
    public int? SalesCloseDays { get; set; }
    public string? Password { get; set; }
    public int? UpdateAfterCloseDays { get; set; }

    public virtual List<YearFinancial> YearFinancials { get; set; }
}
