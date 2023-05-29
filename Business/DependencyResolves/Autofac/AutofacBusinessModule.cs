using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolves.Autofac;

public class AutofacBusinessModule: Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<CarsManager>().As<ICarsService>();
        builder.RegisterType<EfCarsDal>().As<ICarsDal>();
    }
}