using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Projekt_ASP_NET.Data;
using Projekt_ASP_NET.Models;
using Projekt_ASP_NET.Repository.Interfaces;
using Projekt_ASP_NET.Repository;
using System.Threading.Tasks;
using Projekt_ASP_NET.Services.Interfaces;
using Projekt_ASP_NET.Services;
using Projekt_ASP_NET.Mappings;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using FluentValidation;
using Projekt_ASP_NET.Validations.Models;
using Projekt_ASP_NET.Validations.ViewModels;

namespace Projekt_ASP_NET
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Dodanie connection stringa (z appsettings.json) do bazy:
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Konfiguracja Identity
            builder.Services.AddDefaultIdentity<User>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            // Dodanie repozytoriów i serwisów:
            builder.Services.AddScoped<IRepository<Branch>, BranchRepository>();
            builder.Services.AddScoped<IRepository<Vehicle>, VehicleRepository>();
            builder.Services.AddScoped<IVehicleService, VehicleService>();
            builder.Services.AddScoped<IBranchService, BranchService>();

            // Dodanie automappera:
            builder.Services.AddAutoMapper(typeof(MappingProfile));

            // Dodanie Razor Pages i Fluent Validation:
            builder.Services.AddRazorPages();
            builder.Services.AddControllersWithViews().AddFluentValidation();

            builder.Services.AddValidatorsFromAssemblyContaining<ReservationValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<RentalValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<UserValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<BranchValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<VehicleValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<RegisterValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<LoginValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<BranchViewModelValidator>();

            // Role:
            using (var scope = builder.Services.BuildServiceProvider().CreateScope())
            {
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                string[] roleNames = { "admin", "operator", "użytkownik" };

                foreach (var roleName in roleNames)
                {
                    var roleExists = await roleManager.RoleExistsAsync(roleName);
                    if (!roleExists)
                    {
                        await roleManager.CreateAsync(new IdentityRole(roleName));
                    }
                }
            }

            // Dodanie autoryzacji i polityk dostępowych:
            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminOrEmployee", policy =>
                    policy.RequireRole("admin", "pracownik"));

                options.AddPolicy("EmployeeOrCustomer", policy =>
                    policy.RequireRole("pracownik", "klient"));
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseStatusCodePagesWithRedirects("/Home/AccessDenied"); // Przekierowanie w momencie braku dostępu
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}