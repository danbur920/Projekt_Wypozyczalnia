using Microsoft.EntityFrameworkCore;
using System;

namespace Projekt_ASP_NET.Models
{
    public class RentalSystemDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private string connectionString = "Server=Burazzo\\SQLEXPRESS;Database=RentalSystem;Trusted_Connection=True; TrustServerCertificate=True";
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Hire> Hires { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        public RentalSystemDbContext()
        {
                
        }

        public RentalSystemDbContext(DbContextOptions<RentalSystemDbContext> options, IConfiguration configuration)
       : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>()
            //    .Property(x => x.Title)
            //    .IsRequired();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
