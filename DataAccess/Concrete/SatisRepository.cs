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
	public class SatisRepository : Repository<Satis>, ISatisRepository
	{
		public SatisRepository(DbContext dbContext) : base(dbContext)
		{

		}
		public Satis Add(Satis satis)
		{
			 dbContext.Set<Satis>().Add(satis);
			dbContext.SaveChanges();
			return satis;
		}
	}
}
