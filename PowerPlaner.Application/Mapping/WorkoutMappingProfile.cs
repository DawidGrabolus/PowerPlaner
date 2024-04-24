using AutoMapper;
using PowerPlaner.Application.PowerPlaner;
using PowerPlaner.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlaner.Application.Mapping
{
    internal class WorkoutMappingProfile : Profile
    {
        public WorkoutMappingProfile()
        {
            CreateMap<WorkoutSheetDto, WorkoutSheet>().ReverseMap(); // Dodaj ReverseMap()
        }
    }
}
