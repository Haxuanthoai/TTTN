using Microsoft.AspNetCore.Mvc;

namespace Dev.Controllers
{
    public class CustomerMemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
