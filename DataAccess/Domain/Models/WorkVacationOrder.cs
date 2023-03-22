namespace DataAccess.Domain.Models;

public class WorkVacationOrder
{
    public int Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? WorkId { get; set; }
    public int? Type { get; set; }
    public DateTime? FromDt { get; set; }
    public DateTime? ToDt { get; set; }
    public decimal? Period { get; set; }
    public string? Ship { get; set; }
    public string? Note { get; set; }
    public decimal? Branchid { get; set; }
    public string? WrittenBy { get; set; }
    public bool? HasDiscount { get; set; }
    public decimal? Answer { get; set; }
    public string? AnswerNote { get; set; }
    public string? AnswerBy { get; set; }
    public Guid Rowguid { get; set; }
}
