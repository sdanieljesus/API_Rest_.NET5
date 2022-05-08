using AutoMapper;
using FilmesAPI.Models;
using FilmesAPI.Data.DTO.GerenteDto;
using System.Linq;

namespace FilmesAPI.DependencyInjection
{
    public class GerenteProfile : Profile
    {
        public GerenteProfile()
        {
            CreateMap<CreateGerenteDto, Gerente>();
            CreateMap<Gerente, ReadGerenteDto>()
                .ForMember(gerente => gerente.Cinemas, opts => opts
                .MapFrom(gerente => gerente.Cinemas.Select
                (c => new {c.Id, c.Nome, c.Endereco, c.EnderecoId})));
        }
    }
}