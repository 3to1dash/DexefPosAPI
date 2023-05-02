namespace DataAccess.Domain.Models;

public class SupportTicket
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public bool? IsCust { get; set; }
    public decimal? CustId { get; set; }
    public string? Phone1 { get; set; }
    public string? Phone2 { get; set; }
    public decimal? PriorityId { get; set; }
    public decimal? StatusId { get; set; }
    public decimal? ProblemId { get; set; }
    public decimal? ProductId { get; set; }
    public decimal? CallId { get; set; }
    public string? Subject { get; set; }
    public string? Note { get; set; }
    public DateTime? StartTime { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? AnswerTime { get; set; }
    public string? AnswerUser { get; set; }
    public decimal? AnswerPeriod { get; set; }
    public string? AnswerShip { get; set; }
    public decimal? BranchId { get; set; }
    public string? ToMe { get; set; }
    public bool? HasAlarm { get; set; }
    public DateTime? AlarmDt { get; set; }
    public string? Txt { get; set; }
    public string? Txt1 { get; set; }
    public string? Txt2 { get; set; }
    public string? Txt3 { get; set; }
    public string? Txt4 { get; set; }
    public string? Txt5 { get; set; }
    public string? Txt6 { get; set; }
    public string? Txt7 { get; set; }
    public string? Txt8 { get; set; }
    public decimal? TaskId { get; set; }
    public string? Ship { get; set; }
    public Guid Rowguid { get; set; }
}