using System.Runtime.CompilerServices;

namespace Hackaton.Core
{
    public static class ServiceRegistration
    {
        public static void AddRegister(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Program));
        }
    }
}
