using DataAccess;
using DevExpress.LookAndFeel;
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

namespace SiparisTakipApp.Formlar.Ayarlar
{
	public partial class KullanıcıAyarlar : Form
	{
		Kullanici kul = new Kullanici();

		public KullanıcıAyarlar()
		{
			InitializeComponent();
		}
		void listele()
		{
			using (UnitOfWork unitOf = new UnitOfWork())
			{
				gridControl1.DataSource = unitOf.kullaniciWork.GetAll();
			}

		}
		private void KullanıcıAyarlar_Load(object sender, EventArgs e)
		{
			listele();

			foreach (string yetki in Enum.GetNames(typeof(Yetkiler)))
			{
				comboBoxEdit1.Properties.Items.Add(yetki);
			}

		}



		private void cardView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{


			textEdit1.Text = cardView1.GetRowCellValue(cardView1.FocusedRowHandle, "Eposta").ToString();
			textEdit2.Text = cardView1.GetRowCellValue(cardView1.FocusedRowHandle, "Password").ToString();
			comboBoxEdit1.Text = cardView1.GetRowCellValue(cardView1.FocusedRowHandle, "yetki").ToString();
			textEdit4.Text = cardView1.GetRowCellValue(cardView1.FocusedRowHandle, "Ad").ToString();
			textEdit5.Text = cardView1.GetRowCellValue(cardView1.FocusedRowHandle, "Soyad").ToString();
			kul.Id=(int)cardView1.GetRowCellValue(cardView1.FocusedRowHandle, "Id");
			kul.Eposta = cardView1.GetRowCellValue(cardView1.FocusedRowHandle, "Eposta").ToString(); 
			kul.Password= cardView1.GetRowCellValue(cardView1.FocusedRowHandle, "Password").ToString();
			switch (cardView1.GetRowCellValue(cardView1.FocusedRowHandle, "yetki").ToString())
			{
				case "Admin":
					kul.yetki = Yetkiler.Admin;
					break;
				case "Kasiyer":
					kul.yetki = Yetkiler.Kasiyer;
					break;
			}
			kul.Ad = cardView1.GetRowCellValue(cardView1.FocusedRowHandle, "Ad").ToString();
			kul.Soyad= cardView1.GetRowCellValue(cardView1.FocusedRowHandle, "Password").ToString();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			if (textEdit1.Text == "" || textEdit2.Text == "" || textEdit4.Text == "" || textEdit5.Text == "" || comboBoxEdit1.Text == "")
			{

				XtraMessageBox.Show("Eklemeden önce boşlukları doğru doldurduğunuzdan emin olun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


			}
			else
			{
				if(XtraMessageBox.Show(textEdit1.Text + " Kaydını eklemek istediğinize emin misiniz?", "Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
using (UnitOfWork unitOf = new UnitOfWork())
				{
					if (unitOf.kullaniciWork.Any(x=>x.Eposta==textEdit1.Text))
					{
						XtraMessageBox.Show("Böyle bir kayıt bulunuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						Kullanici kullanici = new Kullanici();
						kullanici.Eposta = textEdit1.Text;
						kullanici.Password = textEdit2.Text;
						switch (comboBoxEdit1.Text)
						{
							case "Admin":
								kullanici.yetki = Yetkiler.Admin;
								break;
							case "Kasiyer":
								kullanici.yetki = Yetkiler.Kasiyer;
								break;
						}
						kullanici.Ad = textEdit4.Text;
						kullanici.Soyad = textEdit5.Text;
						kullanici.Guncellenme_Tarih = DateTime.Now;
						unitOf.kullaniciWork.add(kullanici);
						unitOf.Save();
						XtraMessageBox.Show("Başarıyla kayıt yapıldı.", "Bilgilendirme", MessageBoxButtons.OK);
						listele();
					}



				}
				}
				
			}

		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			using (UnitOfWork unitOf = new UnitOfWork())
			{
				if (!String.IsNullOrWhiteSpace(kul.Eposta)|| unitOf.kullaniciWork.GetItem(kul)!=null)
				{
					if (XtraMessageBox.Show(kul.Eposta + " Kaydını Silmek istediğinize emin misiniz?", "Kayıt Sil", MessageBoxButtons.YesNo) != DialogResult.No)
					{

						unitOf.kullaniciWork.Remove(kul);
						unitOf.Save();
						listele();

					}
				}
				else
				{
					XtraMessageBox.Show("Seçilen bir kayıt bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					
				}
			}
		}

		private void simpleButton4_Click(object sender, EventArgs e)
		{
			textEdit1.Text = "";
			textEdit2.Text = "";
			comboBoxEdit1.Text = "";
			textEdit4.Text = "";
			textEdit5.Text = "";
			
		}

		private void simpleButton3_Click(object sender, EventArgs e)
		{
			if (textEdit1.Text == "" || textEdit2.Text == "" || textEdit4.Text == "" || textEdit5.Text == "" || comboBoxEdit1.Text == "")
			{

				XtraMessageBox.Show("Eklemeden önce boşlukları doğru doldurduğunuzdan emin olun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


			}
			else
			{
				if (XtraMessageBox.Show(textEdit1.Text + " Kaydını Güncellemek istediğinize emin misiniz?", "Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					using (UnitOfWork unitOf = new UnitOfWork())
					{
						
							kul.Eposta = textEdit1.Text;
			kul.Password = textEdit2.Text;
			switch (comboBoxEdit1.Text)
			{
				case "Admin":
					kul.yetki = Yetkiler.Admin;
					break;
				case "Kasiyer":
					kul.yetki = Yetkiler.Kasiyer;
					break;
			}
			kul.Ad = textEdit4.Text;
			kul.Soyad = textEdit5.Text;
			kul.Guncellenme_Tarih = DateTime.Now;

						unitOf.kullaniciWork.Update(kul);
						unitOf.Save();
						listele();
						XtraMessageBox.Show("Başarıyla kayıt güncellendi.", "Bilgilendirme", MessageBoxButtons.OK);


					}
				}

			}
			
		}
	}
		
}
