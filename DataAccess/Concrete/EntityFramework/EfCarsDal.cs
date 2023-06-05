using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class EfCarsDal: EfEntityRepositoryBase<Cars,CarMarketContext>,ICarsDal
{
    public IList<Cars> GetListWithProp()
    {
        using (var context = new CarMarketContext())
        {
            var result = context.Cars.Include(o => o.CarProperties).ToList();
            return result;
        }
    }
}