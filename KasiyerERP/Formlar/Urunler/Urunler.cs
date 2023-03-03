﻿using DataAccess;
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

namespace KasiyerERP.Formlar.Urunler
{
	public partial class Urunler : Form
	{
		public Urun urun = new Urun();
		public Urunler()
		{
			InitializeComponent();
		}
		public void listele()
		{
			using (UnitOfWork unitOf = new UnitOfWork())
			{
				gridControl1.DataSource = unitOf.UrunWork.GetAllWithTur();
			}

		}
		private void Urunler_Load(object sender, EventArgs e)
		{
			listele();
			gridControl1.Size = this.Size;
		}
		
		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			
				if(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id")!=null)
				{
            urun.Id=(int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id");
			urun.Ad= (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ad");
			urun.Fiyat= (decimal)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Fiyat");
			urun.TurId= (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TurId");
			urun.UrunTur=(UrunTur)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "UrunTur");

				}
            

			
			

		}
	}
}
