using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTO
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }
        
        
    }
}