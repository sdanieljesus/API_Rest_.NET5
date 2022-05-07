namespace FilmesAPI.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Http;
    using FilmesAPI.Data;
    using AutoMapper;
    using FilmesAPI.Models;
    using FilmesAPI.Data.DTO.EnderecoDto;
    using System.Linq;
    using System.Collections.Generic;

    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class NameController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CreateEnderecoDto))]
        public IActionResult AdicionaEndereco([FromBody] CreateEnderecoDto enderecoDto)
        {
            Endereco endereco = _mapper.Map<Endereco>(enderecoDto);
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ConsultaEnderecoPorId), new {id = endereco.Id}, endereco);
        }



        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ReadEnderecoDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult ConsultaEnderecoPorId(int id)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco == null)
            {
                return NotFound();
            }
            return Ok(endereco);
        }

    }
}