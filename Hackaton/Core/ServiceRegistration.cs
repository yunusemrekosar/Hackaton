using Hackaton.Bussines.Abstract;
using Hackaton.Bussines.Concrete;
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
            services.AddScoped<IDepartmentDal, DepartmentDal>();

            services.AddScoped<IUserAppService, UserAppManager>();
            services.AddScoped<IClassDateService, ClassDateManager>();
            services.AddScoped<IRoleAppService, RoleAppManager>();
            services.AddScoped<ITheClassService, TheClassManager>();
            services.AddScoped<IUserStatusService, UserStatusManager>();
            services.AddScoped<IDepartmentService, DepartmentManager>();
        }
    }
}
