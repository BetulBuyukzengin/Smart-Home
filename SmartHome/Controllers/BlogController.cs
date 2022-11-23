using Microsoft.AspNetCore.Mvc;
using SmartHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Controllers
{
    public class BlogController : Controller
    {
        private readonly Context _context;
        public BlogController(Context context)
        {
            _context = context;

        }
        public IActionResult Index()
        {

            BlogViewModel blog = new BlogViewModel();
            blog.BlogCategories = _context.BlokCategoryTablosu.ToList();
            blog.BlogList = _context.BlogTablosu.ToList();

            return View(blog);
        }

        //Goruntulenme sayfasi islemleri
        public IActionResult SingleBlog(int id)
        {
            var blog = _context.BlogTablosu.FirstOrDefault(x => x.Id == id);
            blog.Goruntulenme += 1;
            _context.SaveChanges();
            return View(blog);
        }
    }
}
