using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlaner.Infrastructure.Persistence
{
    public class PowerPlanerDbContex : DbContext
    {
        public PowerPlanerDbContex(DbContextOptions<PowerPlanerDbContex> options) : base(options)
        {

        }
        public DbSet<Domain.Entites.User> User {  get; set; }

    }
}
