namespace DXPOS.DTOs;

public class CompanyDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Field { get; set; }
    public string Phone { get; set; }
    public string ArCurrency { get; set; }
    public string EnCurrency { get; set; }
    public IEnumerable<BranchDto> Branches { get; set; }
}