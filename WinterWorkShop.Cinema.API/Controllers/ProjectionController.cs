using Microsoft.AspNetCore.Mvc;
using WinterWorkShop.Cinema.Data.Repositories;
using WinterWorkShop.Cinema.Domain.Responses;

namespace WinterWorkShop.Cinema.API.Controllers
{
    [ApiController]
    [Route("projections")]
    public class ProjectionController : BaseController
    {
        public IProjectionRepository _projectionRepository;
       public ProjectionController(IProjectionRepository projectionRepository) {
            _projectionRepository = projectionRepository;     
       }

        [HttpGet()]
        public List<GetAllProjectionsResponses> GetProjections()
        {
            var projections = _projectionRepository.GetAllProjections();

            var result = new List<GetAllProjectionsResponses>();

            foreach (var projection in projections)
            {
                result.Add(new GetAllProjectionsResponses
                {
                    Id = projection.Id,
                    DateOfProjection = projection.DateOfProjection,
                    Minutes = projection.Minutes,
                    MovieId = projection.MovieId
                });
            }

            return result;
        }

        [Route("{id:int}")]
        [HttpGet()]
        public GetAllProjectionsResponses GetProjectionById(int id)
        {
            var projection = _projectionRepository.GetProjectionById(id);

            var result = new GetAllProjectionsResponses
            {
                Id = projection.Id,
                DateOfProjection = projection.DateOfProjection,
                Minutes = projection.Minutes,
                MovieId = projection.MovieId
            };

            return result;
        }

        [Route("movieById/{movieId:int}")]
        [HttpGet()]
        public GetAllProjectionsResponses GetProjectionByMovieId(int movieId)
        {
            var projection = _projectionRepository.GetProjectionByMovieId(movieId);

            var result = new GetAllProjectionsResponses
            {
                Id = projection.Id,
                DateOfProjection = projection.DateOfProjection,
                Minutes = projection.Minutes,
                MovieId = projection.MovieId
            };

            return result;
        }
    }
}
