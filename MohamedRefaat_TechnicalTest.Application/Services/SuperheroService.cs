using AutoMapper;
using LinqKit;
using MohamedRefaat_TechnicalTest.Application.DTOs;
using MohamedRefaat_TechnicalTest.Application.Interfaces;
using MohamedRefaat_TechnicalTest.Application.ServiceQueryParams;
using MohamedRefaat_TechnicalTest.Domain.Helper;
using MohamedRefaat_TechnicalTest.Domain.IRepository;
using MohamedRefaat_TechnicalTest.Domain.Models;
using MohamedRefaat_TechnicalTest.Domain.Models.Paging;
using System.Reflection;

namespace MohamedRefaat_TechnicalTest.Application.Services
{
    public class SuperheroService : ISuperheroService
    {
        private readonly IUnitOfWork<Superhero> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly HttpClient _httpClient;
       
        public SuperheroService(IUnitOfWork<Superhero> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _httpClient = new HttpClient();
           
        }

        public async Task<ServiceResponse<SuperheroDto>> AddAsync(SuperheroDto dtoReq)
        {
            try
            {
                var EntityForAdd = _mapper.Map<Superhero>(dtoReq);
                await _unitOfWork.Repository.AddAsync(EntityForAdd);
                if (await _unitOfWork.CommitAsync())
                {
                    var mappedResponse = _mapper.Map<SuperheroDto>(EntityForAdd);
                    return ServiceResponse<SuperheroDto>.Created(mappedResponse, $"Superhero Created Successfully with Id {EntityForAdd.Id}");
                }
                else
                    return ServiceResponse<SuperheroDto>.Fail();
            }
            catch (Exception ex)
            {
                var data =ex.Message;
            }
            return null;
        }

      


        public async Task<string> SearchSuperhero(string superheroName)
        {
            string apiUrl = $"https://superheroapi.com/api/10223345425719740/search/"+superheroName+"";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    Console.WriteLine("Failed to fetch data. Status code: " + response.StatusCode);
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return null;
            }
        }




     


    }
}