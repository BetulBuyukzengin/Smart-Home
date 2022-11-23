using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartHome.Models;

namespace SmartHome.Controllers
{
    public class Banner2Controller : Controller
    {
        private readonly Context _context;

        public Banner2Controller(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
           //List< Banner2> bn = new List<Banner2>();
           // bn = c.Banner2s.ToList();
            List<Banner2> bn = _context.Banner2s.ToList();
            return View("Banner2Index",bn);
        }
    }
}
