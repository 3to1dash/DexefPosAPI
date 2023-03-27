namespace DataAccess.Domain.Models;

public class ResTable
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? Num { get; set; }
    public int? FloorId { get; set; }
    public int? Capacity { get; set; }
    public bool? IsActive { get; set; }
    public string? ImgIndex { get; set; }
    public string? Note { get; set; }
    public int? DepartmentId { get; set; }
    public byte? Status { get; set; }
}