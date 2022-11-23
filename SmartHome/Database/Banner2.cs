using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public class Banner2
    {
        [Key]
        public int Idbanner2 { get; set; }
        public string Bn2text { get; set; }
        public string CardText1 { get; set; }
        public string CardText2 { get; set; }
        public string CardText3 { get; set; }
        public string CardText4 { get; set; }
        public string CardText5 { get; set; }
        public string CardText6 { get; set; }
        public string CardText7 { get; set; }
        public string CardText8 { get; set; }
        //public IFormFile ImageURL { get; set; }  /*card resimleri için*/
    }
}
