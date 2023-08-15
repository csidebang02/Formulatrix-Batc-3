using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.IO;
namespace SQLite;

public class Northwind: DbContext
{
	private string path = string.Empty;
	public DbSet<Product>? Products { get; set; }
	public DbSet<Category>? Categories { get; set; }
	
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		path = path.Combine(Environment.CurrentDirectory, "Nortwind.db");
		string connectionPath = $"Data Source={path}";
		optionsBuilder.UseSqlite(connectionPath);
	}
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		// Already declared in Category.cs 
		modelBuilder.Entity<Category>()
					.Property(c => c.CategoryName)
					.IsRequired()
					.HasMaxLength(15);

		modelBuilder.Entity<Category>()
					.Property(c => c.CategoryId)
					.HasMaxLength(6);
					
		if (Database.ProviderName?.Contains("Sqlite") ?? false)
		{
			modelBuilder.Entity<Product>()
						.Property(p => p.Cost)
						.HasConversion<double>();
		}
	}
}
