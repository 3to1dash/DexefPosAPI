namespace DataAccess.Domain.Models;

public class FoodMeal
{
    public decimal? Id { get; set; }
    public decimal? Parentid { get; set; }
    public decimal? Kindid { get; set; }
    public decimal? Value { get; set; }
    public string? Unite { get; set; }
    public Guid Rowguid { get; set; }
}