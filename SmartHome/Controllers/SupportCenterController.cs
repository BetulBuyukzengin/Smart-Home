using Microsoft.AspNetCore.Mvc;
using SmartHome.Models;
using SmartHome.Controllers;
using SmartHome.Database;
using System.Collections.Generic;
using System.Linq;


public class SupportCenterController : Controller
{
    private readonly Context _context;
    public List<SupportCenter> supportcenter = new List<SupportCenter>();
    public SupportCenterController(Context context)
    {
        _context = context;
    }

    public IActionResult SupportCenterIndex()
    {
        supportcenter = _context.SupportCenters.ToList();  //using System.Linq;

        return View(supportcenter);
    }
}
