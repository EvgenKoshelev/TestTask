using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TestTask.DAL;
using TestTask.Models;
using TestTask.Repository.Interfaces;

namespace TestTask.Repository
{
	/// <summary>
	/// ProductRepository
	/// </summary>
	public class ProductRepository : IProductRepository
	{
		private TestTaskContext context;

		/// <summary>
		/// .ctor
		/// </summary>
		/// <param name="context"></param>
		public ProductRepository(TestTaskContext context)
		{
			this.context = context;
		}

		/// <summary>
		/// Dispose
		/// </summary>
		public void Dispose()
		{
			context.Dispose();
		}

		/// <summary>
		/// GetProduct
		/// </summary>
		/// <returns></returns>
		public IEnumerable<Product> GetProduct()
		{
			return context.Products.ToList();
		}

		/// <summary>
		/// GetProductByID
		/// </summary>
		/// <param name="productId"></param>
		/// <returns></returns>
		public Product GetProductByID(int? productId)
		{
			return context.Products.Find(productId);
		}

		/// <summary>
		/// InsertProduct
		/// </summary>
		/// <param name="product"></param>
		public void InsertProduct(Product product)
		{
			context.Products.Add(product);
			context.SaveChanges();
		}

		/// <summary>
		/// DeleteProduct
		/// </summary>
		/// <param name="productId"></param>
		public void DeleteProduct(int productId)
		{
			Product product = context.Products.Find(productId);
			context.Products.Remove(product);
			context.SaveChanges();
		}

		/// <summary>
		/// UpdateProduct
		/// </summary>
		/// <param name="product"></param>
		public void UpdateProduct(Product product)
		{
			context.Entry(product).State = EntityState.Modified;
			context.SaveChanges();
		}
	}
}