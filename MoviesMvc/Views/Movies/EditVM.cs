using MoviesMvc.Models;
using System.ComponentModel.DataAnnotations;

namespace MoviesMvc.Views.Movies
{
    public class EditVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Add title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Add release date")]
        public DateTime ReleaseDate { get; set; }

        public MovieCategoriesEnum MovieCategory { get; set; }

        [Required(ErrorMessage = "Add description")]
        public string? Description { get; set; }
    }
}
