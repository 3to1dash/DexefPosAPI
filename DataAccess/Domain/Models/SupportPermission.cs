namespace DataAccess.Domain.Models;

public partial class SupportPermission
{
    public decimal Id { get; set; }
    public decimal? Workid { get; set; }
    public string? UserName { get; set; }
    public decimal? ProblemId { get; set; }
    public Guid Rowguid { get; set; }
}
