
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
	[Table("tblSatislar")]
	public class Satis:Base
	{
		

		public decimal ToplamTutar { get; set; }
		//public virtual ICollection<Satisdetay> Detaylar { get; set; } 
	}
}
