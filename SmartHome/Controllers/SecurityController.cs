using Microsoft.AspNetCore.Mvc;
using SmartHome.Database;
using SmartHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SmartHome.Controllers
{
    public class SecurityController : Controller
    {

        private readonly Context _context;
        public List<Hq_technology> hqtech = new List<Hq_technology>();  //viewmodel içinde tanımlanmadı 1 tane olduğu için
        public SecurityController(Context context)
        {
            _context = context;
        }


        public IActionResult Index()
        
        
        {
            //List<Hq_technology> deneme = new List<Hq_technology>(); //ayni

            //var deneme2 = _context.hq_Technologies.ToList(); //ayni
            hqtech = _context.hq_Technologies.ToList();

            return View(hqtech);

           
        }

    }
}





