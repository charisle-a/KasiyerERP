
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
	[Table("tblUrunTurler")]
	public class UrunTur:Base
	{
		
		public string Ad { get; set; }
		
	}
}
