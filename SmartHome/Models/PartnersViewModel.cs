using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartHome.Database;

namespace SmartHome.Models
{
    public class PartnersViewModel
    {
        public List<Partners> partners = new List<Partners>();  //using SmartHome.Database;
        public PartnersForm partnersform = new PartnersForm();  //using SmartHome.Database;

    }
}
