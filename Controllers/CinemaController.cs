using Microsoft.AspNetCore.Http;
using FilmesAPI.Models;
using FilmesAPI.Data.DTO.CinemaDto;
using System.Linq;

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
            Cinema cinema = _mapper.Map<Cinema>(cinemaDto);
            _context.Cinemas.Add(cinema);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ConsultaCinemaPorId), new { id = cinema.Id}, cinema);
        }

        [HttpGet]
        public IActionResult ConsultaCinemas()
        {
            return Ok(_context.Cinemas);
        }

        [HttpGet("{id}")]
        public IActionResult ConsultaCinemaPorId(int id)
        {
            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema != null)
            {
                ReadCinemaDto cinemaDto = _mapper.Map<ReadCinemaDto>(cinema);
                return Ok(cinemaDto);
            }
            return NotFound();
        }
    }
}