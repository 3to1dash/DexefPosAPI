namespace DataAccess.Domain.Models;

public partial class HrSkill
{
    public int Id { get; set; }
    public int? EmplId { get; set; }
    public int? SkillId { get; set; }
    public int? Rating { get; set; }
}
