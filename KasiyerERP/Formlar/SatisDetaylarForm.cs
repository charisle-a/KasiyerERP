using DataAccess;
using DevExpress.XtraEditors;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasiyerERP.Formlar
{
	public partial class SatisDetaylarForm : Form
	{
		public int Id = -1;
		public SatisDetaylarForm()
		{
			InitializeComponent();
		}

		private void SatisDetaylarForm_Load(object sender, EventArgs e)
		{
			if(Id>-1)
			{
				using (UnitOfWork unitOf=new UnitOfWork())
				{
					gridControl1.DataSource = unitOf.detayWork.GetAllWithUrun().Where(x=>x.SatisId==Id);
				}
			}
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			
			if(Id>-1)
			{
				if (XtraMessageBox.Show("Satış iptal edilsin mi?","Satış iptal",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
				{
				using (UnitOfWork unitOf=new UnitOfWork())
				{
					List<Satisdetay> satisdetaylar = new List<Satisdetay>();
					foreach(var item in unitOf.detayWork.GetAll().Where(x => x.SatisId == Id))
					{
						unitOf.detayWork.Remove(item);
						
					
					}
					unitOf.satisWork.Remove(unitOf.satisWork.GetItem(Id));
					unitOf.Save();
						this.Close();
				}
				}
				
			}
		}
	}
}
