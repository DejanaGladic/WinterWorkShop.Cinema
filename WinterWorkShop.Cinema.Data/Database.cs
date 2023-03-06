using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Domain.Common
{
    public class Database
    {
        public List<MovieModel> GetAllMoviesResponses = new List<MovieModel> 
        { 
            new MovieModel { Id = 1, Name = "Spuderman", FilmDirector = "Jack Jackson" },
            new MovieModel { Id = 2, Name = "Spuderman 2", FilmDirector = "Jack Jackson 2" }
        };

        public MovieModel GetMovieById = new MovieModel { Id = 1, Name = "Spuderman", FilmDirector = "Jack Jackson" };


        public List<ProjectionModel> GetAllProjectionsResponses = new List<ProjectionModel>
        {
            new ProjectionModel { Id = 1, DateOfProjection = new DateTime(2022, 10, 12), Minutes=120 },
            new ProjectionModel { Id = 2, DateOfProjection = new DateTime(2022, 10, 12), Minutes=150 }
        };
    }
}
