using eTicketApp.Data;
using eTicketApp.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicketApp.Controllers
{
    public class ActorsController : Controller
    {
        /* do before creating the SERVICE FOLDER then change below after SERVICE has been created
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
            return View(data);
        }*/

        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        // Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
