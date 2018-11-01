using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyEf.Dtos
{
    public class MovieDto
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Please fill out movie title")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select a genre for the movie")]
        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}