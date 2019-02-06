using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TestTask.Models;

namespace TestTask.DAL
{
	/// <summary>
	/// Context
	/// </summary>
	public class TestTaskContext : DbContext
	{
		/// <summary>
		/// .ctor
		/// </summary>
		public TestTaskContext() : base("TestTaskContext")
		{
		}

		/// <summary>
		/// DbStores
		/// </summary>
		public DbSet<Store> Stores { get; set; }

		/// <summary>
		/// DbProducts
		/// </summary>
		public DbSet<Product> Products { get; set; }

		/// <summary>
		/// OnModelCreating
		/// </summary>
		/// <param name="modelBuilder"></param>
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

			modelBuilder.Entity<Store>()
				.HasMany(x => x.Products)
				.WithMany(p => p.Stores)
				.Map(t => t.MapLeftKey("StoreId")
					.MapRightKey("ProductId")
					.ToTable("StoreProduct"));
		}
	}
}