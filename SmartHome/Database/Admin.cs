using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Database
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSifre { get; set; }
    }
}
