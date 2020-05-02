using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using H_EstateAgency2.Models;
using Microsoft.EntityFrameworkCore;

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
            try
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
            catch (Exception ex)
            {

                return View();
            }
       
        }




        [HttpPost("GetResults")]
        public async Task<IActionResult> Index([FromBody] PropertySearchModel searchModel)
        {
            var result = _context.Properties.Where(x => x.isAvailable == true && (EF.Functions.Like(x.PropertyTitle,'%'+ searchModel.PropertySearch +"%"))).ToList();

            foreach (var item in result)
            {
                var img = _context.Pictures.Where(x => x.PropertyId == item.PropertyId).FirstOrDefault();
                if (item.pictures == null) item.pictures = new List<Picture>();
                item.pictures.Add(img);
            }



            List<SearchResultModel> op = new List<SearchResultModel>();
            foreach(var  item in result)
            {
                op.Add(new SearchResultModel()
                {
                    PropertyTitle = item.PropertyTitle
                    ,
                    Ppurpose = item.Ppurpose
                    ,
                    PropertyCity = item.PropertyCity
                    ,
                    PropertyArea = item.PropertyArea
                    ,
                    PropertyPrice = item.PropertyPrice
                    ,
                    picture = Convert.ToBase64String(item.pictures.FirstOrDefault().photo)
                    ,PropertyId=item.PropertyId

                });
            }

            return Ok(op);
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


        [HttpGet("AhmedSafaaa")]
        public IActionResult AhmedSafaaa()
        {


            return View();
        }
        


    }
}
