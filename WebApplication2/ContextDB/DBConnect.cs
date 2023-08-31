using Microsoft.EntityFrameworkCore;
using Prova.Models;

namespace Prova.ContextDB
{
	public class DBConnect : DbContext
	{
		protected readonly IConfiguration Configuration;

		public DBConnect(IConfiguration configuration, DbContextOptions<DBConnect> options) : base(options)
		{
			Configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			IConfiguration configuration = new ConfigurationBuilder()
			 .SetBasePath(Directory.GetCurrentDirectory())
			 .AddJsonFile("appsettings.json", false, true)
			 .Build();
			options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Order>()
		   .HasOne(o => o.Active)         // Order has one Active
		   .WithMany(a => a.Orders)       // Active has many Orders
		   .HasForeignKey(o => o.CodeId); // Foreign key
		}

		public DbSet<Active> Actives { get; set; }
		public DbSet<Order> Orders { get; set; }
	}
}
