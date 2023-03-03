using DataAccess.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
	public class SatisDetayRepository : Repository<Satisdetay>, ISatisDetayRepository
	{
		public SatisDetayRepository(DbContext dbContext):base(dbContext)
		{

		}
		public IEnumerable<Satisdetay> GetAllWithUrun()
		{
			return dbContext.Set<Satisdetay>().Include(s => s.Urun).ToList();	
		}
	}
}
