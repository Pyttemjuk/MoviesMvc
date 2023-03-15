using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesMvc.Views.Movies;

namespace MoviesMvc.Models
{
    public class DataService
    {
        readonly List<DetailsVM> movieList = new()
               {
                new DetailsVM()
                {
                    Id = 1,
                    Title = "Alone in the dark",
                    ReleaseDate = new DateTime(2005, 01, 28),
                    MovieCategory = MovieCategoriesEnum.Horror,
                    Description = "A detective of the paranormal slowly unravels mysterious events with deadly results."
                },
                new DetailsVM()
                {
                    Id = 2,
                    Title = "Alice i Underlandet",
                    ReleaseDate = new DateTime(2010, 02, 25),
                    MovieCategory = MovieCategoriesEnum.Fantasy,
                    Description = "Nineteen-year-old Alice returns to the magical world from her childhood adventure, where she reunites with her old friends and learns of her true destiny: to end the Red Queen's reign of terror."
                },
                new DetailsVM()
                {
                    Id = 3,
                    Title = "Burn After Reading",
                    ReleaseDate = new DateTime(2008, 08, 27),
                    MovieCategory = MovieCategoriesEnum.Action,
                    Description = "A disk containing mysterious information from a CIA agent ends up in the hands of two unscrupulous and daft gym employees who attempt to sell it."
                },
            };
        
        


        public void AddMovie(CreateVM model)
        {
            movieList.Add(new DetailsVM()
            {
                Id = movieList.Max(o => o.Id) + 1,
                Title = model.Title,
                ReleaseDate = model.ReleaseDate,
                MovieCategory = model.MovieCategory,
                Description = model.Description
            });
        }

        public IndexVM[] GetAllMovies()
        {
            List<IndexVM> model = new();

            foreach (var item in movieList)
            {
                model.Add(new IndexVM()
                {
                    Id = item.Id,
                    Title = item.Title,
                });
            }

            return model
                .OrderBy(o => o.Title)
                .ToArray();
        }

        public DetailsVM GetMovieById(int id)
        {
            return movieList.SingleOrDefault(o => o.Id  == id);
        }

        public EditVM GetMovieToEditById(int id)
        {
            return movieList
                .Select(o => new EditVM()
                {
                    Id = o.Id,
                    Title = o.Title,
                    ReleaseDate = o.ReleaseDate,
                    MovieCategory = o.MovieCategory,
                    Description = o.Description
                })
                .SingleOrDefault(o => o.Id == id);
        }
    }
}
