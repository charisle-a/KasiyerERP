
namespace KasiyerERP.Formlar
{
	partial class SepeteEkleForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
			this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(12, 99);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(23, 13);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Adet";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(12, 61);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(39, 13);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Ürün Ad";
			// 
			// textEdit1
			// 
			this.textEdit1.Location = new System.Drawing.Point(78, 58);
			this.textEdit1.Name = "textEdit1";
			this.textEdit1.Properties.ReadOnly = true;
			this.textEdit1.Size = new System.Drawing.Size(131, 20);
			this.textEdit1.TabIndex = 2;
			// 
			// textEdit2
			// 
			this.textEdit2.Location = new System.Drawing.Point(78, 99);
			this.textEdit2.Name = "textEdit2";
			this.textEdit2.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.textEdit2.Properties.MaskSettings.Set("mask", "d");
			this.textEdit2.Size = new System.Drawing.Size(131, 20);
			this.textEdit2.TabIndex = 3;
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(46, 149);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(75, 23);
			this.simpleButton1.TabIndex = 4;
			this.simpleButton1.Text = "Ekle";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// simpleButton2
			// 
			this.simpleButton2.Location = new System.Drawing.Point(134, 149);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(75, 23);
			this.simpleButton2.TabIndex = 5;
			this.simpleButton2.Text = "İptal";
			this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
			// 
			// SepeteEkleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(285, 184);
			this.Controls.Add(this.simpleButton2);
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.textEdit2);
			this.Controls.Add(this.textEdit1);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Name = "SepeteEkleForm";
			this.Text = "SepeteEkleForm";
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		public DevExpress.XtraEditors.TextEdit textEdit1;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		public DevExpress.XtraEditors.TextEdit textEdit2;
	}
}