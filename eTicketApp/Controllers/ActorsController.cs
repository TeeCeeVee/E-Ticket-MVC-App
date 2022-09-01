using eTicketApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicketApp.Controllers
{
    public class ActorsController : Controller
    {
        //declare AppDbContext - to get/send data to the database

        private readonly AppDbContext _context;

        //inject _context to the constructor
        public ActorsController(AppDbContext context)
        {
            _context = context;
        }
        
       public async Task<IActionResult> Index()
        {
            //passing the actors as a list
            
            var data = await _context.Actors.ToListAsync();
            //pass data to the View
            return View();
        }
    }
}
