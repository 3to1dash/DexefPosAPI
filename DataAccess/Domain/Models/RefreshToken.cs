namespace DataAccess.Domain.Models;

public partial class RefreshToken
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public string Jti { get; set; } = null!;
    public string Token { get; set; } = null!;
    public DateTime ExpireDate { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
}
