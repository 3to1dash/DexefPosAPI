namespace DataAccess.Domain.Models;

public class EmplWorkShift
{
    public int Id { get; set; }
    public int? EmplId { get; set; }
    public int? ShiftId { get; set; }
    public Guid Rowguid { get; set; }
}