using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Database
{
    public class Blog
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public DateTime Tarih { get; set; }
        public int KategoriId { get; set; }
        public bool AktifPasif { get; set; }
        public int Goruntulenme { get; set; }
    }
}
