using System;
using System.Collections.Generic;
using TestTask.Models;

namespace TestTask.Repository.Interfaces
{
	/// <summary>
	/// IStoreRepository
	/// </summary>
	public interface IStoreRepository : IDisposable
	{
		/// <summary>
		/// GetStore
		/// </summary>
		/// <returns></returns>
		IEnumerable<Store> GetStore();

		/// <summary>
		/// GetStoreByID
		/// </summary>
		/// <param name="storeId"></param>
		/// <returns></returns>
		Store GetStoreByID(int? storeId);

		/// <summary>
		/// InsertStore
		/// </summary>
		/// <param name="store"></param>
		void InsertStore(Store store);

		/// <summary>
		/// DeleteStore		/// </summary>
		/// <param name="storeID"></param>
		void DeleteStore(int storeID);

		/// <summary>
		/// UpdateStore
		/// </summary>
		/// <param name="store"></param>
		void UpdateStore(Store store);
	}
}
