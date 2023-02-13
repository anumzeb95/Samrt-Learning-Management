
using Microsoft.AspNetCore.Identity;
using SLM.DependencyInjection;

namespace SLM.WebApp
{
	public class Program
	{
		public static void Main(string[] args)
		{

            var builder = WebApplication.CreateBuilder(args);
            //            var connectionString = builder.Configuration.GetConnectionString("DbConnection") ?? throw new InvalidOperationException("Connection string 'DbConnection' not found.");

            //            builder.Services.AddDbContext<DbContext>(options =>
            // options.UseSqlServer(connectionString));

            //            builder.Services.AddDefaultIdentity<BaseEntity>(options => options.SignIn.RequireConfirmedAccount = true)
            //.AddEntityFrameworkStores<DbContext>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();
            //builder.Services.AddIdentity<IdentityUser, IdentityRole>();




            //All application DI configyrations
            builder.Services.AppDISetup(builder.Configuration);



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


            app.UseAuthentication();
            app.UseAuthorization();
            app.MapRazorPages();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            //pattern: "{controller=Home}/{action=Homepage}/{id?}");
            //pattern: "{controller=Registration}/{action=Register}/{id?}");

            app.Run();
        }
	}
}