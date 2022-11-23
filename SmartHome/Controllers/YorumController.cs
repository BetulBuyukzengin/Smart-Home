using Microsoft.AspNetCore.Mvc;
using SmartHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Controllers
{
    public class YorumController : Controller
    {
        private readonly Context _context;

        public YorumController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //List<Yorum> yrm = new List<Yorum>();
            //yrm = e.Yorums.ToList();
            //return View(yrm);

            List<Yorum> yrm = _context.Yorums.ToList();
            return View("YorumsIndex", yrm);
        }
    }
}
