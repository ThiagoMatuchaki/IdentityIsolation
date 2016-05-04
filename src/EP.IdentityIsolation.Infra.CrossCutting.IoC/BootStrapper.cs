using EP.IdentityIsolation.Domain.Interface.Repository;
using EP.IdentityIsolation.Infra.CrossCutting.Identity.Configuration;
using EP.IdentityIsolation.Infra.CrossCutting.Identity.Context;
using EP.IdentityIsolation.Infra.CrossCutting.Identity.Model;
using EP.IdentityIsolation.Infra.Data.Repository;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleInjector;

namespace EP.IdentityIsolation.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.Register<ApplicationDbContext>();
            container.Register<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()));
            container.Register<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>());
            container.Register<ApplicationRoleManager>();
            container.Register<ApplicationUserManager>();
            container.Register<ApplicationSignInManager>();
            container.Register<IUsuarioRepository, UsuarioRepository>();
        } 
    }
}