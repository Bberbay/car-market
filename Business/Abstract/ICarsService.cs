using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface ICarsService
{
    IDataResult<Cars> GetById(int carId);
    IDataResult<List<Cars>> GetList();
    IDataResult<List<Cars>> GetListByCategory(int categoryId);
    IResult Add(Cars car);
    IResult Delete(Cars car);
    IResult Update(Cars car);
    // Durumu görmek için result döndürüldü.
}