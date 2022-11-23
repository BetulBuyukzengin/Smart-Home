using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartHome.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SmartHome.Controllers;

namespace SmartHome.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context;
        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            _context = context;

        }

        public IActionResult Index()
        {


            var bn2 = _context.Banner2s.ToList();
            var bn6 = _context.Baner6s.ToList();
            var swip = _context.Swipers.ToList();
            var yrm = _context.Yorums.ToList();

           
            //var kl = c.KullaniciTablo.ToList() buna gerek yok çünkü kullanıcı gönderilen mesajları görmeyecek;
            var an = new Anasayfa()
            {
                s = swip,
                b2 = bn2,
                y = yrm,
                b6 = bn6,


            };
           
            return View(an);

         

            //var swp = new Swiper()
            //{
            //    Centered1 = "WE ARE ALL ABOUT",
            //    Centered2 = "TAKE FULL CONTROL of Your Home",
            //    Centered3 = "SMART HOME DEVICES for the Safe and Comfortable Life",
            //};

            //var bn2 = new Banner2()
            //{
            //    Bn2text = "",
            //    CardText1 = "",
            //    CardText2 = "Window Handle Air",
            //    CardText3 = "Glass Break Sensor",
            //    CardText4 = "Door & Window Contact",
            //    CardText5 = "Water Sensor",
            //    CardText6 = "Weather Sensor",
            //    CardText7 = "Smoke Detector Air",
            //    CardText8 = "Climate Control",
            //};



            //var yorum = new Yorum()
            //{
            //    Etiket = "TESTIMONIALS",
            //    Etiketbaslik = "WHAT PEOPLE SAY ABOUT US ",
            //    Cardtext1 = "Your company handled everything perfectly: from design to implementation.The on - site technicians went above and beyond to make sure the interface was customized to our lifestyle and preferences.",
            //    Sahibi1 = "SAMANTHA GREEN",
            //    Sahibi2 = " ANGIE ALLEN ",
            //    Cardtext2 = "The entire experience has been absolutely incredible from the moment we ve opened our front door.It’s unusual to get someone who really wows you in terms of theircustomer service,but they did!",
            //};
            //var banner6 = new Banner6()
            //{
            //    Solbaslik1 = "CREATE YOUR PERSONAL Smart Home Project",
            //    Solaciklama = "We re here to answer any questions you might have about living in a Smart Home.",
            //    Callnow = 1234567890,
            //    Yname = "YourName*",
            //    Eml = "Email*",
            //    Msg = "Message*",
            //    Submit = "Send",
            //};


        }






        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
