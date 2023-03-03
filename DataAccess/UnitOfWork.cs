using DataAccess.Concrete;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class UnitOfWork:IDisposable
	{
		private readonly MyDbContext context;

		private UrunRepository urunRepo;
		private Repository<UrunTur> turRepo;
		private KullaniciRepository kullaniciRepo;
		private Repository<Satis> satisRepo;
		private SatisDetayRepository detayRepo;
	

		public UrunRepository UrunWork
		{
			get
			{
				if (urunRepo == null)
					urunRepo = new UrunRepository(context);
				return urunRepo;
			}
		}
		public Repository<UrunTur> TurWork
		{
			get
			{
				if (turRepo == null)
					turRepo = new Repository<UrunTur>(context);
				return turRepo;
			}
		}
		public KullaniciRepository kullaniciWork
		{
			get
			{
				if (kullaniciRepo == null)
					kullaniciRepo = new KullaniciRepository(context);
				return kullaniciRepo;
			}
		}
		public Repository<Satis> satisWork
		{
			get
			{
				if (satisRepo == null)
					satisRepo = new Repository<Satis>(context);
				return satisRepo;
			}
		}
		public SatisDetayRepository detayWork
		{
			get
			{
				if (detayRepo == null)
					detayRepo = new SatisDetayRepository(context);
				return detayRepo;
			}
		}
	

		public UnitOfWork()
		{
			context = new MyDbContext();
		}
		public void Save()
		{
			using (var transaction=context.Database.BeginTransaction())
			{
				try
				{
					context.SaveChanges();
					transaction.Commit();
				}
				catch (Exception ex)
				{
					transaction.Rollback();
					throw ex;
				}
			}
		}

		public void Dispose()
		{
			urunRepo?.Dispose();
			turRepo?.Dispose();
			satisRepo?.Dispose();
			detayRepo?.Dispose();
			kullaniciRepo?.Dispose();
		
			GC.SuppressFinalize(this);
		}
	}
}
