using Microsoft.AspNetCore.Mvc;

namespace TP1.Controllers
{
    public class CustomerController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id) {

        return View();
        }
    }
}
