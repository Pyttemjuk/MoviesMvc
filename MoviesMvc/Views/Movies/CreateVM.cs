using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesMvc.Models;
using System.ComponentModel.DataAnnotations;

namespace MoviesMvc.Views.Movies
{
    public class CreateVM
    {
        [Required(ErrorMessage = "Title required")]
        public string Title { get; set; }

        [Display(Name = "Release date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Category")]
        public MovieCategoriesEnum MovieCategory { get; set; }

        [MaxLength(5000)]
        public string? Description { get; set; }
    }
}
