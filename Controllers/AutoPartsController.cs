using CarService.Models;
using CarService.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CarService.Controllers
{
    public class AutoPartsController : Controller
    {
        private readonly IAutoPartstService autoPartstService;
        public AutoPartsController(IAutoPartstService autoPartstService)
        {
            this.autoPartstService = autoPartstService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

       [HttpPost]

        public IActionResult Create(CreateAutoPartsViewModel autoParts)
        {

            autoPartstService.Add(autoParts);
            return RedirectToAction(nameof(Index));



        }

    }
}
