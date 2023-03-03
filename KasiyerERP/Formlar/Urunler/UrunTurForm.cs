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
	public partial class UrunTurForm : Form
	{
		UrunTur tur = new UrunTur();
		public UrunTurForm()
		{
			InitializeComponent();
		}
		void listele()
		{
			using (UnitOfWork unitOf = new UnitOfWork())
			{
				gridControl1.DataSource = unitOf.TurWork.GetAll();
			}

		}
		private void UrunTur_Load(object sender, EventArgs e)
		{
			listele();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			if(textEdit1.Text=="")
			{
				XtraMessageBox.Show("Eklemeden önce boşlukları doğru doldurduğunuzdan emin olun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
			else
			{
				if (XtraMessageBox.Show(textEdit1.Text + " Kaydını eklemek istediğinize emin misiniz?", "Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					using (UnitOfWork unitOf = new UnitOfWork())
					{
						if (unitOf.TurWork.Any(x => x.Ad == textEdit1.Text))
						{
							XtraMessageBox.Show("Böyle bir kayıt bulunuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
						else
						{
							UrunTur urunTur = new UrunTur();
							urunTur.Ad = textEdit1.Text;
							
							
							
							urunTur.Guncellenme_Tarih = DateTime.Now;
							unitOf.TurWork.add(urunTur);
							unitOf.Save();
							XtraMessageBox.Show("Başarıyla kayıt yapıldı.", "Bilgilendirme", MessageBoxButtons.OK);
							listele();
						}



					}
				}

			}
		}

		private void cardView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			try
			{
            tur.Id= (int)cardView1.GetRowCellValue(cardView1.FocusedRowHandle, "Id");
			tur.Ad=cardView1.GetRowCellValue(cardView1.FocusedRowHandle, "Ad").ToString();
			textEdit1.Text = tur.Ad;
			}
			catch (Exception)
			{

				throw;
			}
			
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			using (UnitOfWork unitOf = new UnitOfWork())
			{
				if (!String.IsNullOrWhiteSpace(tur.Ad) || unitOf.TurWork.GetItem(tur) != null)
				{
					if (XtraMessageBox.Show(tur.Ad + " Kaydını Silmek istediğinize emin misiniz?", "Kayıt Sil", MessageBoxButtons.YesNo) != DialogResult.No)
					{

						unitOf.TurWork.Remove(tur);
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

		private void simpleButton3_Click(object sender, EventArgs e)
		{
			if (textEdit1.Text == "")
			{
				XtraMessageBox.Show("Eklemeden önce boşlukları doğru doldurduğunuzdan emin olun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
			else
			{
				if (XtraMessageBox.Show(textEdit1.Text + " Kaydını Güncellemek istediğinize emin misiniz?", "Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					tur.Ad = textEdit1.Text;
					using (UnitOfWork unitOf = new UnitOfWork())
					{
						unitOf.TurWork.Update(tur);
						unitOf.Save();
						listele();
					}
				}
			}
		}
	}
}
