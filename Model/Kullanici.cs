using SiparisTakip.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public enum Yetkiler
	{
		Admin=1,
		Kasiyer=2
	}
	[Table("tblKullanicilar")]
	public class Kullanici:Base
	{
		
		public string Eposta { get; set; }
		public string Password { get; set; }
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public Yetkiler yetki { get; set; }
	}
}
