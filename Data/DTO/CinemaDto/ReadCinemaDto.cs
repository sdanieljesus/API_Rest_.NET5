using System.ComponentModel.DataAnnotations;
using FilmesAPI.Models;

namespace FilmesAPI.Data.DTO.CinemaDto
{
    public class ReadCinemaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
        
        public Endereco Endereco { get; set; }
        
        public Gerente Gerente { get; set; }
        
        
        
    }
}