using Microsoft.AspNetCore.Mvc;
using SmartHome.Database;
using SmartHome.Models;
using System.Collections.Generic; 
using System.Linq;

namespace SmartHome.Controllers
{
    public class A_smarthomeController : Controller
    {
        private readonly Context _context;

        public List<A_smarthome> asmarthome= new List<A_smarthome>();  //using System.Collections.Generic; 


        public A_smarthomeController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            asmarthome = _context.A_Smarthomes.ToList();  //using System.Linq;

            return View(asmarthome);
        }
    }


}
