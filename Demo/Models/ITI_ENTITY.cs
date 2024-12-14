using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Demo.Models
{
    public class ITI_ENTITY : IdentityDbContext<Applicationuser>
    {
        public ITI_ENTITY():base() { }
       
        public ITI_ENTITY(DbContextOptions options) : base(options) { }
       

        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructor {  get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<CrsResult>  CrsResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Integrated Security=True;Initial Catalog=ITI_DOTNET;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
