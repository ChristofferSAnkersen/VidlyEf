using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyEf.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please fill out movie title")]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Please select a genre for the movie")]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Please declare release date for the movie")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required(ErrorMessage = "Please select total amount in stock")]
        public byte NumberInStock { get; set; }











    }
}