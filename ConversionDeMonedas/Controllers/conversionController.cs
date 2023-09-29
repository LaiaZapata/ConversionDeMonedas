using Microsoft.AspNetCore.Mvc;
using Application.ViewModel;

namespace ConversionDeMonedas.Controllers
{
    public class conversionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ConvertCurrency()
        {
            var model = new conversionViewModel();
            return View("Index", model);
        }

        [HttpPost]
        public IActionResult ConvertCurrency(conversionViewModel model)
        {
            return View("Index", model);
        }

    }
}
