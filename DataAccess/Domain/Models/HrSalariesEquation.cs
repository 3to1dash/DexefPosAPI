namespace DataAccess.Domain.Models;

public partial class HrSalariesEquation
{
    public decimal Id { get; set; }
    public int? SalaryId { get; set; }
    public int? SubId { get; set; }
    public bool? IsAdd { get; set; }
    public string? AfterIf { get; set; }
    public string? Operand { get; set; }
    public string? AfterOperand { get; set; }
    public string? AfterThen { get; set; }
    public Guid Rowguid { get; set; }
}
