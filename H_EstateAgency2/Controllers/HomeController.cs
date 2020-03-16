using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using H_EstateAgency2.Models;

namespace H_EstateAgency2.Controllers
{



    //test
    public class HomeController : Controller
    {
        private readonly AppDBContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AppDBContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
        {
            var result = _context.Properties.Where(x => x.isAvailable == true).ToList();

            foreach (var item in result)
            {
                var img = _context.Pictures.Where(x => x.PropertyId == item.PropertyId).FirstOrDefault();
                if (item.pictures == null) item.pictures = new List<Picture>();
                item.pictures.Add(img);
            }

            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
