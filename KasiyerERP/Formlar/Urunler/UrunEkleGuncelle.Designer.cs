
namespace KasiyerERP.Formlar.Urunler
{
	partial class UrunEkleGuncelle
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunEkleGuncelle));
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.GuncelleButton = new DevExpress.XtraEditors.SimpleButton();
			this.KaydetButton = new DevExpress.XtraEditors.SimpleButton();
			this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
			this.urunTurBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.urunTurBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// groupControl1
			// 
			this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupControl1.Controls.Add(this.GuncelleButton);
			this.groupControl1.Controls.Add(this.KaydetButton);
			this.groupControl1.Controls.Add(this.comboBoxEdit1);
			this.groupControl1.Controls.Add(this.labelControl3);
			this.groupControl1.Controls.Add(this.textEdit2);
			this.groupControl1.Controls.Add(this.labelControl2);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Controls.Add(this.textEdit1);
			this.groupControl1.Location = new System.Drawing.Point(0, 0);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(567, 255);
			this.groupControl1.TabIndex = 0;
			// 
			// GuncelleButton
			// 
			this.GuncelleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GuncelleButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("GuncelleButton.ImageOptions.SvgImage")));
			this.GuncelleButton.Location = new System.Drawing.Point(90, 192);
			this.GuncelleButton.Name = "GuncelleButton";
			this.GuncelleButton.Size = new System.Drawing.Size(226, 38);
			this.GuncelleButton.TabIndex = 7;
			this.GuncelleButton.Text = "Güncelle";
			this.GuncelleButton.Click += new System.EventHandler(this.GuncelleButton_Click);
			// 
			// KaydetButton
			// 
			this.KaydetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.KaydetButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("KaydetButton.ImageOptions.SvgImage")));
			this.KaydetButton.Location = new System.Drawing.Point(90, 192);
			this.KaydetButton.Name = "KaydetButton";
			this.KaydetButton.Size = new System.Drawing.Size(226, 38);
			this.KaydetButton.TabIndex = 6;
			this.KaydetButton.Text = "Kaydet";
			this.KaydetButton.Click += new System.EventHandler(this.KaydetButton_Click);
			// 
			// comboBoxEdit1
			// 
			this.comboBoxEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urunTurBindingSource, "Ad", true));
			this.comboBoxEdit1.Location = new System.Drawing.Point(90, 150);
			this.comboBoxEdit1.Name = "comboBoxEdit1";
			this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.comboBoxEdit1.Size = new System.Drawing.Size(305, 20);
			this.comboBoxEdit1.TabIndex = 5;
			// 
			// urunTurBindingSource
			// 
			this.urunTurBindingSource.DataSource = typeof(Model.UrunTur);
			// 
			// labelControl3
			// 
			this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl3.Location = new System.Drawing.Point(18, 153);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(42, 13);
			this.labelControl3.TabIndex = 4;
			this.labelControl3.Text = "Ürün Tür";
			// 
			// textEdit2
			// 
			this.textEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textEdit2.Location = new System.Drawing.Point(90, 103);
			this.textEdit2.Name = "textEdit2";
			this.textEdit2.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.textEdit2.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
			this.textEdit2.Properties.MaskSettings.Set("mask", "c");
			this.textEdit2.Size = new System.Drawing.Size(305, 20);
			this.textEdit2.TabIndex = 3;
			// 
			// labelControl2
			// 
			this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl2.Location = new System.Drawing.Point(18, 106);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(50, 13);
			this.labelControl2.TabIndex = 2;
			this.labelControl2.Text = "Ürün Fiyat";
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl1.Location = new System.Drawing.Point(18, 62);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(39, 13);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Ürün Ad";
			// 
			// textEdit1
			// 
			this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textEdit1.Location = new System.Drawing.Point(90, 59);
			this.textEdit1.Name = "textEdit1";
			this.textEdit1.Size = new System.Drawing.Size(305, 20);
			this.textEdit1.TabIndex = 0;
			// 
			// UrunEkleGuncelle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(567, 304);
			this.Controls.Add(this.groupControl1);
			this.Name = "UrunEkleGuncelle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UrunEkleGuncelle";
			this.Load += new System.EventHandler(this.UrunEkleGuncelle_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.urunTurBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.TextEdit textEdit2;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit textEdit1;
		public DevExpress.XtraEditors.SimpleButton KaydetButton;
		public DevExpress.XtraEditors.SimpleButton GuncelleButton;
		private System.Windows.Forms.BindingSource urunTurBindingSource;
	}
}