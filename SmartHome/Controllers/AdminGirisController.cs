using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using SmartHome.Database;
using SmartHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims; //Claims kullanimi icin
using System.Threading.Tasks;

namespace SmartHome.Controllers
{
    public class AdminGirisController : Controller
    {
        private readonly Context _context;

        public AdminGirisController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //List<Admin> adm = _context.Admins.ToList();
            //return View("Banner2Index", adm);
            return View();
        }

        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GirisYap(Admin p)
        {
            var bilgiler = _context.Admins.FirstOrDefault(
                x => x.KullaniciAdi == p.KullaniciAdi && x.KullaniciSifre == p.KullaniciSifre);
            if (bilgiler != null)
            {
                //talepler,çerez işlemleri girişin yapılıp yapılmadığı kontrol edilir
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.KullaniciAdi)
                };
                var userIdentity = new ClaimsIdentity(claims, "AdminLogin");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                //Async ifadeleri kullanabilmek için await kullanildi
                //SignInAsync sifreli cookie oluşturur ve yanıta ekler
                await HttpContext.SignInAsync(principal);
                //AdminDashboard daki AdminDashboard a git
                return RedirectToAction("AdminDashboard", "AdminDashboard");

            }
             return View();
        }

        //Cikis yapma islemi
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("GirisYap", "AdminGiris");

        }
    }
}