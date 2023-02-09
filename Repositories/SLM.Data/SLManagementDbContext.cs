using Microsoft.EntityFrameworkCore;
using SLM.Data.Models;

namespace SLM.Data
{
	public class SLManagementDbContext : DbContext
	{
		public SLManagementDbContext(DbContextOptions<SLManagementDbContext> options) : base(options)
		{

		}

		//all entities from databse as dbsets
		public DbSet<Courses> Courses { get; set; }
		public DbSet<Lecture> Leacture { get; set; }
		public DbSet<User> User { get; set; }



	}
}