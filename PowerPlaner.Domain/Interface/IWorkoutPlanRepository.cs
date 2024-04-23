using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlaner.Domain.Interface
{
    public interface IWorkoutPlanRepository
    {

        Task Create(Domain.Entites.WorkoutSheet workoutSheet);

        Task<IEnumerable<Domain.Entites.WorkoutSheet>> GetAll();
    }
}
