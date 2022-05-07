using AutoMapper;
using FilmesAPI.Models;
using FilmesAPI.Data.DTO.GerenteDto;

namespace FilmesAPI.DependencyInjection
{
    public class GerenteProfile : Profile
    {
        public GerenteProfile()
        {
            CreateMap<CreateGerenteDto, Gerente>();
            CreateMap<Gerente, ReadGerenteDto>();
        }
    }
}