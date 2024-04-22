using AutoMapper;
using MohamedRefaat_TechnicalTest.Application.DTOs;
using MohamedRefaat_TechnicalTest.Domain.Models;
using System.Globalization;

namespace PanMedica.Application.AutoMapper
{
    public class DTOsToDomainProfile : Profile
    {
        public DTOsToDomainProfile()
        {
            CreateMap<AppearanceDto, Appearance>();

            CreateMap<BiographyDto, Biography>();
            CreateMap<ConnectionsDto, Connections>();
            CreateMap<ImageDto, Image>();
            CreateMap<PowerStatsDto, PowerStats>();           
            CreateMap<WorkDto, Work>();
            CreateMap<SuperheroDto, Superhero>();
            CreateMap<GetSuperherosDto, SuperheroDto>();



        }

    }
}
