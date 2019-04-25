namespace JTex.Forms
{
    partial class CompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyForm));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNTN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.CompanyIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.GroupIDLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ShortNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NTNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.STNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.WebsiteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForWebsite = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSTN = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForShortName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGroupID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCompanyID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNTN = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupIDLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NTNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebsiteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWebsite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShortName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGroupID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
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
            this.bbiRefresh});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 20;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1013, 103);
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
            this.bbiNew.Caption = "Add";
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataLayoutControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1013, 567);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.companiesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1007, 390);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataSource = typeof(Modelx.Company);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompanyID,
            this.colGroupID,
            this.colName,
            this.colShortName,
            this.colNTN,
            this.colSTN,
            this.colEmail,
            this.colWebsite});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCompanyID, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colCompanyID
            // 
            this.colCompanyID.FieldName = "CompanyID";
            this.colCompanyID.Name = "colCompanyID";
            this.colCompanyID.Visible = true;
            this.colCompanyID.VisibleIndex = 0;
            // 
            // colGroupID
            // 
            this.colGroupID.FieldName = "GroupID";
            this.colGroupID.Name = "colGroupID";
            this.colGroupID.Visible = true;
            this.colGroupID.VisibleIndex = 1;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            // 
            // colShortName
            // 
            this.colShortName.FieldName = "ShortName";
            this.colShortName.Name = "colShortName";
            this.colShortName.Visible = true;
            this.colShortName.VisibleIndex = 3;
            // 
            // colNTN
            // 
            this.colNTN.FieldName = "NTN";
            this.colNTN.Name = "colNTN";
            this.colNTN.Visible = true;
            this.colNTN.VisibleIndex = 4;
            // 
            // colSTN
            // 
            this.colSTN.FieldName = "STN";
            this.colSTN.Name = "colSTN";
            this.colSTN.Visible = true;
            this.colSTN.VisibleIndex = 5;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 6;
            // 
            // colWebsite
            // 
            this.colWebsite.FieldName = "Website";
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 7;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.CompanyIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.GroupIDLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ShortNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NTNTextEdit);
            this.dataLayoutControl1.Controls.Add(this.STNTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.WebsiteTextEdit);
            this.dataLayoutControl1.DataSource = this.companiesBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 399);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1007, 165);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // CompanyIDTextEdit
            // 
            this.CompanyIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companiesBindingSource, "CompanyID", true));
            this.CompanyIDTextEdit.Location = new System.Drawing.Point(86, 64);
            this.CompanyIDTextEdit.MenuManager = this.ribbonControl;
            this.CompanyIDTextEdit.Name = "CompanyIDTextEdit";
            this.CompanyIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.CompanyIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CompanyIDTextEdit.Properties.Mask.EditMask = "N0";
            this.CompanyIDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.CompanyIDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.CompanyIDTextEdit.Size = new System.Drawing.Size(406, 20);
            this.CompanyIDTextEdit.StyleController = this.dataLayoutControl1;
            this.CompanyIDTextEdit.TabIndex = 4;
            // 
            // GroupIDLookUpEdit
            // 
            this.GroupIDLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companiesBindingSource, "GroupID", true));
            this.GroupIDLookUpEdit.Location = new System.Drawing.Point(558, 64);
            this.GroupIDLookUpEdit.MenuManager = this.ribbonControl;
            this.GroupIDLookUpEdit.Name = "GroupIDLookUpEdit";
            this.GroupIDLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.GroupIDLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.GroupIDLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GroupIDLookUpEdit.Properties.DataSource = this.groupsBindingSource;
            this.GroupIDLookUpEdit.Properties.DisplayMember = "GroupID";
            this.GroupIDLookUpEdit.Properties.NullText = "";
            this.GroupIDLookUpEdit.Properties.ValueMember = "GroupID";
            this.GroupIDLookUpEdit.Size = new System.Drawing.Size(408, 20);
            this.GroupIDLookUpEdit.StyleController = this.dataLayoutControl1;
            this.GroupIDLookUpEdit.TabIndex = 5;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataSource = typeof(Modelx.Group);
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companiesBindingSource, "Name", true));
            this.NameTextEdit.Location = new System.Drawing.Point(86, 88);
            this.NameTextEdit.MenuManager = this.ribbonControl;
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.NameTextEdit.Size = new System.Drawing.Size(406, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 6;
            // 
            // ShortNameTextEdit
            // 
            this.ShortNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companiesBindingSource, "ShortName", true));
            this.ShortNameTextEdit.Location = new System.Drawing.Point(558, 88);
            this.ShortNameTextEdit.MenuManager = this.ribbonControl;
            this.ShortNameTextEdit.Name = "ShortNameTextEdit";
            this.ShortNameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.ShortNameTextEdit.Size = new System.Drawing.Size(408, 20);
            this.ShortNameTextEdit.StyleController = this.dataLayoutControl1;
            this.ShortNameTextEdit.TabIndex = 7;
            // 
            // NTNTextEdit
            // 
            this.NTNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companiesBindingSource, "NTN", true));
            this.NTNTextEdit.Location = new System.Drawing.Point(86, 112);
            this.NTNTextEdit.MenuManager = this.ribbonControl;
            this.NTNTextEdit.Name = "NTNTextEdit";
            this.NTNTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.NTNTextEdit.Size = new System.Drawing.Size(406, 20);
            this.NTNTextEdit.StyleController = this.dataLayoutControl1;
            this.NTNTextEdit.TabIndex = 8;
            // 
            // STNTextEdit
            // 
            this.STNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companiesBindingSource, "STN", true));
            this.STNTextEdit.Location = new System.Drawing.Point(558, 112);
            this.STNTextEdit.MenuManager = this.ribbonControl;
            this.STNTextEdit.Name = "STNTextEdit";
            this.STNTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.STNTextEdit.Size = new System.Drawing.Size(408, 20);
            this.STNTextEdit.StyleController = this.dataLayoutControl1;
            this.STNTextEdit.TabIndex = 9;
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companiesBindingSource, "Email", true));
            this.EmailTextEdit.Location = new System.Drawing.Point(86, 136);
            this.EmailTextEdit.MenuManager = this.ribbonControl;
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.EmailTextEdit.Size = new System.Drawing.Size(406, 20);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 10;
            // 
            // WebsiteTextEdit
            // 
            this.WebsiteTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companiesBindingSource, "Website", true));
            this.WebsiteTextEdit.Location = new System.Drawing.Point(558, 136);
            this.WebsiteTextEdit.MenuManager = this.ribbonControl;
            this.WebsiteTextEdit.Name = "WebsiteTextEdit";
            this.WebsiteTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.WebsiteTextEdit.Size = new System.Drawing.Size(408, 20);
            this.WebsiteTextEdit.StyleController = this.dataLayoutControl1;
            this.WebsiteTextEdit.TabIndex = 11;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(990, 180);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(970, 160);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup3.CaptionImageOptions.Image")));
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForWebsite,
            this.ItemForSTN,
            this.ItemForShortName,
            this.ItemForGroupID,
            this.ItemForCompanyID,
            this.ItemForName,
            this.ItemForNTN,
            this.ItemForEmail});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(970, 160);
            this.layoutControlGroup3.Text = "Comany data E.g Sitara Chemical";
            // 
            // ItemForWebsite
            // 
            this.ItemForWebsite.Control = this.WebsiteTextEdit;
            this.ItemForWebsite.Location = new System.Drawing.Point(472, 72);
            this.ItemForWebsite.Name = "ItemForWebsite";
            this.ItemForWebsite.Size = new System.Drawing.Size(474, 24);
            this.ItemForWebsite.Text = "Website";
            this.ItemForWebsite.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForSTN
            // 
            this.ItemForSTN.Control = this.STNTextEdit;
            this.ItemForSTN.Location = new System.Drawing.Point(472, 48);
            this.ItemForSTN.Name = "ItemForSTN";
            this.ItemForSTN.Size = new System.Drawing.Size(474, 24);
            this.ItemForSTN.Text = "STN";
            this.ItemForSTN.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForShortName
            // 
            this.ItemForShortName.Control = this.ShortNameTextEdit;
            this.ItemForShortName.Location = new System.Drawing.Point(472, 24);
            this.ItemForShortName.Name = "ItemForShortName";
            this.ItemForShortName.Size = new System.Drawing.Size(474, 24);
            this.ItemForShortName.Text = "Short Name";
            this.ItemForShortName.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForGroupID
            // 
            this.ItemForGroupID.Control = this.GroupIDLookUpEdit;
            this.ItemForGroupID.Location = new System.Drawing.Point(472, 0);
            this.ItemForGroupID.Name = "ItemForGroupID";
            this.ItemForGroupID.Size = new System.Drawing.Size(474, 24);
            this.ItemForGroupID.Text = "Group ID";
            this.ItemForGroupID.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForCompanyID
            // 
            this.ItemForCompanyID.Control = this.CompanyIDTextEdit;
            this.ItemForCompanyID.Location = new System.Drawing.Point(0, 0);
            this.ItemForCompanyID.Name = "ItemForCompanyID";
            this.ItemForCompanyID.Size = new System.Drawing.Size(472, 24);
            this.ItemForCompanyID.Text = "Company ID";
            this.ItemForCompanyID.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 24);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(472, 24);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForNTN
            // 
            this.ItemForNTN.Control = this.NTNTextEdit;
            this.ItemForNTN.Location = new System.Drawing.Point(0, 48);
            this.ItemForNTN.Name = "ItemForNTN";
            this.ItemForNTN.Size = new System.Drawing.Size(472, 24);
            this.ItemForNTN.Text = "NTN";
            this.ItemForNTN.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.Location = new System.Drawing.Point(0, 72);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(472, 24);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextSize = new System.Drawing.Size(59, 13);
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 670);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "CompanyForm";
            this.Text = "CompanyForm";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupIDLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NTNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebsiteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWebsite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShortName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGroupID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
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
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyID;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colShortName;
        private DevExpress.XtraGrid.Columns.GridColumn colNTN;
        private DevExpress.XtraGrid.Columns.GridColumn colSTN;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private DevExpress.XtraEditors.TextEdit CompanyIDTextEdit;
        private DevExpress.XtraEditors.LookUpEdit GroupIDLookUpEdit;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.TextEdit ShortNameTextEdit;
        private DevExpress.XtraEditors.TextEdit NTNTextEdit;
        private DevExpress.XtraEditors.TextEdit STNTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.TextEdit WebsiteTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWebsite;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSTN;
        private DevExpress.XtraLayout.LayoutControlItem ItemForShortName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGroupID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompanyID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNTN;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private System.Windows.Forms.BindingSource groupsBindingSource;
    }
}