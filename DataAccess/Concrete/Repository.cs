using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
	public class Repository<T> : IRepository<T> where T : class
	{
		protected readonly DbContext dbContext;
		public Repository(DbContext dbContext)
		{
			this.dbContext = dbContext;
		}
		public void add(T item)
		{
			dbContext.Set<T>().Add(item);
		}

		public bool Any(Expression<Func<T,bool>> expression)
		{
			return dbContext.Set<T>().Any(expression);
		}

		public void Dispose()
		{
			dbContext?.Dispose();
			GC.SuppressFinalize(this);
		}

		public IEnumerable<T> GetAll()
		{
			return dbContext.Set<T>().ToList();
		}

		public T GetItem(object key)
		{
			return dbContext.Set<T>().Find(key);
		}

		public void Remove(T item)
		{
			if (dbContext.Entry<T>(item).State == EntityState.Detached)
				dbContext.Set<T>().Attach(item);
			dbContext.Entry<T>(item).State = EntityState.Deleted;
		}

		public void Update(T item)
		{
			if (dbContext.Entry<T>(item).State == EntityState.Detached)
				dbContext.Set<T>().Attach(item);
			dbContext.Entry<T>(item).State = EntityState.Modified;
		}
	}
}
