using Microsoft.AspNetCore.Mvc;

namespace CalculationApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Page1()
        {
            return View();
        }

        public IActionResult Page2()
        {
            return View();
        }

        public IActionResult Page3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(int num1, int num2)
        {
            int result = num1 + num2;
            ViewBag.Result = result;
            return RedirectToAction("Page4");
        }

        public IActionResult Page4()
        {
            return View();
        }
    }
}
