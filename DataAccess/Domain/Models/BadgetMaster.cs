namespace DataAccess.Domain.Models;

public partial class BadgetMaster
{
    public int Id { get; set; }
    public int? Code { get; set; }
    public string? Name { get; set; }
    public int? BranchId { get; set; }
    public DateTime Dtstart { get; set; }
    public int? Days { get; set; }
    public int? Period { get; set; }
    public DateTime? ToDt { get; set; }
    public bool? IsautoPeriod { get; set; }
    public bool? IseditExpectedValue { get; set; }
    public int? ValueExceedsindex { get; set; }
}
