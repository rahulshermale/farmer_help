using Microsoft.EntityFrameworkCore;

namespace Farmer_DotNet.Model
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Buyer> Employees { set; get; }
        public DbSet<Farmer> Farmers { set; get; }
        public DbSet<Market> Markets { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<Vehical> Vehicals { set; get; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {/*
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
               // .WithMany(d => d.Emplyees)
                .HasForeignKey(e => e.DepartmentId);

            base.OnModelCreating(modelBuilder);*/
        }
    }
}
