using Bulucum.DataAccess.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreate;
using Microsoft.Extensions.DependencyInjection;
using Services.Abstract;
using Services.Concreate;
using Services.ExtraMetots.Abstract;
using Services.ExtraMetots.Concreate;
using System.Globalization;
using System.Reflection;


namespace YoutubeBlog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        //public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        //{
        //    var assembly = Assembly.GetExecutingAssembly();

        //    services.AddScoped<ISeekerAuthService, SeekerAuthManager>();
        //    services.AddScoped<ISeekerDal, EfSeekerDal>();
        //    services.AddScoped<IFinderService, FinderManager>();
        //    services.AddScoped<IFinderDal, EfFinderDal>();
        //    services.AddScoped<IAuthDalForSeeker, AuthDalForSeeker>();
        //    services.AddScoped<ISeekerAuthService, SeekerAuthManager>();
        //    services.AddScoped<IUnitOfWork, UnitOfWork>();
        //    services.AddScoped<ITcKimlikService, TcKimlikManager>();
        //    services.AddScoped<IExtraMetot, ConvertToPassword>(); 
        //    return services;
        //}
    }
}
