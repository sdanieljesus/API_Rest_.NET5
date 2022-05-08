using System.Collections.Generic;
using FilmesAPI.Models;

namespace FilmesAPI.Data.DTO.GerenteDto
{
    public class ReadGerenteDto
    {
        public int Id { get; set; }
        
        public string Nome { get; set; }

        public object Cinemas { get; set; }
        
        

    }
}