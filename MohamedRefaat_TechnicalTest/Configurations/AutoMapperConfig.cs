using MohamedRefaat_TechnicalTest.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace MohamedRefaat_TechnicalTest.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MohamedRefaat_TechnicalTest.Application.AutoMapper.AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappings();
        }
    }
}
