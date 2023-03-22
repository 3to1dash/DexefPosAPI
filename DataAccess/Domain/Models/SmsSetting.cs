namespace DataAccess.Domain.Models;

public class SmsSetting
{
    public int Id { get; set; }
    public int? Smsid { get; set; }
    public int? CustPhoneIndex { get; set; }
    public int? Timer { get; set; }
}
