namespace DXPOS.DTOs;

public class BranchDto
{
    public int Id { get; set; }
    public string Num { get; set; }
    public string Name { get; set; }
    public IEnumerable<StoreDto> Stores { get; set; }
}