namespace DataAccess.Domain.Models;

public class RsdBillMapping
{
    public int Id { get; set; }
    public decimal? TaskId { get; set; }
    public string? Dealing { get; set; }
    public string? NotificationId { get; set; }
    public int? UserId { get; set; }
    public string? DoctorId { get; set; }
    public string? Patientnationalid { get; set; }
    public string? Prescriptiondate { get; set; }
    public string? Gtn { get; set; }
    public string? Status { get; set; }
    public DateTime? UploadDt { get; set; }
}
