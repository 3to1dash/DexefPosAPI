namespace DataAccess.Domain.Models;

public class TripHome
{
    public decimal? Id { get; set; }
    public string? Status { get; set; }
    public string? Memo { get; set; }
    public decimal? OrginalTicket { get; set; }
    public DateTime? IssueDate { get; set; }
    public string? TcnNumber { get; set; }
    public string? TicketNumber { get; set; }
    public string? CarrierCode { get; set; }
    public string? FlightNumber { get; set; }
    public string? ClassOfSeervice { get; set; }
    public int? SegmentCount { get; set; }
    public string? Routes { get; set; }
    public string? RoutesTime { get; set; }
    public string? ArrCity { get; set; }
    public string? ArrDt { get; set; }
    public string? ArrTime { get; set; }
    public string? ArrTreminal { get; set; }
    public string? ArrGate { get; set; }
    public string? DepCity { get; set; }
    public string? DepDt { get; set; }
    public string? DepTime { get; set; }
    public string? DepTreminal { get; set; }
    public string? DepGate { get; set; }
    public string? LocalCurrency { get; set; }
    public string? LocalAmount { get; set; }
    public decimal? Fare { get; set; }
    public string? Tx1Sign { get; set; }
    public string? Tx1Name { get; set; }
    public string? Tx1 { get; set; }
    public string? Tx2Sign { get; set; }
    public string? Tx2Name { get; set; }
    public string? Tx2 { get; set; }
    public string? Tx3Sign { get; set; }
    public string? Tx3Name { get; set; }
    public string? Tx3 { get; set; }
    public decimal? TotalTax { get; set; }
    public decimal? CommisionPerc { get; set; }
    public decimal? Commision { get; set; }
    public string? Total { get; set; }
    public string? PassType { get; set; }
    public string? PassName { get; set; }
    public string? PassPhone { get; set; }
    public string? PassMail { get; set; }
    public string? NetCurrency { get; set; }
    public decimal? NetAmount { get; set; }
    public string? UserCode { get; set; }
    public string? FileName { get; set; }
    public string? Pnr { get; set; }
    public decimal? CancelFees { get; set; }
    public string? Ttype { get; set; }
    public Guid Rowguid { get; set; }
}
