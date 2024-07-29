using Microsoft.AspNetCore.Mvc;
using MoviesSeries.Data;
using MoviesSeries.Models;

namespace MoviesSeries.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeriesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SeriesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Series>> GetSeries()
        {
            return _context.Series.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Series> GetSeries(int id)
        {
            var series = _context.Series.Find(id);
            if (series == null)
            {
                return NotFound();
            }
            return series;
        }

        [HttpPost]
        public ActionResult<Series> PostSeries(Series series)
        {
            _context.Series.Add(series);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetSeries), new { id = series.Id }, series);
        }
    }
}
