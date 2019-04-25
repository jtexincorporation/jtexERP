namespace JTex.Forms.ArTMS
{
    partial class StatusCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusCategoryForm));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.statusCategoriesBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colstatusid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisactive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.statusidTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.categoryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.descriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.isactiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForisactive = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForname = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForcategory = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForstatusid = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemFordescription = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusidTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isactiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForisactive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForstatusid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFordescription)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh,
            this.barButtonItem1});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 21;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(981, 116);
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            this.bbiPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "New";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Exit";
            this.barButtonItem1.Id = 20;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Operations";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Print and Export";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Exit";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataLayoutControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 116);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(981, 682);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.statusCategoriesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(975, 471);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // statusCategoriesBindingSource
            // 
            this.statusCategoriesBindingSource.DataSource = typeof(Modelx.StatusCategory);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colstatusid,
            this.colcategory,
            this.colname,
            this.coldescription,
            this.colisactive});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colstatusid, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colstatusid
            // 
            this.colstatusid.FieldName = "statusid";
            this.colstatusid.Name = "colstatusid";
            this.colstatusid.Visible = true;
            this.colstatusid.VisibleIndex = 0;
            // 
            // colcategory
            // 
            this.colcategory.FieldName = "category";
            this.colcategory.Name = "colcategory";
            this.colcategory.Visible = true;
            this.colcategory.VisibleIndex = 1;
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 2;
            // 
            // coldescription
            // 
            this.coldescription.FieldName = "description";
            this.coldescription.Name = "coldescription";
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 3;
            // 
            // colisactive
            // 
            this.colisactive.FieldName = "isactive";
            this.colisactive.Name = "colisactive";
            this.colisactive.Visible = true;
            this.colisactive.VisibleIndex = 4;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.statusidTextEdit);
            this.dataLayoutControl1.Controls.Add(this.categoryTextEdit);
            this.dataLayoutControl1.Controls.Add(this.nameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.descriptionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.isactiveCheckEdit);
            this.dataLayoutControl1.DataSource = this.statusCategoriesBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 480);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(975, 199);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // statusidTextEdit
            // 
            this.statusidTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.statusCategoriesBindingSource, "statusid", true));
            this.statusidTextEdit.Location = new System.Drawing.Point(79, 64);
            this.statusidTextEdit.MenuManager = this.ribbonControl;
            this.statusidTextEdit.Name = "statusidTextEdit";
            this.statusidTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.statusidTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.statusidTextEdit.Properties.Mask.EditMask = "N0";
            this.statusidTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.statusidTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.statusidTextEdit.Size = new System.Drawing.Size(383, 20);
            this.statusidTextEdit.StyleController = this.dataLayoutControl1;
            this.statusidTextEdit.TabIndex = 4;
            // 
            // categoryTextEdit
            // 
            this.categoryTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.statusCategoriesBindingSource, "category", true));
            this.categoryTextEdit.Location = new System.Drawing.Point(521, 64);
            this.categoryTextEdit.MenuManager = this.ribbonControl;
            this.categoryTextEdit.Name = "categoryTextEdit";
            this.categoryTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.categoryTextEdit.Size = new System.Drawing.Size(430, 20);
            this.categoryTextEdit.StyleController = this.dataLayoutControl1;
            this.categoryTextEdit.TabIndex = 5;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.statusCategoriesBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(521, 88);
            this.nameTextEdit.MenuManager = this.ribbonControl;
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.nameTextEdit.Size = new System.Drawing.Size(430, 20);
            this.nameTextEdit.StyleController = this.dataLayoutControl1;
            this.nameTextEdit.TabIndex = 6;
            // 
            // descriptionTextEdit
            // 
            this.descriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.statusCategoriesBindingSource, "description", true));
            this.descriptionTextEdit.Location = new System.Drawing.Point(79, 88);
            this.descriptionTextEdit.MenuManager = this.ribbonControl;
            this.descriptionTextEdit.Name = "descriptionTextEdit";
            this.descriptionTextEdit.Size = new System.Drawing.Size(383, 20);
            this.descriptionTextEdit.StyleController = this.dataLayoutControl1;
            this.descriptionTextEdit.TabIndex = 7;
            // 
            // isactiveCheckEdit
            // 
            this.isactiveCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.statusCategoriesBindingSource, "isactive", true));
            this.isactiveCheckEdit.Location = new System.Drawing.Point(24, 112);
            this.isactiveCheckEdit.MenuManager = this.ribbonControl;
            this.isactiveCheckEdit.Name = "isactiveCheckEdit";
            this.isactiveCheckEdit.Properties.Caption = "isactive";
            this.isactiveCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.isactiveCheckEdit.Size = new System.Drawing.Size(927, 19);
            this.isactiveCheckEdit.StyleController = this.dataLayoutControl1;
            this.isactiveCheckEdit.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(975, 199);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(955, 179);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup3.CaptionImageOptions.Image")));
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForisactive,
            this.ItemForname,
            this.ItemForcategory,
            this.ItemForstatusid,
            this.ItemFordescription});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(955, 179);
            this.layoutControlGroup3.Text = "Status Category";
            // 
            // ItemForisactive
            // 
            this.ItemForisactive.Control = this.isactiveCheckEdit;
            this.ItemForisactive.Location = new System.Drawing.Point(0, 48);
            this.ItemForisactive.Name = "ItemForisactive";
            this.ItemForisactive.Size = new System.Drawing.Size(931, 67);
            this.ItemForisactive.Text = "isactive";
            this.ItemForisactive.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForisactive.TextVisible = false;
            // 
            // ItemForname
            // 
            this.ItemForname.Control = this.nameTextEdit;
            this.ItemForname.Location = new System.Drawing.Point(442, 24);
            this.ItemForname.Name = "ItemForname";
            this.ItemForname.Size = new System.Drawing.Size(489, 24);
            this.ItemForname.Text = "name";
            this.ItemForname.TextSize = new System.Drawing.Size(52, 13);
            // 
            // ItemForcategory
            // 
            this.ItemForcategory.Control = this.categoryTextEdit;
            this.ItemForcategory.Location = new System.Drawing.Point(442, 0);
            this.ItemForcategory.Name = "ItemForcategory";
            this.ItemForcategory.Size = new System.Drawing.Size(489, 24);
            this.ItemForcategory.Text = "category";
            this.ItemForcategory.TextSize = new System.Drawing.Size(52, 13);
            // 
            // ItemForstatusid
            // 
            this.ItemForstatusid.Control = this.statusidTextEdit;
            this.ItemForstatusid.Location = new System.Drawing.Point(0, 0);
            this.ItemForstatusid.Name = "ItemForstatusid";
            this.ItemForstatusid.Size = new System.Drawing.Size(442, 24);
            this.ItemForstatusid.Text = "statusid";
            this.ItemForstatusid.TextSize = new System.Drawing.Size(52, 13);
            // 
            // ItemFordescription
            // 
            this.ItemFordescription.Control = this.descriptionTextEdit;
            this.ItemFordescription.Location = new System.Drawing.Point(0, 24);
            this.ItemFordescription.Name = "ItemFordescription";
            this.ItemFordescription.Size = new System.Drawing.Size(442, 24);
            this.ItemFordescription.Text = "description";
            this.ItemFordescription.TextSize = new System.Drawing.Size(52, 13);
            // 
            // StatusCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 798);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "StatusCategoryForm";
            this.Text = "StatusCategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusidTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isactiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForisactive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForstatusid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFordescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.BindingSource statusCategoriesBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit statusidTextEdit;
        private DevExpress.XtraEditors.TextEdit categoryTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit descriptionTextEdit;
        private DevExpress.XtraEditors.CheckEdit isactiveCheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForisactive;
        private DevExpress.XtraLayout.LayoutControlItem ItemForname;
        private DevExpress.XtraLayout.LayoutControlItem ItemForcategory;
        private DevExpress.XtraLayout.LayoutControlItem ItemForstatusid;
        private DevExpress.XtraLayout.LayoutControlItem ItemFordescription;
        private DevExpress.XtraGrid.Columns.GridColumn colstatusid;
        private DevExpress.XtraGrid.Columns.GridColumn colcategory;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraGrid.Columns.GridColumn colisactive;
    }
}