using System.Text.Json.Serialization;

namespace DXPOS.ResponseDTOs;

public class UserDto
{
    [JsonPropertyName("Companies")]
    public IEnumerable<CompanyDto> Companies { get; set; }
    [JsonPropertyName("Permissions")]
    public IEnumerable<UserPermissionDto> Permissions { get; set; }

}