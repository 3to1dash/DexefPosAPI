namespace DataAccess.Domain.Models;

public partial class WooCustomerMapper
{
    public int Id { get; set; }
    public int? RemoteId { get; set; }
    public int? LocalId { get; set; }
    public string? RemoteState { get; set; }
}
