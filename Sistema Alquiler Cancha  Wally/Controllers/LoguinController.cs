using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_Alquiler_Cancha__Wally.Context;
using Sistema_Alquiler_Cancha__Wally.Models;

namespace Sistema_Alquiler_Cancha__Wally.Controllers
{
    public class LoguinController : Controller
    {
        private MyContext _Context;
        public LoguinController(MyContext context)
        {
            _Context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        //crud login
        [HttpPost]
        public async Task<IActionResult> Login(String email, String password)
        {
            var usuario = await _Context.Usuarios
                           .Where(x => x.Email == email)
                           .Where(x=>x.Password == password)
                          .FirstOrDefaultAsync();
            if (usuario != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                //mandando mensajes a la vista
                TempData["LoginError"] = "Cuenta o Password incorrectos!";
                return RedirectToAction("Index", "Login");
            }
        }

        public async Task<IActionResult> Logout()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}
