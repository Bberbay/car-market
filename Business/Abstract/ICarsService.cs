using Entities.Concrete;

namespace Business.Abstract;

public interface ICarsService
{
    Cars GetById(int carId);
    List<Cars> GetList();
    List<Cars> GetListByCategory(int categoryId);
    void Add(Cars car);
    void Delete(Cars car);
    void Update(Cars car);
}