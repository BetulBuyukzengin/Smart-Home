using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmartHome.Database;
using SmartHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Controllers
{
    public class KullanicilarController : Controller
    {
        private readonly Context _context;
        public KullanicilarController(Context context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Index(Kullanicilar model)
        {
            if (ModelState.IsValid)
            {
                //Bu yapi girilen verileri ekler fakat biz bunu kullanmayacagiz,kullanici gormeyecek
                //Kullanicilar ktablo = new Kullanicilar();
                //ktablo.Ad = model.Ad;

                _context.KullaniciTablo.Add(model);//girilen verileri veritabanındaki tabloya ekliyor
                _context.SaveChanges();//bu verileri veritabanına kaydediyor!!!!!

                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Home");

        }
    }
}
