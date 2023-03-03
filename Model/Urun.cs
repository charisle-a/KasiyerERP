
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
	[Table("tblUrunler")]
	public class Urun:Base
	{
		
		public string Ad { get; set; }
		public decimal Fiyat { get; set; }
		[ForeignKey("UrunTur")]
		public int TurId { get; set; }
		public UrunTur UrunTur { get; set; }
	}
}
