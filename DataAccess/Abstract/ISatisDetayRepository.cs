using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
	public interface ISatisDetayRepository:IRepository<Satisdetay>
	{
		IEnumerable<Satisdetay> GetAllWithUrun();
		void SatisDetayAdd(Satisdetay satisdetay);
		
	}
}
