﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime? DateAdded { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(1,30)]
        [Display(Name = "Number In Stock")]
        public byte NumberInStock { get; set; }

        
        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }
    }
}