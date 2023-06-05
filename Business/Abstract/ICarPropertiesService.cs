using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract;

public interface ICarPropertiesService
{
    IDataResult<CarProperties> GetById(int carPropertiesId);
    IDataResult<List<CarProperties>> GetList();
    IResult Add(CarPropertyAddDto carPropertyAddDto);

}