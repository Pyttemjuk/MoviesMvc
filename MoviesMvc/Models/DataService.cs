using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesMvc.Views.Movies;

namespace MoviesMvc.Models
{
    public class DataService
    {
        private readonly ApplicationContext context;

        public DataService(ApplicationContext context)
        {
            this.context = context;
        }

        public void AddMovie(CreateVM model)
        {
            context.Movies.Add(new Movie()
            {
                Title = model.Title,
                ReleaseDate = model.ReleaseDate,
                MovieCategory = model.MovieCategory,
                Description = model.Description
            });
            context.SaveChanges();
        }

        public IndexVM[] GetAllMovies()
        {
            return context.Movies.
                Select(o => new IndexVM()
                {
                    Id = o.Id,
                    Title = o.Title,
                })
                .OrderBy(o => o.Title)
                .ToArray();
        }

        public DetailsVM GetMovieById(int id)
        {
            return context.Movies
                .Select(o => new DetailsVM()
                {
                    Id = o.Id,
                    Title = o.Title,
                    ReleaseDate = o.ReleaseDate,
                    MovieCategory = o.MovieCategory,
                    Description = o.Description
                })
                .Single(o => o.Id  == id);
        }

        public EditVM GetMovieToEditById(int id)
        {
            return context.Movies
                .Select(o => new EditVM()
                {
                    Id = o.Id,
                    Title = o.Title,
                    ReleaseDate = o.ReleaseDate,
                    MovieCategory = o.MovieCategory,
                    Description = o.Description
                })
                .Single(o => o.Id == id);
        }

        public void UpdateMovie(EditVM model)
        {
            context.Movies.Update(new Movie()
            {
                Id = model.Id,
                Title = model.Title,
                ReleaseDate = model.ReleaseDate,
                MovieCategory = model.MovieCategory,
                Description = model.Description
            });
            context.SaveChanges();
        }
    }
}
