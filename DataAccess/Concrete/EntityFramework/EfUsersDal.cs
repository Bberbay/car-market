using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using DataAccess.Concrete;
namespace DataAccess.Concrete.EntityFramework;

public class EfUsersDal : EfEntityRepositoryBase<Users,CarMarketContext>,IUsersDal
{
}