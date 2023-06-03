using Core.Entities;

namespace Entities.Concrete;

public class Cars:IEntity
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public int Year { get; set; }
    public int UsersId { get; set; }
    public virtual Users Users { get; set; }
}