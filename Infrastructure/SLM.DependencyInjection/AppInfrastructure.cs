using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SLM.Bussines.Interfaces;
using SLM.Bussiness.DataServices;
using SLM.Bussiness.Interfaces;
using SLM.Data;
using SLM.Data.Interfaces;

namespace SLM.DependencyInjection
{
    public static class AppInfrastructure
    {
        public static void AppDISetup (this IServiceCollection services, IConfiguration configuration )
        {
           

            //Configure entity framework
            services.AddDbContext<SLManagementDbContext>(
            options => options.
            UseSqlServer(configuration.GetConnectionString("DbConnection")));


            //repositories configuration
            services.AddScoped(typeof (IRepository<>), typeof(Repository<>));

            //setting configuration for authentication
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie((CookieOptions)=>
            {
                CookieOptions.LoginPath = "/Authentication/Login";
                CookieOptions.Cookie = new CookieBuilder
                {
                    Name = "SmartLearningManagementCookie"
                };
            });

            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie((CookieOptions) =>
            //{
            //    CookieOptions.LogoutPath = "/Authentication.Logout";
            //});

            //all of the custom configuration
            services.AddScoped<ICourseService, CoursesService>();
            services.AddScoped<ILectureService, LectureService>();

            //automapper configuration
            services.AddAutoMapper(typeof(BussinessEntityMappings));
        }

    }
}