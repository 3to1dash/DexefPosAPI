namespace DataAccess.Domain.Models;

public partial class Sm
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Api { get; set; }
    public string? Apibalance { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public bool? SendMethod { get; set; }
    public bool? BalanceMethod { get; set; }
    public string? SuccessfullyCode { get; set; }
    public bool? Issdk { get; set; }
}
