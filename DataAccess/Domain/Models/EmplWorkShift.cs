namespace DataAccess.Domain.Models;

public partial class EmplWorkShift
{
    public int Id { get; set; }
    public int? EmplId { get; set; }
    public int? ShiftId { get; set; }
    public Guid Rowguid { get; set; }
}
