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
	public partial class SatisForm : Form
	{
		public List<Satisdetay> newsatis = new List<Satisdetay>();
		decimal toplamTutar=0;
		public SatisForm()
		{
			InitializeComponent();
		}

		private void SatisForm_Load(object sender, EventArgs e)
		{
			gridControl3.DataSource = newsatis;
			toplamTutar = newsatis.Sum(x => x.Tutar);
			TutarLabel.Text = toplamTutar.ToString();
			gridControl3.RefreshDataSource();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			

			using (UnitOfWork unitOf = new UnitOfWork())
			{
				Satis satis = new Satis();
				satis=unitOf.satisWork.Add(new Satis {Guncellenme_Tarih=DateTime.Now,ToplamTutar=toplamTutar });
				foreach(var item in newsatis)
				{
					item.SatisId = satis.Id;
					unitOf.detayWork.SatisDetayAdd(item);
					
				}
				unitOf.Save();

			}
			decimal nakit=0;
			if (textEdit1.Text!="")
			 nakit = Convert.ToDecimal(textEdit1.Text);
			if (nakit>toplamTutar)
			{
				XtraMessageBox.Show("Para üstü "+(nakit-toplamTutar));
			}
			this.Close();

		}
	}
}
