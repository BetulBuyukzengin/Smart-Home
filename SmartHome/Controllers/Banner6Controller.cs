using Microsoft.AspNetCore.Mvc;
using SmartHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Controllers
{
    public class Banner6Controller : Controller
    {
        private readonly Context _context;

        public Banner6Controller(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            

            
            List<Banner6> d = _context.Baner6s.ToList();
            return View("Banner6sIndex", d);

        }

    
    }
}
