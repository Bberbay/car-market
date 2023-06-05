using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.DependencyResolves.Autofac;

public class AutofacBusinessModule: Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<CarsManager>().As<ICarsService>();
        builder.RegisterType<EfCarsDal>().As<ICarsDal>();
        builder.RegisterType<UsersManager>().As<IUsersService>();
        builder.RegisterType<EfUsersDal>().As<IUsersDal>();
        builder.RegisterType<PropertiesManager>().As<ICarPropertiesService>();
        builder.RegisterType<EfCarPropertiesDal>().As<ICarPropertiesDal>();
    }
}