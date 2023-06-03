using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract;

public interface IUsersService
{
    IDataResult<Users> GetById(int userId);
    IDataResult<List<Users>> GetList();
    IDataResult<List<Users>> GetListByName(string name);
    IResult Add(UserAddDto user);
    IResult Delete(Users id);
    IResult Update(Users user);
    
}