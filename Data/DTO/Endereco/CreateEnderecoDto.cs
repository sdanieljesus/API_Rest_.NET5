namespace FilmesAPI.Data.DTO.Endereco
{
    using System.ComponentModel.DataAnnotations;

    public class CreateEnderecoDto
    {
        [Required]
        public string Logradouro { get; set; }
        
        [Required]
        public string Bairro { get; set; }
        
        [Required]
        public int Numero { get; set; }
    }
}