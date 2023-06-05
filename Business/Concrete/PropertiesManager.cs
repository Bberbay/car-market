using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete;

public class PropertiesManager: ICarPropertiesService
{
    private ICarPropertiesDal _carPropertiesDal;

    public PropertiesManager(ICarPropertiesDal carPropertiesDal)
    {
        _carPropertiesDal = carPropertiesDal;
    }
    public IDataResult<CarProperties> GetById(int carId)
    {
        try
        {
            return new SuccessDataResult<CarProperties>(_carPropertiesDal.Get(c => c.Id == carId));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public IDataResult<List<CarProperties>> GetList()
    {
        try
        {
            return new SuccessDataResult<List<CarProperties>>(_carPropertiesDal.GetList().ToList());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    public IResult Add(CarPropertyAddDto carPropertyAddDto )
    {
        CarProperties carProperty = new CarProperties()
        {
            Id = carPropertyAddDto.Id,
            Color = carPropertyAddDto.Color,
            FuelType = carPropertyAddDto.FuelType,
            Gear = carPropertyAddDto.Gear,
            EnginePower = carPropertyAddDto.EnginePower,
            EngineCapacity = carPropertyAddDto.EngineCapacity,
            HeadlampFog = carPropertyAddDto.HeadlampFog,
            FoldingMirros = carPropertyAddDto.FoldingMirros,
            ParkingSensor = carPropertyAddDto.ParkingSensor,
            CentralLock = carPropertyAddDto.CentralLock,
            SunRoof = carPropertyAddDto.SunRoof
        };
            _carPropertiesDal.Add(carProperty);
            return new SuccessResult(true, message: "Özellikler Eklendi");
    }


}