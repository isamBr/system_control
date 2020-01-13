using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace System_Controle.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public DateTime DateAdded { get; set; } = DateTime.Now;

        public DateTime ReleaseDate { get; set; } = DateTime.Now;


        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        [Required]
        public int GenreId { get; set; }
    }
}