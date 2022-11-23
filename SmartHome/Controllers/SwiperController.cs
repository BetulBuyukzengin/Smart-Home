using Microsoft.AspNetCore.Mvc;
using SmartHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Controllers
{
    public class SwiperController : Controller
    {
        private readonly Context _context;

        public SwiperController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //List<Swiper> sw = new List<Swiper>();
            //sw = f.Swipers.ToList();
            //return View(sw);



            List<Swiper> sw = _context.Swipers.ToList();
            return View("SwipersIndex", sw);
        }
    }
}
