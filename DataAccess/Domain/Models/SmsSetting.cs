namespace DataAccess.Domain.Models;

public partial class SmsSetting
{
    public int Id { get; set; }
    public int? Smsid { get; set; }
    public int? CustPhoneIndex { get; set; }
    public int? Timer { get; set; }
}
