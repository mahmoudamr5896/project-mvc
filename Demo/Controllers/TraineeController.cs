using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo.Controllers
{
    public class TraineeController : Controller
    {
        ITI_ENTITY context = new ITI_ENTITY();

        public IActionResult Index()
        {
            // Retrieve all trainees and pass them to the view
            List<Trainee> trainees = context.Trainees.ToList();
            return View(trainees);
        }

        public IActionResult Detail(int id)
        {
            // Retrieve CrsResults for a specific trainee
            List<CrsResult> results = context.CrsResults
                .Include(cr => cr.Courses)  // Include related Course
                .Include(cr => cr.Trainee) // Include related Trainee
                .Where(cr => cr.Trainee_ID == id) // Filter by Trainee_ID
                .ToList();

            // Pass the results to the view
            return View(results);
        }
    }
}
