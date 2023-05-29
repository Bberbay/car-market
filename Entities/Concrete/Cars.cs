using Core.Entities;

namespace Entities.Concrete;

public class Cars:IEntity
{
    public int CarId { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public int Year { get; set; }
    public int OwnerId { get; set; }
}