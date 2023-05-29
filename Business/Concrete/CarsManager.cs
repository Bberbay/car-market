using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Business.Constants;

namespace Business.Concrete;

public class CarsManager:ICarsService
{
    private ICarsDal _carsDal;
    // ef bağımlılık azalması için dependency
    public CarsManager(ICarsDal carsDal)
    {
        _carsDal = carsDal;
    }
    public IDataResult<Cars> GetById(int carId)
    {
        try
        {
            return new SuccessDataResult<Cars>(_carsDal.Get(c => c.CarId == carId));
        }
        catch (Exception e)
        {
            return new ErrorDataResult<Cars>(message: "ID'ye Göre Araç Getirme Başarısız !" + e);
        }
        
    }

    public IDataResult<List<Cars>> GetList()
    {
        return new SuccessDataResult<List<Cars>>(_carsDal.GetList().ToList());
    }

    public IDataResult<List<Cars>> GetListByCategory(int categoryId)
    {
        return new SuccessDataResult<List<Cars>>(_carsDal.GetList(c => c.CategoryId == categoryId).ToList());
    }

    public IResult Add(Cars car)
    { 
        //validation
        _carsDal.Add(car);
        return new SuccessResult(true,Messages.CarAddedMsg);
    }

    public IResult Delete(Cars car)
    {
        _carsDal.Delete(car);
        return new SuccessResult(true,Messages.CarDeletedMsg);
    }

    public IResult Update(Cars car)
    {
        _carsDal.Update(car);
        return new SuccessResult(false); // TEST AMAÇLI FALSE
    }
}