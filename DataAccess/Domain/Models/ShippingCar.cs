namespace DataAccess.Domain.Models;

public class ShippingCar
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public string? CarType { get; set; }
    public string? ChasesaNum { get; set; }
    public string? MotorNum { get; set; }
    public string? LicenseNum { get; set; }
    public DateTime? LicenseDt { get; set; }
    public DateTime? LicenseDtEnd { get; set; }
    public string? Model { get; set; }
    public string? Description { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdateBy { get; set; }
    public int? FuelId { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
}
