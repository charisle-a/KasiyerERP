using DataAccess;
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

namespace SiparisTakipApp.Formlar
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			if(textEdit1.Text!=""||textEdit2.Text!="")
			{
				using (UnitOfWork unitOf=new UnitOfWork())
				{
					if (unitOf.kullaniciWork.Login(textEdit1.Text, textEdit2.Text))
					{
						DialogResult = DialogResult.Yes;
					}
					else
						XtraMessageBox.Show("Eposta veya şifre yanlış.");

				}
			}
			else
				XtraMessageBox.Show("Eposta ve şifrenizi giriniz.");

		}

		private void Login_Load(object sender, EventArgs e)
		{

		}
	}
}
