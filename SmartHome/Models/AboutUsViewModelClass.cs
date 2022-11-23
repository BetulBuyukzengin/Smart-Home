using SmartHome.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public class AboutUsViewModelClass
    {   //bu şekilde de yapılabilir ya da aşağıdaki şekilde de yapılabilir
        //public List<AboutUsEkipUyleri> aboutUs { get; set; }
        //public List<AboutUsForm> usForms { get; set; } 
        //public List<AboutUsHizmetler> usHizmetlers { get; set; }


        public List<AboutUsEkipUyleri> aboutUs = new List<AboutUsEkipUyleri>();  //using System.Collections.Generic;
        public AboutUsForm usForms = new AboutUsForm();  //using System.Collections.Generic;
        public List<AboutUsHizmetler> usHizmetlers = new List<AboutUsHizmetler>();  //using System.Collections.Generic;
    }
}
