using Model;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class MyDbContext : DbContext
	{
		
		public DbSet<Urun> Urunler { get; set; }
		public DbSet<UrunTur> Turler { get; set; }
		public DbSet<Kullanici> Kullanicilar { get; set; }
		public DbSet<Satis> Satislar { get; set; }
		public DbSet<Satisdetay> Detaylar { get; set; }
		
		public MyDbContext():base("name = MyDbConnString")
		{
			Database.SetInitializer(new MyInitializer());
		}
	}
	public class MyInitializer: CreateDatabaseIfNotExists<MyDbContext>
	{
		protected override void Seed(MyDbContext context)
		{
			context.Kullanicilar.Add(new Kullanici {Id=1, Ad = "Ahmet", Soyad = "Kıdık", Eposta = "admin", Password = "123", yetki = Yetkiler.Admin,Guncellenme_Tarih=DateTime.Now });
			base.Seed(context);	
		}
	}
}
