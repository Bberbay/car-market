using Core.Entities;

namespace Entities.Concrete;

public class Users: IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }

    public virtual ICollection<Cars> Cars { get; set; }

}