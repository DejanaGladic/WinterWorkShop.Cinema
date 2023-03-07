using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterWorkShop.Cinema.Data.Models;
using WinterWorkShop.Cinema.Domain.Common;
using WinterWorkShop.Cinema.Domain.Responses;

namespace WinterWorkShop.Cinema.Data.Repositories
{    
    public class ProjectionRepository : IProjectionRepository
    {
        public Database Database = new Database();

        public List<ProjectionModel> GetAllProjections()
        {
            return Database.GetAllProjectionsResponses;
        }

        public ProjectionModel GetProjectionById(int id)
        {
            ProjectionModel _projection = Database.GetAllProjectionsResponses.FirstOrDefault(ProjectionModel => ProjectionModel.Id == id);
            return _projection;
        }

        public ProjectionModel GetProjectionByMovieId(int MovieId)
        {
            return Database.GetAllProjectionsResponses.FirstOrDefault(ProjectionModel => ProjectionModel.MovieId == MovieId);
        }
    }
}
