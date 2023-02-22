namespace DataAccess.Domain.Models;

public partial class AccountOperand
{
    public string Operand { get; set; } = null!;
    public int? AccountId { get; set; }
    public Guid Rowguid { get; set; }
}
