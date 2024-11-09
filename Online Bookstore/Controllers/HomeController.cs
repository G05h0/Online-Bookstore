using Microsoft.AspNetCore.Mvc;
using Online_Bookstore.Models;
using System.Diagnostics;

namespace Online_Bookstore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
