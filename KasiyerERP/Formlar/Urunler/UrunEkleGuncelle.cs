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

namespace KasiyerERP.Formlar.Urunler
{
	public partial class UrunEkleGuncelle : Form
	{
		public Urun urunUpdate = new Urun();
		public UrunEkleGuncelle()
		{
			InitializeComponent();
		}
		public void TextUpdate()
		{
			textEdit1.Text = urunUpdate.Ad;
			textEdit2.Text = urunUpdate.Fiyat.ToString();
			comboBoxEdit1.Text = urunUpdate.UrunTur.Ad;
			comboBoxEdit1.ReadOnly = true;
		}
		private void UrunEkleGuncelle_Load(object sender, EventArgs e)
		{
			groupControl1.Size = this.Size;
			using (UnitOfWork unitOf=new UnitOfWork())
			{
				foreach (UrunTur urunTur in unitOf.TurWork.GetAll())
				{
					comboBoxEdit1.Properties.Items.Add(urunTur.Ad);
					
					
				}
				

			}

		}

		private void KaydetButton_Click(object sender, EventArgs e)
		{
			if (textEdit1.Text != "" || textEdit2.Text != "" || comboBoxEdit1.Text != "")
			{
				if (XtraMessageBox.Show("Kaydetmek istediğinize emin misiniz?", "Kayıt", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					using (UnitOfWork unitOf = new UnitOfWork())
					{
						if(unitOf.UrunWork.GetAll().FirstOrDefault(x=>x.Ad==textEdit1.Text)==null)
						{
                        Urun urun = new Urun();
						urun.Ad = textEdit1.Text;
						urun.Fiyat = Convert.ToDecimal(textEdit2.Text);
						urun.TurId = unitOf.TurWork.GetAll().FirstOrDefault(x => x.Ad == comboBoxEdit1.Text).Id;
							urun.Guncellenme_Tarih = DateTime.Now;
							unitOf.UrunWork.add(urun);
						unitOf.Save();
						DialogResult = DialogResult.Yes;
						}
						else
							XtraMessageBox.Show("Böyle bir kayıt bulunuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


					}
				}


			}
			else
				XtraMessageBox.Show("Boşlukları doldurunuz.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			
			
		}

		private void GuncelleButton_Click(object sender, EventArgs e)
		{
			if (textEdit1.Text != "" || textEdit2.Text != "" || comboBoxEdit1.Text != "")
			{
				if (XtraMessageBox.Show("Güncellemek istediğinize emin misiniz?", "Kayıt", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					using (UnitOfWork unitOf = new UnitOfWork())
					{
						
							urunUpdate.Ad = textEdit1.Text;
							urunUpdate.Fiyat = Convert.ToDecimal(textEdit2.Text);
							
							urunUpdate.Guncellenme_Tarih = DateTime.Now;
							unitOf.UrunWork.Update(urunUpdate);
							unitOf.Save();
							DialogResult = DialogResult.Yes;
						
	}
				}


			}
			else
				XtraMessageBox.Show("Boşlukları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

		}
	}
}
