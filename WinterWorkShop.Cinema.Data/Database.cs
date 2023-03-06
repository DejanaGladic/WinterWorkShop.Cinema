using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Domain.Common
{
    public class Database
    {
        public List<MovieModel> GetAllMoviesResponses = new List<MovieModel> 
        { 
            new MovieModel { Id = 1, Name = "Spuderman" },
            new MovieModel { Id = 2, Name = "Spuderman 2"}
        };

        public List<ProjectionModel> GetAllProjectionsResponses = new List<ProjectionModel>
        {
            new ProjectionModel { Id = 1, DateOfProjection = new DateOnly(2022, 10, 12), Minutes=120 },
            new ProjectionModel { Id = 2, DateOfProjection = new DateOnly(2022, 10, 12), Minutes=150 }
        };
    }
}
