using PowerPlaner.Application.PowerPlaner;
using PowerPlaner.Domain.Entites;

namespace PowerPlaner.Application.Services
{
    public interface IWorkoutPlanServices
    {
        Task Create(WorkoutSheetDto workoutSheetDto);
        Task<IEnumerable<WorkoutSheetDto>> GetAll();
    }
}