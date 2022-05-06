using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTO
{
    public class CreateFilmeDto
    {
        [Required]
        public string Titulo { get; set; }
        
        [Required]
        public string Diretor { get; set; }
        
        [Required]
        public string Genero { get; set; }

        [Required]        
        public int Duracao { get; set; }
    }
}