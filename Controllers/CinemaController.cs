using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FilmesAPI.Data.DTO.Cinema;
using FilmesAPI.Models;


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
        public IActionResult Get()
        {
            
            return Ok();
        }
    }
}