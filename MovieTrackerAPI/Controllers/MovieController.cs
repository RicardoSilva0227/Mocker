using Microsoft.AspNetCore.Mvc;
using MovieTrackerAPI.Models;

namespace MovieTrackerAPI.Controllers
{
    public class movieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        #region get all movies
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetMovies()
        {
            IEnumerable<Movies> movieList;
            try
            {
                movieList = null;
                return View(movieList);
            }
            catch (Exception)
            {

                throw;
            }
            return View(movieList);
        }
        #endregion
    }
}
