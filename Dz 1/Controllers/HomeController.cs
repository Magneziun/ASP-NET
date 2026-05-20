using Dz_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dz_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            var myInfo = new PersonInfo
            {
                FirstName = "Магомед",
                LastName = "Дагиров",
                Age = 19,
                CardNumber = "6742 1488 6969 5242"
                
            };

            return View(myInfo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
