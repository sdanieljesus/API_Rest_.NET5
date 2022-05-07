using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Required]
        public Endereco Endereco { get; set; }

        public int EnderecoId { get; set; }
        
        
        
        
        
    }
    
}