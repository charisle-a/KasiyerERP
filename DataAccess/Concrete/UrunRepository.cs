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
	public class UrunRepository : Repository<Urun>, IUrunRepository
	{
		public UrunRepository(DbContext dbContext) : base(dbContext)
		{

		}
		public IEnumerable<Urun> GetAllWithTur()
		{
			return dbContext.Set<Urun>().Include(u => u.UrunTur).ToList();
		}
		
		public Urun GetByIdWithTur(int Id)
		{
			return dbContext.Set<Urun>().Include(x => x.UrunTur).FirstOrDefault(x => x.Id == Id);
		}
	}
}
