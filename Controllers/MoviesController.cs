using Microsoft.AspNetCore.Mvc;
using MoviesSeries.Data;
using MoviesSeries.Models;

namespace MoviesSeries.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetMovies()
        {
            return _context.Movies.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovie(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }

        [HttpPost]
        public ActionResult<Movie> PostMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetMovie), new { id = movie.Id }, movie);
        }
    }
}
