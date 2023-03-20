using System.Text.Json.Serialization;

namespace DXPOS.DTOs;

public class UserDto
{
    [JsonPropertyName("passward")]
    public string Password { get; set; }
    [JsonPropertyName("serial_number")]
    public string SerialNumber { get; set; }
    [JsonPropertyName("usertype")]
    public string UserType { get; set; }
    [JsonPropertyName("ShowMyReportOnly")]
    public bool ShowMyReportOnly { get; set; }
    [JsonPropertyName("Permission")]
    public string Permission { get; set; }
    [JsonPropertyName("privilegeID")]
    public int? PrivilegeID { get; set; }
    [JsonPropertyName("BranchID")]
    public int? BranchID { get; set; }
}
