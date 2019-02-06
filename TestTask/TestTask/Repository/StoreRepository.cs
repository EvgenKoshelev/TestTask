using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestTask.DAL;
using TestTask.Models;
using TestTask.Repository.Interfaces;

namespace TestTask.Repository
{
	/// <summary>
	/// StoreRepository
	/// </summary>
	public class StoreRepository : IStoreRepository
	{
		private TestTaskContext context;

		/// <summary>
		/// .ctror
		/// </summary>
		/// <param name="context"></param>
		public StoreRepository(TestTaskContext context)
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
		/// GetStore
		/// </summary>
		/// <returns></returns>
		public IEnumerable<Store> GetStore()
		{
			return context.Stores.ToList();
		}

		/// <summary>
		/// GetStoreByID
		/// </summary>
		/// <param name="storeId"></param>
		/// <returns></returns>
		public Store GetStoreByID(int? storeId)
		{
			return context.Stores.Find(storeId);
		}

		/// <summary>
		/// InsertStore
		/// </summary>
		/// <param name="store"></param>
		public void InsertStore(Store store)
		{
			context.Stores.Add(store);
			context.SaveChanges();
		}

		/// <summary>
		/// DeleteStore
		/// </summary>
		/// <param name="storeID"></param>
		public void DeleteStore(int storeID)
		{
			Store store = context.Stores.Find(storeID);
			context.Stores.Remove(store);
			context.SaveChanges();
		}

		/// <summary>
		/// UpdateStore
		/// </summary>
		/// <param name="store"></param>
		public void UpdateStore(Store store)
		{
			context.Entry(store).State = EntityState.Modified;
			context.SaveChanges();
		}
	}
}