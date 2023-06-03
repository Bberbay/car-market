using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete;

public class UsersManager: IUsersService
{
    private IUsersDal _usersDal;

    public UsersManager(IUsersDal usersDal)
    {
        _usersDal = usersDal;
    }
    public IDataResult<Users> GetById(int userId)
    {
        try
        {
            return new SuccessDataResult<Users>(_usersDal.Get(u => u.Id == userId));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public IDataResult<List<Users>> GetList()
    {
        return new SuccessDataResult<List<Users>>(_usersDal.GetList().ToList());
    }

    public IDataResult<List<Users>> GetListByName(string name)
    {
        return new SuccessDataResult<List<Users>>(_usersDal.GetList(u => u.Name == name).ToList());
    }

    public IResult Add(UserAddDto user)
    {
        Users users = new Users()
        {
            Name = user.Name,
            Password = user.Password,
        };
        _usersDal.Add(users);
        return new SuccessResult(true, Messages.UserAddedMsg);
    }

    public IResult Delete(Users id)
    {
        return new SuccessResult(true, Messages.UserDeletedMsg);
    }

    public IResult Update(Users user)
    {
        return new SuccessResult(true, Messages.UserUpdatedMsg);
    }
}