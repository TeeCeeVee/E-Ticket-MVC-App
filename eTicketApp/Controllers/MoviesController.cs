using eTicketApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicketApp.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>Index()
        {
            //Include(movie => movie.Cinema) --- to get the cinema name per movie
            var allMovies = await _context.Movies.Include(movie => movie.Cinema).OrderBy(movie => movie.Name).ToListAsync();
            return View(allMovies);
        }
    }
}
