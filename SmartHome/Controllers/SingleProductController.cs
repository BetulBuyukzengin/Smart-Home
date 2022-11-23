using Microsoft.AspNetCore.Mvc;
using SmartHome.Database;
using SmartHome.Models;
using System.Collections.Generic;
using System.Linq;
namespace SmartHome.Controllers
{
    namespace SmartHome.Controllers
    {
        public class SingleProductController : Controller
        {
            private readonly Context _context;
            public List<SingleProduct> singleproduct = new List<SingleProduct>();

            public SingleProductController(Context context)
            {
                _context = context;
            }

            public IActionResult SingleProductIndex()
            {

                singleproduct = _context.SingleProducts.ToList();  //using System.Linq;

                return View(singleproduct);
            }
        }
    }
}
