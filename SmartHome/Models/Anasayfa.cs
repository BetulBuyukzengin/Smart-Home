using SmartHome.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public class Anasayfa
    {
       
        public List<Swiper> s { get; set; }
        public List<Banner2> b2 { get; set; }
        public List<Yorum> y { get; set; }
        public List<Banner6> b6 { get; set; }
        public List<Kullanicilar>k { get; set; }
        public List <Admin> a { get; set; }

    }
}
