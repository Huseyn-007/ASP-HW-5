using Microsoft.AspNetCore.Mvc;

namespace WebAbiHomework5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
