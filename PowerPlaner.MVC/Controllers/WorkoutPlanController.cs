using Microsoft.AspNetCore.Mvc;
using PowerPlaner.Application.Services;
using PowerPlaner.Application.PowerPlaner;
using PowerPlaner.Domain.Entites;

namespace PowerPlaner.MVC.Controllers
{
    public class WorkoutPlanController : Controller
    {
        private readonly IWorkoutPlanServices _workoutPlan;

        public WorkoutPlanController(IWorkoutPlanServices workoutPlan) {
            _workoutPlan = workoutPlan;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlan(WorkoutSheetDto WorkoutSheetDto)
        {
           await _workoutPlan.Create(WorkoutSheetDto);

            return View();
        }
        public async Task<IActionResult> Index()
        {
            var workoutPlan = await _workoutPlan.GetAll();
            return View(workoutPlan);
        }

        public IActionResult ReadyPlans()
        {
            return View();
        }
        public IActionResult CreatePlan()
        {
            return View();
        }
        public IActionResult YourPlans()
        {
            return View();
        }
        public IActionResult Instruction()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
    }
}
