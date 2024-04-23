using AutoMapper;
using PowerPlaner.Application.PowerPlaner;
using PowerPlaner.Domain.Entites;
using PowerPlaner.Domain.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlaner.Application.Services
{
    internal class WorkoutPlanServices : IWorkoutPlanServices
    {
        private readonly IWorkoutPlanRepository _workoutPlanRepository;
        private readonly IMapper _mapper;

        public WorkoutPlanServices(IWorkoutPlanRepository workoutPlanRepository, IMapper mapper)
        {
            _workoutPlanRepository = workoutPlanRepository;
            _mapper= mapper;
        }
        public async Task Create(WorkoutSheetDto workoutSheetDto)
        {
            var workoutPlan = _mapper.Map<WorkoutSheet>(workoutSheetDto);

            workoutPlan.EncodeName();

            await _workoutPlanRepository.Create(workoutPlan);
        }


        public async Task<IEnumerable<WorkoutSheetDto>> GetAll()
        {

           var workoutPlan = await _workoutPlanRepository.GetAll();
            var dtos = _mapper.Map<IEnumerable<WorkoutSheetDto>>(workoutPlan);

            return dtos;
        }
    }
}
