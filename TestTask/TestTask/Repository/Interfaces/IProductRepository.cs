using System.Collections.Generic;
using TestTask.Models;

namespace TestTask.Repository.Interfaces
{
	/// <summary>
	/// IProductRepository
	/// </summary>
	public interface IProductRepository
	{
		/// <summary>
		/// GetProduct
		/// </summary>
		/// <returns></returns>
		IEnumerable<Product> GetProduct();

		/// <summary>
		/// GetProductByID
		/// </summary>
		/// <param name="productId"></param>
		/// <returns></returns>
		Product GetProductByID(int? productId);

		/// <summary>
		/// InsertProduct
		/// </summary>
		/// <param name="product"></param>
		void InsertProduct(Product product);

		/// <summary>
		/// DeleteProduct
		/// </summary>
		/// <param name="productID"></param>
		void DeleteProduct(int productID);

		/// <summary>
		/// UpdateProduct
		/// </summary>
		/// <param name="product"></param>
		void UpdateProduct(Product product);
	}
}
