using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PowerPlaner.Application.Services;
using PowerPlaner.MVC.Models;
using System.Diagnostics;

namespace PowerPlaner.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWorkoutPlanServices _workoutPlan;

        public HomeController(IWorkoutPlanServices workoutPlan)
        {
            _workoutPlan = workoutPlan;
        }


        public async Task<IActionResult> Index()
        {
            var workoutPlan = await _workoutPlan.GetAll();
            ViewData["WorkoutPlans"] = workoutPlan;
            return View(workoutPlan);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
