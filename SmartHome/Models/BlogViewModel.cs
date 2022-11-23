using SmartHome.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public class BlogViewModel
    {
        public List<Blog> BlogList { get; set; }
        public List<BlogCategory> BlogCategories { get; set; }
    }
}
