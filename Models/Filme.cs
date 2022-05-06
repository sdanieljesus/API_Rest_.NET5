using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Titulo { get; set; }
        
        [Required]
        public string Diretor { get; set; }
        
        [Required]
        public string Genero { get; set; }
        
        public int Duracao { get; set; }
        
        
    }
}