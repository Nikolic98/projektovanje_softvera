using Microsoft.AspNetCore.Mvc;
using ESCOOTERRENT.Services;

namespace ESCOOTERRENT.WEB.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreService storeService;
  
        public StoreController(IStoreService storeService)
        {
            this.storeService = storeService;
        }
        public IActionResult Stores()
        {
            return View(storeService.ReadAll());
        }     
    }
}
