using AutoMapper;
using PowerPlaner.Application.PowerPlaner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlaner.Application.Mapping
{
    internal class WorkoutMappingProfile : Profile
    {
        public WorkoutMappingProfile() {
            CreateMap<WorkoutSheetDto, Domain.Entites.WorkoutSheet>();
        }
    }
}
