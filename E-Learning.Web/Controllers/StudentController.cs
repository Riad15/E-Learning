using Microsoft.AspNetCore.Mvc;

namespace E_Learning.Web.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
