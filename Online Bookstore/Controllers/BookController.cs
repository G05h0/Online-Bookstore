using Microsoft.AspNetCore.Mvc;

namespace Online_Bookstore.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
