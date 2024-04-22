using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using MohamedRefaat_TechnicalTest.Application.AutoMapper;
using MohamedRefaat_TechnicalTest.Application.Interfaces;
using MohamedRefaat_TechnicalTest.Application.Services;
using MohamedRefaat_TechnicalTest.Domain.IRepository;
using MohamedRefaat_TechnicalTest.Infra.Data.Context;
using MohamedRefaat_TechnicalTest.Infra.Data.Repository;
using PanMedica.Application.AutoMapper;

namespace MohamedRefaat_TechnicalTest.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer 
            services.AddTransient<ISuperheroService, SuperheroService>();            

            //Infra Layer
           
            services.AddScoped<ApplicationDbContext>();
            services.AddTransient(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
        }

      
    }
}
