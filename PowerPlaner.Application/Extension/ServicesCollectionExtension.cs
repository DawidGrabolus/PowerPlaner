using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PowerPlaner.Application.Mapping;
using PowerPlaner.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlaner.Application.Extension
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
           services.AddScoped<IWorkoutPlanServices ,  WorkoutPlanServices>();

            services.AddAutoMapper(typeof(WorkoutMappingProfile));
        }
    }
}
