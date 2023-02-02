using Microsoft.EntityFrameworkCore;
using SLM.Bussiness.DataServices;
using SLM.Bussiness.DataServices.Interfaces;
using SLM.Data;

namespace SLM.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //Configure entity framework
            builder.Services.AddDbContext<SLManagementDbContext>(
            options => options.UseSqlServer("Data Source= localhost; Database = SLMSystem; Integrated Security=SSPI; TrustServerCertificate=True;"));



            //all of the custom configuration
            builder.Services.AddScoped<ICourseService, CoursesService>();
            
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}