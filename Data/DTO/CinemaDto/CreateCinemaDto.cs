using System.ComponentModel.DataAnnotations;
using FilmesAPI.Models;

namespace FilmesAPI.Data.DTO.CinemaDto
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        public int EnderecoId { get; set; }
        
        
        public int GerenteId { get; set; }
        
        
        
        
    }
}