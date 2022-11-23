using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHome.Database; /*Kullanıcılar listi tanımlandı*/
using SmartHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Controllers
{
    public class AdminDashboardController : Controller
    {
        private readonly Context _context;

        public AdminDashboardController(Context context)
        {
            _context = context;
        }
        [Authorize]
        //Tablodan veri cekecek
        public IActionResult AdminDashboard()
        {
            List<Kullanicilar> kullanici = _context.KullaniciTablo.ToList();
            return View(kullanici);
        }


        //Kullanicilarin mesajlarini  silme, 
        public IActionResult MesajSil(int id) /*  id adında parametre tanımlandı*/
        {
            var mesaj = _context.KullaniciTablo.Find(id); /*KullaniciTabloya gönderilen id yi bulup mesaja aktarıldı */
            _context.KullaniciTablo.Remove(mesaj); /*KullaniciTablonun içinden mesajdan gelen satırın tamamını bul ve sil*/
            _context.SaveChanges(); /*Değişiklikleri kaydet*/
            return RedirectToAction("AdminDashboard"); /*Tekrar aynı sayfaya döndür*/
        }


            public IActionResult Index()
        {
            return View();
        }
    }
}
