using DataAccess;
using DevExpress.XtraEditors;
using KasiyerERP.Formlar;
using KasiyerERP.Formlar.Urunler;
using SiparisTakipApp.Formlar;
using SiparisTakipApp.Formlar.Ayarlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisTakipApp
{
	public partial class Form1 : Form
	{
		Anasayfa anasayfa = new Anasayfa();
		Urunler urunler = new Urunler();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		    anasayfa = new Anasayfa();
			anasayfa.MdiParent = this;
			anasayfa.Show();
		}

		private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			
			anasayfa.SepeteEkle();
		}

		
		private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
		    urunler = new Urunler();
			urunler.MdiParent = this;
			urunler.Show();
		}

		private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

		}

		private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

		}

		private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			KullanıcıAyarlar kullanıcıAyarlar = new KullanıcıAyarlar();
			kullanıcıAyarlar.MdiParent = this;
			kullanıcıAyarlar.Show();
		}

		private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (urunler.urun.UrunTur!=null )
			{
				UrunEkleGuncelle urunEkleGuncelle = new UrunEkleGuncelle();
				urunEkleGuncelle.Text = "Urun Güncelle";
				urunEkleGuncelle.GuncelleButton.Visible = true;
				urunEkleGuncelle.KaydetButton.Visible = false;
				urunEkleGuncelle.urunUpdate = urunler.urun;
				urunEkleGuncelle.TextUpdate();
				if (urunEkleGuncelle.ShowDialog() == DialogResult.Yes)
				{
					urunler.listele();
				}
			}
			else
				XtraMessageBox.Show("Düzenlenicek bir ürün seçilmedi");
			
		}

		private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			UrunTurForm urunTurForm = new UrunTurForm();
			urunTurForm.MdiParent = this;
			urunTurForm.Show();
		}

		private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			UrunEkleGuncelle urunEkleGuncelle = new UrunEkleGuncelle();
			urunEkleGuncelle.Text = "Urun Ekle";
			urunEkleGuncelle.GuncelleButton.Visible = false;
			urunEkleGuncelle.KaydetButton.Visible = true;
			if (urunEkleGuncelle.ShowDialog() == DialogResult.Yes)
			{
				urunler.listele();
			}
		}

		private void ribbonControl1_SelectedPageChanged(object sender, EventArgs e)
		{
			if (ribbonControl1.SelectedPage == ribbonPage1)
			{
				anasayfa = new Anasayfa();
				anasayfa.MdiParent = this;
				anasayfa.Show();
			}
			else
			{
anasayfa.Close();
				anasayfa.Dispose();
			}
				
		}

		private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			SatislarForm satislar = new SatislarForm();
			satislar.MdiParent = this;
			satislar.Show();
		}

		private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			urunler.urunSil();
		}
	}
}
