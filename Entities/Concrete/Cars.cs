using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Entities.Concrete;

public class Cars:IEntity
{
    public string Title { get; set; }
    public int Id { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public int Year { get; set; }
    public int UsersId { get; set; }
    public virtual Users Users { get; set; }
    
    public int CarPropertiesId { get; set; }
    [ForeignKey("CarPropertiesId")]
    public virtual CarProperties CarProperties { get; set; }
}