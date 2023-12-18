using Microsoft.EntityFrameworkCore;
using GestorNomina2.Shared;
using Microsoft.Extensions.Options;


namespace GestorNomina2.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


        public DbSet<Empleado> Empleados { get; set; }
    }
}

