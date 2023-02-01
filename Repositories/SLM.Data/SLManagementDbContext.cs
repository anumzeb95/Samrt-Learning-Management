using Microsoft.EntityFrameworkCore;
using SLM.Data.Models;


namespace SLM.Data
{
    public class SLManagementDbContext : DbContext
    {
        public SLManagementDbContext (DbContextOptions<SLManagementDbContext> options) : base(options)
        {

        }
        public DbSet<Courses>Courses { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlServer($"Data Source={DbPath}");
        //}


    }
}