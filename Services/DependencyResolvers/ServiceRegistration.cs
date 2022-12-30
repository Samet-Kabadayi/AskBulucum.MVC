using Bulucum.DataAccess.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreate;
using Microsoft.Extensions.DependencyInjection;
using Services.Abstract;
using Services.Concreate;
using Services.ExtraMetots.Abstract;
using Services.ExtraMetots.Concreate;


namespace Services.DependencyResolvers
{
    public static class ServiceRegistration
    {
        public static void AddServiceRegister(this IServiceCollection services)
        {
            services.AddTransient<ISeekerService, SeekerManager>();
            services.AddScoped<ISeekerDal, EfSeekerDal>();
            services.AddScoped<IFinderService, FinderManager>();
            services.AddScoped<IFinderDal, EfFinderDal>();
            services.AddScoped<IAuthDalForSeeker, AuthDalForSeeker>();
            services.AddScoped<ISeekerAuthService, SeekerAuthManager>();
            services.AddScoped<ITcKimlikService, TcKimlikManager>();
            services.AddScoped<IExtraMetot, ConvertToPassword>();
            
        }
    }
}
