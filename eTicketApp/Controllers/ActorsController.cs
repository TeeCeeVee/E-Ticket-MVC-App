using eTicketApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTicketApp.Controllers
{
    public class ActorsController : Controller
    {
        //declare AppDbContext - to get/send data to the database

        private readonly AppDbContext _context;

        //inject _context to the constructor
        public ActorsController(AppDbContext actors_context)
        {
            _context = actors_context;
        }
        
       public IActionResult Index()
        {
            //passing the actors as a list
            
            var data = _context.Actors.ToList();
            //pass data to the View
            return View();
        }
    }
}
