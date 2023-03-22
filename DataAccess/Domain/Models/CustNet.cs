namespace DataAccess.Domain.Models;

public class CustNet
{
    public decimal Id { get; set; }
    public long? CustId { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public string? WelcomeName { get; set; }
    public bool? Active { get; set; }
    public bool? ConfirmedTicket { get; set; }
    public bool? UnConfirmedTicket { get; set; }
    public bool? FinancialStatment { get; set; }
    public bool? AskCorrectTicket { get; set; }
    public bool? MakeAttatch { get; set; }
    public bool? Stockvalue { get; set; }
    public bool? Stockprice { get; set; }
    public bool? Ourtalab { get; set; }
    public bool? Credit { get; set; }
    public bool? Editinfo { get; set; }
    public bool? Sendnote { get; set; }
    public bool? Maketalab { get; set; }
    public decimal? Talabnum { get; set; }
    public Guid Rowguid { get; set; }
    public bool? IsRwafiOfficer { get; set; }
    public string? SafeNumber { get; set; }
    public string? PassWeb { get; set; }
}
