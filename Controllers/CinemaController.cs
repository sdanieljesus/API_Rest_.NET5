using Microsoft.AspNetCore.Http;
using FilmesAPI.Models;
using FilmesAPI.Data.DTO.CinemaDto;


namespace FilmesAPI.Controllers
{
    using AutoMapper;
    using FilmesAPI.Data;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class CinemaController : ControllerBase
    {

        private AppDbContext _context;
        private IMapper _mapper;

        public CinemaController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Cinema))]
        public IActionResult CreateCinema([FromBody] CreateCinemaDto cinemaDto)
        {
            
            return Ok();
        }

        [HttpGet]
        public IActionResult ConsultaCinemas()
        {
            return Ok(_context.Cinemas);
        }
    }
}