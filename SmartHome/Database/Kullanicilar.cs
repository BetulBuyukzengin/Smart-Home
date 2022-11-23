using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Database
{
    public class Kullanicilar
    {
        [Key]
        public int Id { get; set; }

        //[Required(ErrorMessage = "Field is required")]
        public string Ad { get; set; }

        //[Required(ErrorMessage = "Field is required")]
        public string Posta { get; set; }


        //[Required(ErrorMessage = "Field is required")]
        public string Mesaj { get; set; }

    }
}
