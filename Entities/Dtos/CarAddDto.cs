namespace Entities.Dtos;

public class CarAddDto
{
    public string Title { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public int Year { get; set; }
    public int UserId { get; set; }
    
    public int CarPropertiesId { get; set; }
}