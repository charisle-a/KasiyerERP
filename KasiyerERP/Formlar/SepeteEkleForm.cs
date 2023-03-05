using DevExpress.XtraEditors;
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
	public partial class SepeteEkleForm : Form
	{
		public SepeteEkleForm()
		{
			InitializeComponent();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			if(textEdit2.Text==""||Convert.ToInt32(textEdit2.Text)==0)
			{
				XtraMessageBox.Show("Adet kısmı boş veya 0 girilemez.");
			}
			else
			DialogResult = DialogResult.Yes;
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
