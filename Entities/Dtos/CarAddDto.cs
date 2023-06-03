namespace Entities.Dtos;

public class CarAddDto
{
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public int Year { get; set; }
    public int UserId { get; set; }
}