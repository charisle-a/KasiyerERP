using Model;
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
	[Table("tblSatisDetaylar")]
	public class Satisdetay:Base
	{
		
		public int Adet { get; set; }
		public decimal Tutar { get; set; }
		[ForeignKey("Urun")]
		public int UrunId { get; set; }
		public Urun Urun { get; set; }
		public int SatisId { get; set; }
	}
}
