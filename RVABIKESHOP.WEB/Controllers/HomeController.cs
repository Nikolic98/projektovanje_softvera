using Microsoft.AspNetCore.Mvc;
using ESCOOTERRENT.Services;

namespace ESCOOTERRENT.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IScooterService scooterService;
        private readonly IStoreService storeService;
        private readonly ITypeService typeService;

        public HomeController(IScooterService scooterService, IStoreService storeService, ITypeService typeService)
        {
            this.scooterService = scooterService;
            this.storeService = storeService;
            this.typeService = typeService;
        }

        public IActionResult Index()
        {
            ViewData["StoresList"] = storeService.ReadAll();
            ViewData["TypesList"] = typeService.ReadAll();
            return View(scooterService.ReadAll());
        }

        public IActionResult Rent(int id)
        {
            return View(scooterService.ReadOne(id));
        }        
    }
}