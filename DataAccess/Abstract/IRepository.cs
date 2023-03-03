using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
	public interface IRepository<T>:IDisposable where T:class 
	{
		IEnumerable<T> GetAll();
		T GetItem(object key);
		void add(T item);
		void Remove(T item);
		void Update(T item);
		bool Any(Expression<Func<T,bool>> expression);
	}
}
