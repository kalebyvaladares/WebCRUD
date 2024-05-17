using Microsoft.AspNetCore.Mvc;

namespace WebCRUD.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
