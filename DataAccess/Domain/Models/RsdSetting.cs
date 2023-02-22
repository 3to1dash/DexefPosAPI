namespace DataAccess.Domain.Models;

public partial class RsdSetting
{
    public int Id { get; set; }
    public int? PrescriptionId { get; set; }
    public int? PrescriptionDt { get; set; }
    public int? UserId { get; set; }
}
