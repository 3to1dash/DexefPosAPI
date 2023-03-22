namespace DataAccess.Domain.Models;

public class CurrentPc
{
    public int Id { get; set; }
    public int? Pcnumber { get; set; }
    public string? PcName { get; set; }
    public string? Sn { get; set; }
    public int? BranchId { get; set; }
    public int? DefaultStorage { get; set; }
    public int? DefaultBank { get; set; }
    public int? DefaultVisa { get; set; }
    public int? DefaultPledge { get; set; }
    public string? Username { get; set; }
    public Guid Rowguid { get; set; }
    public int? ReportTemplateId { get; set; }
}
