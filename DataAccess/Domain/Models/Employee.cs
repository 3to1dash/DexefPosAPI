namespace DataAccess.Domain.Models;

public class Employee
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public string? Num { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public string? Status { get; set; }
    public DateTime? Dt { get; set; }
    public string? Mob1 { get; set; }
    public string? Mob2 { get; set; }
    public string? Mail { get; set; }
    public string? Address { get; set; }
    public string? Sex { get; set; }
    public int? DepartmentId { get; set; }
    public int? JobId { get; set; }
    public int? NationalityId { get; set; }
    public int? MaritalStatusId { get; set; }
    public int? BloodTypeId { get; set; }
    public int? FacultyId { get; set; }
    public int? GraduationYear { get; set; }
    public decimal? Salary { get; set; }
    public decimal? ChangedSalary { get; set; }
    public decimal? Insurances { get; set; }
    public decimal? Taxes { get; set; }
    public decimal? AnnualIncrease { get; set; }
    public string? FingerPrintNumber { get; set; }
    public bool? Attach { get; set; }
    public string? HiringStatus { get; set; }
    public string? Writtenby { get; set; }
}