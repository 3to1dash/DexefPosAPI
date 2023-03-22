namespace DataAccess.Domain.Models;

public class HrTrainingCourse
{
    public int Id { get; set; }
    public int? EmplId { get; set; }
    public string? Company { get; set; }
    public int? CourseId { get; set; }
    public string? Specialization { get; set; }
    public string? Gpa { get; set; }
    public DateTime? DtStart { get; set; }
    public DateTime? DtEnd { get; set; }
    public string? Note { get; set; }
}
