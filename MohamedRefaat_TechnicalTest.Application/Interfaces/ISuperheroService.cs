using MohamedRefaat_TechnicalTest.Application.DTOs;
using MohamedRefaat_TechnicalTest.Application.ServiceQueryParams;
using MohamedRefaat_TechnicalTest.Domain.Helper;
using MohamedRefaat_TechnicalTest.Domain.Models;
using MohamedRefaat_TechnicalTest.Domain.Models.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamedRefaat_TechnicalTest.Application.Interfaces
{
    public interface ISuperheroService
    {
        Task<ServiceResponse<SuperheroDto>> AddAsync(SuperheroDto dtoReq);

        Task<string> SearchSuperhero(string superheroName);
    }
}
