using JuernesCochesApiNuget;
using JuernesCochesApiNuget.Models;
using Microsoft.AspNetCore.Mvc;

namespace MvcCoreCochesApiNuget.Controllers
{
    public class CochesController : Controller
    {
        public async Task<IActionResult> Index()
        {
            CochesContext context = new CochesContext();
            List<Coche> coches = await context.GetCochesAsync();
            return View(coches);
        }
    }
}
