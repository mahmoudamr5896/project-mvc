using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class InstructorController : Controller
    {
        ITI_ENTITY context = new ITI_ENTITY();
        public IActionResult Index()
        {
            List<Instructor> instructors = context.Instructor.ToList();
            return View(instructors);
        }
    }
}
