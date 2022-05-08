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
    public class EnderecoController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Endereco))]
        public IActionResult AdicionaEndereco([FromBody] CreateEnderecoDto enderecoDto)
        {
            Endereco endereco = _mapper.Map<Endereco>(enderecoDto);
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ConsultaEnderecoPorId), new {id = endereco.Id}, endereco);
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ReadEnderecoDto>))]
        public IActionResult ConsultaEnderecos()
        {
            return Ok(_context.Enderecos);
        }


        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ReadEnderecoDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult ConsultaEnderecoPorId(int id)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco != null)
            {
                ReadEnderecoDto enderecoDto = _mapper.Map<ReadEnderecoDto>(endereco);
                return Ok(enderecoDto);
            }
            return NotFound();
        }

    }
}