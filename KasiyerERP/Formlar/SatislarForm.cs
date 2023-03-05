using DataAccess;
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
	public partial class SatislarForm : Form
	{
		int Id = 0;
		public SatislarForm()
		{
			InitializeComponent();
		}
		void listele()
		{
			using (UnitOfWork unitOf=new UnitOfWork())
			{
				gridControl1.DataSource = unitOf.satisWork.GetAll();
			}
			gridControl1.RefreshDataSource();
		}
		private void SatislarForm_Load(object sender, EventArgs e)
		{
			
			gridControl1.Height=this.Size.Height;
			listele();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id") != null)
			{
				Id=(int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id");
			}
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			SatisDetaylarForm satisDetaylarForm = new SatisDetaylarForm();
			satisDetaylarForm.Id = Id;
			satisDetaylarForm.Show();
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			listele();
			
		}
	}
}
