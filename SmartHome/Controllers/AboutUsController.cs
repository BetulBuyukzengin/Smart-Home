using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartHome.Models;
using System;
using SmartHome.Database;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SmartHome.Controllers;


namespace SmartHome.Controllers
{
   
    public class AboutUsController : Controller
    {
        private readonly Context _context;


        public AboutUsController(Context context)
        {
            _context = context;
        }
        public IActionResult AboutUsIndex()
        {
            //Bu şekilde ya da asagidaki yorum satırındaki gibi yapılabilir

            AboutUsViewModelClass a = new AboutUsViewModelClass();

            a.aboutUs = _context.aboutUsEkipUyleriTablosu.ToList();
 
            a.usHizmetlers = _context.aboutUsHizmetlerTablosu.ToList();

            //**********************************************

            //var aEkipUye = _context.aboutUsEkipUyleriTablosu.ToList();
            //var aForm = _context.aboutUsFormTablosu.ToList();
            //var aHizmet = _context.aboutUsHizmetlerTablosu.ToList();

            //var aboutus = new AboutUsViewModelClass()
            //{
            //    aboutUs = aEkipUye,
            //    usForms = aForm,
            //    usHizmetlers = aHizmet,


            //};
            return View(a);
        }



        [HttpPost]
        public IActionResult FormTextEkle(AboutUsForm model)
        {
            if (ModelState.IsValid)
            {
                //Bu yapi girilen verileri ekler fakat biz bunu kullanmayacagiz,kullanici gormeyecek
                //Kullanicilar ktablo = new Kullanicilar();
                //ktablo.Ad = model.Ad;

                _context.aboutUsFormTablosu.Add(model);//girilen verileri veritabanındaki tabloya ekliyor
                _context.SaveChanges();//bu verileri veritabanına kaydediyor!!!!!

                return RedirectToAction("AboutUsIndex", "AboutUs");
            }

            return RedirectToAction("AboutUsIndex", "AboutUs");

        }


    }
}
