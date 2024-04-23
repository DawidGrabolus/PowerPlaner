using Microsoft.EntityFrameworkCore;
using PowerPlaner.Domain.Entites;
using PowerPlaner.Domain.Interface;
using PowerPlaner.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlaner.Infrastructure.Repository
{
    internal class WorkoutPlanRepository : IWorkoutPlanRepository
    {

        private readonly PowerPlanerDbContex _dbContext;

        public WorkoutPlanRepository(PowerPlanerDbContex dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Domain.Entites.WorkoutSheet workoutSheet)
        {
           _dbContext.Add(workoutSheet);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<WorkoutSheet>> GetAll()
        => await _dbContext.WorkoutSheet.ToListAsync();
    }
}
