namespace DataAccess.Domain.Models;

public partial class HrTimeOffPolicyEntry
{
    public long Id { get; set; }
    public int? PolicyId { get; set; }
    public int? TimeOffId { get; set; }
}
