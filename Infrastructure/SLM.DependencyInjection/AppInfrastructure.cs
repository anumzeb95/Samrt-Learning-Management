using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SLM.Bussines.Interfaces;
using SLM.Bussiness.DataServices;
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

            //all of the custom configuration
            services.AddScoped<ICourseService, CoursesService>();

            //automapper configuration
            services.AddAutoMapper(typeof(BussinessEntityMappings));
        }

    }
}