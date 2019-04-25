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
            if (ModelState.IsValid)
            {

                //var dbContext = new IdentityDbContext<UsuarioAplicacao>();
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}
