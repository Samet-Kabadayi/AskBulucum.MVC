using Autofac;
using Bulucum.DataAccess.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreate;
using Services.Abstract;
using Services.Concreate;
using Services.ExtraMetots.Abstract;
using Services.ExtraMetots.Concreate;

namespace Services.DependencyResolvers.AutoFac
{
    public class AutoFacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //seeker servis isteyene seekermanager ver          
            builder.RegisterType<SeekerManager>().As<ISeekerService>().SingleInstance();
            builder.RegisterType<EfSeekerDal>().As<ISeekerDal>().SingleInstance();
        

            builder.RegisterType<FinderManager>().As<IFinderService>().SingleInstance();
            builder.RegisterType<EfFinderDal>().As<IFinderDal>().SingleInstance();

            //builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().SingleInstance();

            builder.RegisterType<AuthDalForSeeker>().As<IAuthDalForSeeker>().SingleInstance();
            builder.RegisterType<SeekerAuthManager>().As<ISeekerAuthService>().SingleInstance();              

            builder.RegisterType<TcKimlikManager>().As<ITcKimlikService>().SingleInstance();

            builder.RegisterType<ConvertToPassword>().As<IExtraMetot>().SingleInstance();
            //builder.RegisterType<SeekerAuthManager>().As<ISeekerDal>().SingleInstance();
        }
    }
}
