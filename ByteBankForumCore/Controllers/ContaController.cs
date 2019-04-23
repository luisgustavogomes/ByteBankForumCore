using ByteBankForumCore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ByteBankForumCore.Controllers
{
    public class ContaController : Controller
    {

        public IActionResult Registrar()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registrar(ContaRegistrarViewModel model)
        {
            return View();
        }
    }
}
