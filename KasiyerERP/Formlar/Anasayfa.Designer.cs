
namespace SiparisTakipApp.Formlar
{
	partial class Anasayfa
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
			DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
			DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
			DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
			DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
			DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
			DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
			DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
			DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
			this.tileViewColumn4 = new DevExpress.XtraGrid.Columns.TileViewColumn();
			this.tileViewColumn2 = new DevExpress.XtraGrid.Columns.TileViewColumn();
			this.tileViewColumn3 = new DevExpress.XtraGrid.Columns.TileViewColumn();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
			this.gridControl2 = new DevExpress.XtraGrid.GridControl();
			this.tileView2 = new DevExpress.XtraGrid.Views.Tile.TileView();
			this.gridControl3 = new DevExpress.XtraGrid.GridControl();
			this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tileView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tileViewColumn4
			// 
			this.tileViewColumn4.Caption = "tileViewColumn4";
			this.tileViewColumn4.FieldName = "Ad";
			this.tileViewColumn4.Name = "tileViewColumn4";
			this.tileViewColumn4.Visible = true;
			this.tileViewColumn4.VisibleIndex = 0;
			// 
			// tileViewColumn2
			// 
			this.tileViewColumn2.Caption = "tileViewColumn2";
			this.tileViewColumn2.FieldName = "Ad";
			this.tileViewColumn2.Name = "tileViewColumn2";
			this.tileViewColumn2.Visible = true;
			this.tileViewColumn2.VisibleIndex = 0;
			// 
			// tileViewColumn3
			// 
			this.tileViewColumn3.Caption = "tileViewColumn3";
			this.tileViewColumn3.FieldName = "Fiyat";
			this.tileViewColumn3.Name = "tileViewColumn3";
			this.tileViewColumn3.UnboundDataType = typeof(decimal);
			this.tileViewColumn3.Visible = true;
			this.tileViewColumn3.VisibleIndex = 1;
			// 
			// gridControl1
			// 
			this.gridControl1.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridControl1.Location = new System.Drawing.Point(12, 6);
			this.gridControl1.MainView = this.tileView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(268, 504);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
			// 
			// tileView1
			// 
			this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tileViewColumn4});
			this.tileView1.GridControl = this.gridControl1;
			this.tileView1.Name = "tileView1";
			this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(248, 47);
			this.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.Kanban;
			this.tileView1.OptionsTiles.RowCount = 0;
			this.tileView1.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
			this.tileView1.TileColumns.Add(tableColumnDefinition1);
			tableRowDefinition1.Length.Value = 15D;
			this.tileView1.TileRows.Add(tableRowDefinition1);
			tileViewItemElement1.Column = this.tileViewColumn4;
			tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
			tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
			tileViewItemElement1.Text = "tileViewColumn4";
			tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
			this.tileView1.TileTemplate.Add(tileViewItemElement1);
			this.tileView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.tileView1_FocusedRowChanged);
			// 
			// gridControl2
			// 
			this.gridControl2.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold);
			this.gridControl2.Location = new System.Drawing.Point(286, 6);
			this.gridControl2.MainView = this.tileView2;
			this.gridControl2.Name = "gridControl2";
			this.gridControl2.Size = new System.Drawing.Size(550, 561);
			this.gridControl2.TabIndex = 1;
			this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView2});
			// 
			// tileView2
			// 
			this.tileView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tileViewColumn2,
            this.tileViewColumn3});
			this.tileView2.GridControl = this.gridControl2;
			this.tileView2.Name = "tileView2";
			this.tileView2.OptionsTiles.ItemSize = new System.Drawing.Size(248, 72);
			this.tileView2.OptionsTiles.RowCount = 0;
			this.tileView2.TileColumns.Add(tableColumnDefinition2);
			tableRowDefinition2.Length.Value = 15D;
			tableRowDefinition3.Length.Value = 15D;
			this.tileView2.TileRows.Add(tableRowDefinition2);
			this.tileView2.TileRows.Add(tableRowDefinition3);
			tileViewItemElement2.Column = this.tileViewColumn2;
			tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
			tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
			tileViewItemElement2.Text = "tileViewColumn2";
			tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
			tileViewItemElement3.Column = this.tileViewColumn3;
			tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
			tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
			tileViewItemElement3.RowIndex = 1;
			tileViewItemElement3.Text = "tileViewColumn3";
			tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
			this.tileView2.TileTemplate.Add(tileViewItemElement2);
			this.tileView2.TileTemplate.Add(tileViewItemElement3);
			this.tileView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.tileView2_FocusedRowChanged);
			// 
			// gridControl3
			// 
			this.gridControl3.Location = new System.Drawing.Point(5, 26);
			this.gridControl3.MainView = this.gridView3;
			this.gridControl3.Name = "gridControl3";
			this.gridControl3.Size = new System.Drawing.Size(234, 474);
			this.gridControl3.TabIndex = 2;
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
			// groupControl1
			// 
			this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupControl1.Controls.Add(this.simpleButton1);
			this.groupControl1.Controls.Add(this.gridControl3);
			this.groupControl1.Location = new System.Drawing.Point(842, 6);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(239, 561);
			this.groupControl1.TabIndex = 3;
			this.groupControl1.Text = "Satış";
			// 
			// simpleButton1
			// 
			this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
			this.simpleButton1.Location = new System.Drawing.Point(90, 506);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(144, 38);
			this.simpleButton1.TabIndex = 3;
			this.simpleButton1.Text = "Satış Yap";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// Anasayfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1093, 579);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gridControl2);
			this.Controls.Add(this.gridControl1);
			this.Name = "Anasayfa";
			this.Text = "Anasayfa";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Anasayfa_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tileView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.GridControl gridControl2;
		private DevExpress.XtraGrid.GridControl gridControl3;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
		private DevExpress.XtraGrid.Views.Tile.TileView tileView2;
		private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
		private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn2;
		private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn3;
		private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn4;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
	}
}