using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Model
{
	public abstract class Base
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public DateTime Eklenme_Tarih { get; set; } = DateTime.Now;
		public DateTime? Guncellenme_Tarih { get; set; }
	}
}
