using System.ComponentModel.DataAnnotations;

namespace MoviesMvc.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public MovieCategoriesEnum MovieCategory { get; set; }
        public string? Description { get; set; }
    }
}
