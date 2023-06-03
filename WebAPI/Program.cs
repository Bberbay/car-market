using System.Data.Common;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolves.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Dependency;


var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddDbContext<CarMarketContext>(x =>
// {
//     AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
// });
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICarsService, CarsManager>();
builder.Services.AddScoped< ICarsDal,EfCarsDal>();
builder.Services.AddScoped<IUsersService, UsersManager>();
builder.Services.AddScoped<IUsersDal, EfUsersDal>();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// static IHostBuilder CreateHostBuilder(string[] args) =>
//     Host.CreateDefaultBuilder(args)
//         .UseServiceProviderFactory(new AutofacServiceProviderFactory())
//         .ConfigureWebHostDefaults(webBuilder =>
//         {
//             webBuilder.UseStartup<st>();
//         })
//         .ConfigureContainer<ContainerBuilder>(builder =>
//         {
//             builder.RegisterModule(new AutofacBusinessModule());
//         });

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();