using Microsoft.AspNetCore.Mvc;
using SmartHome.Database;
using SmartHome.Models;
using System.Linq;
using System.Collections.Generic;

namespace SmartHome.Controllers
{
    public class PartnersController : Controller
    {
        private readonly Context _context; //using SmartHome.Models;

        //public List<Partners> partners = new List<Partners>(); 
        // using SmartHome.Database;using System.Collections.Generic;

        public PartnersController(Context context)
        {
            _context = context; 
        }
        public IActionResult PartnersIndex()
        {

            PartnersViewModel partnersView = new PartnersViewModel();

            partnersView.partners = _context.Partners_Con.ToList();

            //partnersView.partnersform = _context.PartnersFormTable.Add();





            //partners = _context.Partners_Con.ToList();  //using System.Linq;

            return View(partnersView);
        }

        [HttpPost]
        public IActionResult PartnerVeriEklemeIndex(PartnersForm model)
        {
            if (ModelState.IsValid)
            {             
                _context.PartnersFormTable.Add(model);//girilen verileri veritabanındaki tabloya ekliyor
                _context.SaveChanges();//bu verileri veritabanına kaydediyor!!!!!

                return RedirectToAction("PartnersIndex", "Partners");
                //return RedirectToRoute("partners-sayfasi");  birden fazla sayfada yonlendirme verilecekse RedirectToRoute ile yapilmali daha kolay

            }

            return RedirectToAction("PartnersIndex", "Partners");

        }
    }
}
