using Microsoft.EntityFrameworkCore;
using SLM.Data.Models;
using SM.Data.Models;

namespace SLM.Data
{
    public class SLManagementDbContext : DbContext
    {
        public DbSet<Courses>Courses { get; set; }
    }
}