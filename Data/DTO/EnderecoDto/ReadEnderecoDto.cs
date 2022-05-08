using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTO.EnderecoDto
{

    public class ReadEnderecoDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Logradouro { get; set; }
        
        [Required]
        public string Bairro { get; set; }
        
        [Required]
        public int Numero { get; set; }
    }
}