using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using testyungching.Bussinse;
using testyungching.Models;

namespace testyungching.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        [HttpPost]
        public JsonResult GetHouseList(HouseSearchViewModel model)
        {
            List<HouseResultViewModel> result = new List<HouseResultViewModel>();
           var oHouseData =  new HouseData();
            result =  oHouseData.GetHouseData(model).Select(x=>new HouseResultViewModel() { HouseName = x.HouseName, HouseId = x.HouseId
            , HousePrice = x.HousePrice, HouseSize = x.HouseSize, HouseType = x.HouseType  }).ToList();
            //for (int i=0;i<100;i++)
            //{
            //    result.Add(new HouseResultViewModel() { HouseId = $"222{i}", HouseName = $"´ú¸Õ©Ð«Î¦W{i}", HouseType = 1, HouseSize = (decimal)18.2, HousePrice = 330 });

            //}




            return Json(result);   
        
        }




    }
}
