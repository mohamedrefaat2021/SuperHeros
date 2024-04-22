using AutoMapper;
using MohamedRefaat_TechnicalTest.Application.DTOs;
using MohamedRefaat_TechnicalTest.Domain.Models;
using MohamedRefaat_TechnicalTest.Domain.Models.Paging;

namespace MohamedRefaat_TechnicalTest.Application.AutoMapper
{
    public class DomainToDTOsProfile : Profile
    {
        public DomainToDTOsProfile()
        {


            CreateMap<Appearance, AppearanceDto>();
            CreateMap<Biography, BiographyDto>();
            CreateMap<Connections, ConnectionsDto>();
            CreateMap<Image, ImageDto>();
            CreateMap<PowerStats, PowerStatsDto>();
           // CreateMap<Superhero, SuperheroDto>();
            CreateMap<Work, WorkDto>();

            CreateMap<Superhero, SuperheroDto>();

            CreateMap<SuperheroDto, GetSuperherosDto>()
           .ForMember(dest => dest.response, opt => opt.MapFrom(src => "success")) // Assuming response is always "success"
           .ForMember(dest => dest.results_for, opt => opt.MapFrom(src => "batman")) // Assuming results_for is always "batman"
           .ForMember(dest => dest.results, opt => opt.MapFrom(hero => new SuperheroDto 
           {
               
               name = hero.name,
               powerstats = hero.powerstats,
               biography = hero.biography,
               appearance = hero.appearance,
               work = hero.work,
               connections = hero.connections,
               image = hero.image
           }));

            CreateMap(typeof(PagedListResponse<>), typeof(PagedListResponse<>));
          

        }


   

    }
}
