using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public class Yorum
    {
        [Key]
        public int Id { get; set; }

        public string Etiket { get; set; }
        public string Etiketbaslik { get; set; }
        public string Cardtext1 { get; set; }
        public string Sahibi1 { get; set; }
        public string Sahibi2{ get; set; }
        public  string Cardtext2 { get; set; }
    }
}
