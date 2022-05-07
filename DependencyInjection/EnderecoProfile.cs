using AutoMapper;
using FilmesAPI.Models;
using FilmesAPI.Data.DTO.EnderecoDto;

namespace FilmesAPI.DependencyInjection
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
    }
}