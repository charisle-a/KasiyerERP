using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using SiparisTakipApp.Formlar;

namespace SiparisTakipApp
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{


			UserLookAndFeel.Default.SetSkinStyle(SkinStyle.DevExpressDark);



			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Login loginform = new Login();
			if(loginform.ShowDialog() == DialogResult.Yes)
			{

            Application.Run(new Form1());
			}
			else
			{
				Application.Exit();
			}
			
		}
	}
}
