using Microsoft.AspNetCore.Mvc;

namespace L02P02_2021GH601_2021BS650.Controllers
{
    public class LibreriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
