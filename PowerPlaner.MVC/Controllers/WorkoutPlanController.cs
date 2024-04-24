using Microsoft.AspNetCore.Mvc;
using PowerPlaner.Application.Services;
using PowerPlaner.Application.PowerPlaner;
using PowerPlaner.Domain.Entites;
using System.Threading.Tasks;
using PowerPlaner.Domain.Entities;
using PowerPlaner.Domain.Interface;

namespace PowerPlaner.MVC.Controllers
{
    public class WorkoutPlanController : Controller
    {
        private readonly IWorkoutPlanServices _workoutPlan;
        private readonly IWorkoutPlanServices _workoutPlanService;

        public WorkoutPlanController(IWorkoutPlanServices workoutPlan, IWorkoutPlanServices workoutPlanServices)
        {
            _workoutPlan = workoutPlan;
            _workoutPlanService = workoutPlanServices;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlan(WorkoutSheetDto WorkoutSheetDto)
        {
            await _workoutPlan.Create(WorkoutSheetDto);
            var workoutPlan = await _workoutPlan.GetAll();
            ViewData["WorkoutPlans"] = workoutPlan;
            return View(workoutPlan);
        }

        public async Task<IActionResult> YourPlans()
        {
            var workoutPlan = await _workoutPlan.GetAll();
            ViewData["WorkoutPlans"] = workoutPlan;
            return View(workoutPlan);
        }

        public async Task<IActionResult> ReadyPlans()
        {
            var workoutPlan = await _workoutPlan.GetAll();
            ViewData["WorkoutPlans"] = workoutPlan;
            return View(workoutPlan);
        }

        public async Task<IActionResult> CreatePlan()
        {
            var workoutPlan = await _workoutPlan.GetAll();
            ViewData["WorkoutPlans"] = workoutPlan;
            return View(workoutPlan);
        }
        public async Task<IActionResult> Instruction()
        {
            var workoutPlan = await _workoutPlan.GetAll();
            ViewData["WorkoutPlans"] = workoutPlan;
            return View(workoutPlan);
        }
        public async Task<IActionResult> Profile()
        {
            var workoutPlan = await _workoutPlan.GetAll();
            ViewData["WorkoutPlans"] = workoutPlan;
            return View(workoutPlan);
        }

        public async Task<IActionResult> Index()
        {
            var workoutPlan = await _workoutPlan.GetAll();
            ViewData["WorkoutPlans"] = workoutPlan;
            return View(workoutPlan);
        }

        public async Task<IActionResult> CreateSchedule()
        {
            var workoutPlan = await _workoutPlan.GetAll();
            ViewData["WorkoutPlans"] = workoutPlan;
            return View(workoutPlan);
        }
    }
}
