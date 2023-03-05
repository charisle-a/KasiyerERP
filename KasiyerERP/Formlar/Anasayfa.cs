using DataAccess;
using KasiyerERP.Formlar;
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

namespace SiparisTakipApp.Formlar
{
	public partial class Anasayfa : Form
	{
		List<Satisdetay> newsatis = new List<Satisdetay>();
		
		
		public Anasayfa()
		{
			InitializeComponent();
		}
		public void SepeteEkle()
		{ 
			using (UnitOfWork unitOf = new UnitOfWork())
			{
				SepeteEkleForm sepeteEkleForm = new SepeteEkleForm();
				sepeteEkleForm.textEdit1.Text =unitOf.UrunWork.GetItem((int)tileView2.GetRowCellValue(tileView2.FocusedRowHandle, "Id")).Ad;


				if (sepeteEkleForm.ShowDialog()==DialogResult.Yes)
				{
					
					Satisdetay satisdetay = new Satisdetay()
					{
						Adet = Convert.ToInt32(sepeteEkleForm.textEdit2.Text),
						UrunId = (int)tileView2.GetRowCellValue(tileView2.FocusedRowHandle, "Id"),
						Tutar = (decimal)tileView2.GetRowCellValue(tileView2.FocusedRowHandle, "Fiyat")* Convert.ToInt32(sepeteEkleForm.textEdit2.Text),
						Urun = unitOf.UrunWork.GetItem((int)tileView2.GetRowCellValue(tileView2.FocusedRowHandle, "Id"))
					};
					newsatis.Add(satisdetay);
					gridControl3.DataSource = newsatis;
					gridControl3.RefreshDataSource();
				}
				
			}
				

			
		}
		public void listeleUrun()
		{
			using (UnitOfWork unitOf = new UnitOfWork())
			{
				gridControl1.DataSource = unitOf.TurWork.GetAll();
				
			}
		}

		private void Anasayfa_Load(object sender, EventArgs e)
		{gridControl1.Height = this.Height;
			gridControl2.Height = this.Height;
			listeleUrun();
			


		}

		private void tileView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			int Id = (int)tileView1.GetRowCellValue(tileView1.FocusedRowHandle, "Id");
			using (UnitOfWork unitOf = new UnitOfWork())
			{
				gridControl2.DataSource = unitOf.UrunWork.GetAllWithTur().Where(x => x.TurId == Id);
			}
		}

		private void tileView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			//satisdetay.UrunId=(int)tileView2.GetRowCellValue(tileView1.FocusedRowHandle, "Id");
			//satisdetay.Guncellenme_Tarih = DateTime.Now;
			//satisdetay.Tutar=(int)tileView2.GetRowCellValue(tileView1.FocusedRowHandle, "Fiyat");
			
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			SatisForm satisForm = new SatisForm();
			satisForm.newsatis = newsatis;
			satisForm.Show();
			this.Refresh();
			listeleUrun();
		}
	}
}
