namespace DataAccess.Domain.Models;

public class HrTimeOffAgendaEntry
{
    public int Id { get; set; }
    public int? AgendaId { get; set; }
    public int? TimeOffId { get; set; }
    public DateTime? FromDate { get; set; }
    public DateTime? Todate { get; set; }
}