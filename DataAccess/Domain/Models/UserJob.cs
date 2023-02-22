namespace DataAccess.Domain.Models;

public partial class UserJob
{
    public UserJob()
    {
        Users = new HashSet<User>();
    }

    public int Id { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public int? ParentId { get; set; }
    public string? Note { get; set; }
    public bool? Active { get; set; }

    public virtual ICollection<User> Users { get; set; }
}
