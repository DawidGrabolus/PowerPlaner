using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PowerPlaner.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlaner.Infrastructure.Extension
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastcure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PowerPlanerDbContex>(options => options.UseSqlServer(configuration.GetConnectionString("PowerPlaner")));

        }
    }
}
