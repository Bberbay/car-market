using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Dtos;

namespace Business.Concrete;

public class CarsManager:ICarsService
{
    private ICarsDal _carsDal;

    private ICarPropertiesService _carPropertiesService;

    private ICarPropertiesDal _carPropertiesDal;
    // ef bağımlılık azalması için dependency
    public CarsManager(ICarsDal carsDal)
    {
        _carsDal = carsDal;
    }
    public IDataResult<Cars> GetById(int carId)
    {
        try
        {
            return new SuccessDataResult<Cars>(_carsDal.Get(c => c.Id == carId));
        }
        catch (Exception e)
        {
            return new ErrorDataResult<Cars>(message: "ID'ye Göre Araç Getirme Başarısız !" + e);
        }
        
    }

    public IDataResult<List<Cars>> GetList()
    {
        var cars = _carsDal.GetListWithProp().ToList();
        // foreach (var car in cars)
        // {
        //     car.CarProperties = _carPropertiesService.GetById(car.CarPropertiesId).Data;
        // }

        return new SuccessDataResult<List<Cars>>(cars);

    }

    public IDataResult<List<Cars>> GetListByCategory(int categoryId)
    {
        return new SuccessDataResult<List<Cars>>(_carsDal.GetList(c => c.CategoryId == categoryId).ToList());
    }

    public IResult Add(CarAddDto car)
    { 
        //validation
        Cars cars = new Cars()
        {
            Title = car.Title,
            CategoryId = car.CategoryId,
            Price = car.Price,
            Year = car.Year,
            UsersId = car.UserId,
            CarPropertiesId = car.CarPropertiesId

        };
        _carsDal.Add(cars);
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