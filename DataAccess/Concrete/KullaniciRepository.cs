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
	public class KullaniciRepository : Repository<Kullanici>, IKullaniciRepository
	{
		public KullaniciRepository(DbContext dbContext):base(dbContext)
		{

		}
		public bool Login(string eposta, string password)
		{
			if (dbContext.Set<Kullanici>().FirstOrDefault(x => x.Eposta.ToLower().Equals(eposta.ToLower()) && x.Password.Equals(password)) != null)
				return true;
			else
				return false;

			
		}
	}
}
