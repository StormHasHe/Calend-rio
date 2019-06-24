using Identity.Context;
using SimpleInjector;
using Identity.Repository;
using Services.Services;
using DataAccess.Context;
using DataAccessContracts.Interface.Identity;
using Contracts.Interface.Service;
using DataAccess.Repository;
using DataAccessContracts.Interface.DataAccess;

namespace IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            //DbContexts
            container.Register<AuthenticationContext>(Lifestyle.Scoped);
            container.Register<ApplicationContext>(Lifestyle.Scoped);
            container.Register<MongoContext>(Lifestyle.Singleton);
            
            //Repositories
            container.Register<IAuthRepository, AuthRepository>(Lifestyle.Scoped);
            container.Register<IAulaRepository, AulaRepository>(Lifestyle.Scoped);

            //Services
            container.Register<IAccountService, AccountService>(Lifestyle.Scoped);
            container.Register<IAulaService, AulaService>(Lifestyle.Scoped);
        }
    }
}