using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public class Swiper
    {
        [Key]
        public int Id { get; set; }
        public string Centered1 { get; set; }
        public string Centered2 { get; set; }
        public string Centered3 { get; set; }

      
    }
}
