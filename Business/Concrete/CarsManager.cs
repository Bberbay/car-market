using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CarsManager:ICarsService
{
    private ICarsDal _carsDal;
    // ef bağımlılık azalması için dependency
    public CarsManager(ICarsDal carsDal)
    {
        _carsDal = carsDal;
    }
    public Cars GetById(int carId)
    {
        return _carsDal.Get(c => c.CarId == carId);
    }

    public List<Cars> GetList()
    {
        return _carsDal.GetList().ToList();
    }

    public List<Cars> GetListByCategory(int categoryId)
    {
        return _carsDal.GetList(c => c.CategoryId == categoryId).ToList();
    }

    public void Add(Cars car)
    {
        //validation
        _carsDal.Add(car);
    }

    public void Delete(Cars car)
    {
        _carsDal.Delete(car);
    }

    public void Update(Cars car)
    {
        _carsDal.Update(car);
    }
}