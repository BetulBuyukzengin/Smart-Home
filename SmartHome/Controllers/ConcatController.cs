using Microsoft.AspNetCore.Mvc;
using SmartHome.Database;
using SmartHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Controllers
{
    public class ConcatController : Controller
    {
        private readonly Context _context;

        public ConcatController(Context context)
        {
            _context = context;
        }
        public IActionResult ConcatIndex()
        {
            ConcatViewModel concat_view_model = new ConcatViewModel();

            concat_view_model.concat_iletisim = _context.concatIletisimTablosu.ToList();
            return View(concat_view_model);
        }


        [HttpPost]
        public IActionResult ConcatFormEkle(ConcatForm model)
        {
            if (ModelState.IsValid)
            {
                //Bu yapi girilen verileri ekler fakat biz bunu kullanmayacagiz,kullanici gormeyecek
                //Kullanicilar ktablo = new Kullanicilar();
                //ktablo.Ad = model.Ad;

                _context.concatFormTablosu.Add(model);//girilen verileri veritabanındaki tabloya ekliyor
                _context.SaveChanges();//bu verileri veritabanına kaydediyor!!!!!

                return RedirectToAction("ConcatIndex", "Concat");
            }

            return RedirectToAction("ConcatIndex", "Concat");

        }
    }
}
