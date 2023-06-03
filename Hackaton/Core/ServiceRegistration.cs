using Hackaton.DAL.Abstract;
using Hackaton.DAL.Concrete;
using System.Runtime.CompilerServices;

namespace Hackaton.Core
{
    public static class ServiceRegistration
    {
        public static void AddRegister(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Program));
            services.AddScoped<IUserAppDal, UserAppDal>();
            services.AddScoped<IClassDateDal, ClassDateDal>();
            services.AddScoped<IRoleAppDal, RoleAppDal>();
            services.AddScoped<ITheClassDal, TheClassDal>();
            services.AddScoped<IUserStatusDal, UserStatusDall>();
        }
    }
}
