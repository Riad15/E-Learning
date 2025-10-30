using E_Learning.Bll.Services;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService _studentService;
        public StudentController( StudentService studentService ) { 
         
          _studentService = studentService;
        }
        public IActionResult Index()
        {
            var students = _studentService.GetAllStudents();

            return View(students);
        }
    }
}
