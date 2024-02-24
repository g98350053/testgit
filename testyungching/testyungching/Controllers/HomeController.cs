using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
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
            for (int i=0;i<100;i++)
            {
                result.Add(new HouseResultViewModel() { HouseId = $"222{i}", HouseName = $"´ú¸Õ©Ð«Î¦W{i}", HouseType = 1, HouseSize = 18.2, HousePrice = 330 });

            }




            return Json(result);   
        
        }




    }
}
