
namespace KasiyerERP.Formlar
{
	partial class SatisForm
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
			this.gridControl3 = new DevExpress.XtraGrid.GridControl();
			this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.TutarLabel = new DevExpress.XtraEditors.LabelControl();
			this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridControl3
			// 
			this.gridControl3.Location = new System.Drawing.Point(12, 12);
			this.gridControl3.MainView = this.gridView3;
			this.gridControl3.Name = "gridControl3";
			this.gridControl3.Size = new System.Drawing.Size(323, 440);
			this.gridControl3.TabIndex = 3;
			this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
			// 
			// gridView3
			// 
			this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
			this.gridView3.GridControl = this.gridControl3;
			this.gridView3.Name = "gridView3";
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "Ürün Ad";
			this.gridColumn1.FieldName = "Urun.Ad";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Fiyat";
			this.gridColumn2.FieldName = "Tutar";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "Adet";
			this.gridColumn3.FieldName = "Adet";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 2;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(29, 37);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(67, 13);
			this.labelControl1.TabIndex = 4;
			this.labelControl1.Text = "Toplam Tutar:";
			// 
			// TutarLabel
			// 
			this.TutarLabel.Location = new System.Drawing.Point(102, 37);
			this.TutarLabel.Name = "TutarLabel";
			this.TutarLabel.Size = new System.Drawing.Size(67, 13);
			this.TutarLabel.TabIndex = 5;
			this.TutarLabel.Text = "Toplam Tutar:";
			// 
			// textEdit1
			// 
			this.textEdit1.Location = new System.Drawing.Point(63, 93);
			this.textEdit1.Name = "textEdit1";
			this.textEdit1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.textEdit1.Properties.MaskSettings.Set("mask", "c");
			this.textEdit1.Size = new System.Drawing.Size(147, 20);
			this.textEdit1.TabIndex = 6;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(29, 96);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(28, 13);
			this.labelControl2.TabIndex = 7;
			this.labelControl2.Text = "Nakit:";
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(102, 119);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(75, 23);
			this.simpleButton1.TabIndex = 8;
			this.simpleButton1.Text = "Satış Yap";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Controls.Add(this.simpleButton1);
			this.groupControl1.Controls.Add(this.TutarLabel);
			this.groupControl1.Controls.Add(this.labelControl2);
			this.groupControl1.Controls.Add(this.textEdit1);
			this.groupControl1.Location = new System.Drawing.Point(372, 12);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(268, 175);
			this.groupControl1.TabIndex = 9;
			// 
			// SatisForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(699, 450);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gridControl3);
			this.Name = "SatisForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SatisForm";
			this.Load += new System.EventHandler(this.SatisForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl3;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl TutarLabel;
		private DevExpress.XtraEditors.TextEdit textEdit1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.GroupControl groupControl1;
	}
}