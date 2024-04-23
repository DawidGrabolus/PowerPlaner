using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PowerPlaner.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlaner.Infrastructure.Persistence
{
    public class PowerPlanerDbContex : IdentityDbContext<ApplicationUser>
    {
        public PowerPlanerDbContex(DbContextOptions<PowerPlanerDbContex> options) : base(options)
        {

        }
        public DbSet<Domain.Entites.WorkoutSheet> WorkoutSheet { get; set; }

    }
}

    
