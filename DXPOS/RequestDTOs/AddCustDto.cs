namespace DXPOS.RequestDTOs;

public class AddCustDto
{
    public int branchID { get; set; }
    public string name { get; set; }
    public string num { get; set; }
    public string phone { get; set; }
    public string mail { get; set; }
    public string address { get; set; }
    public decimal creditLimit { get; set; }
    public string taxFile { get; set; }
    public string currency { get; set; }
    public int cpu { get; set; }
    public string writtenBy { get; set; }
}