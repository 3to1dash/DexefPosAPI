namespace DataAccess.Domain.Models;

public partial class MailSettng
{
    public int Id { get; set; }
    public string? CurrentUser { get; set; }
    public string? SendFrom { get; set; }
    public string? ProviderName { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public int? Port { get; set; }
    public int? AuthenticationType { get; set; }
    public string? ClientCertName { get; set; }
    public bool? ChkSslrequired { get; set; }
    public bool? ChkUseStartTls { get; set; }
    public bool? ChkUseSubmissionPort { get; set; }
    public string? MailServer { get; set; }
    public string? MailDomain { get; set; }
    public Guid Rowguid { get; set; }
}
