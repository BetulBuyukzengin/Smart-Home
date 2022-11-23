using Microsoft.AspNetCore.Mvc;
using SmartHome.Database;
using SmartHome.Models;
using System.Collections.Generic;
using System.Linq;
namespace SmartHome.Controllers
{
    public class ServicesController : Controller
    {
        private readonly Context _context;

        public List<Services> service = new List<Services>();  //using System.Collections.Generic; 


        public ServicesController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
             service = _context.Services_a.ToList();  //using System.Linq;

            return View(service);
        }
    }
}
