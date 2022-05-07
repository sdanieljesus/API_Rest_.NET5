using Microsoft.AspNetCore.Http;
using FilmesAPI.Models;
using FilmesAPI.Data.DTO.CinemaDto;


namespace FilmesAPI.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class CinemaController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Cinema))]
        public IActionResult CreateCinema([FromBody] CreateCinemaDto cinemaDto)
        {
            
            return Ok();
        }
    }
}