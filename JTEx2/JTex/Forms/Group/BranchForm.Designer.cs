namespace JTex.Forms
{
    partial class Branch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Branch));
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
            this.branchesBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBranchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaxNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.BranchIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CompanyIDLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource();
            this.NumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PhoneNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FaxNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForFaxNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCompanyID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBranchID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPhoneNumber = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BranchIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyIDLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaxNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFaxNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranchID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhoneNumber)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(1258, 103);
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
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
            this.ribbonPage1.Text = "Operations";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1258, 646);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.branchesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1252, 446);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // branchesBindingSource
            // 
            this.branchesBindingSource.DataSource = typeof(Modelx.Branch);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBranchID,
            this.colCompanyID,
            this.colNumber,
            this.colName,
            this.colAddress,
            this.colPhoneNumber,
            this.colFaxNumber});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBranchID, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged_1);
            // 
            // colBranchID
            // 
            this.colBranchID.FieldName = "BranchID";
            this.colBranchID.Name = "colBranchID";
            this.colBranchID.Visible = true;
            this.colBranchID.VisibleIndex = 0;
            // 
            // colCompanyID
            // 
            this.colCompanyID.FieldName = "CompanyID";
            this.colCompanyID.Name = "colCompanyID";
            this.colCompanyID.Visible = true;
            this.colCompanyID.VisibleIndex = 1;
            // 
            // colNumber
            // 
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 2;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 3;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 4;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 5;
            // 
            // colFaxNumber
            // 
            this.colFaxNumber.FieldName = "FaxNumber";
            this.colFaxNumber.Name = "colFaxNumber";
            this.colFaxNumber.Visible = true;
            this.colFaxNumber.VisibleIndex = 6;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.BranchIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CompanyIDLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.NumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AddressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PhoneNumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FaxNumberTextEdit);
            this.dataLayoutControl1.DataSource = this.branchesBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 455);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1252, 188);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // BranchIDTextEdit
            // 
            this.BranchIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.branchesBindingSource, "BranchID", true));
            this.BranchIDTextEdit.Location = new System.Drawing.Point(97, 64);
            this.BranchIDTextEdit.MenuManager = this.ribbonControl;
            this.BranchIDTextEdit.Name = "BranchIDTextEdit";
            this.BranchIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.BranchIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BranchIDTextEdit.Properties.Mask.EditMask = "N0";
            this.BranchIDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.BranchIDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.BranchIDTextEdit.Size = new System.Drawing.Size(487, 20);
            this.BranchIDTextEdit.StyleController = this.dataLayoutControl1;
            this.BranchIDTextEdit.TabIndex = 4;
            // 
            // CompanyIDLookUpEdit
            // 
            this.CompanyIDLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.branchesBindingSource, "CompanyID", true));
            this.CompanyIDLookUpEdit.Location = new System.Drawing.Point(661, 64);
            this.CompanyIDLookUpEdit.MenuManager = this.ribbonControl;
            this.CompanyIDLookUpEdit.Name = "CompanyIDLookUpEdit";
            this.CompanyIDLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.CompanyIDLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CompanyIDLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CompanyIDLookUpEdit.Properties.DataSource = this.companiesBindingSource;
            this.CompanyIDLookUpEdit.Properties.DisplayMember = "CompanyID";
            this.CompanyIDLookUpEdit.Properties.NullText = "";
            this.CompanyIDLookUpEdit.Properties.ValueMember = "CompanyID";
            this.CompanyIDLookUpEdit.Size = new System.Drawing.Size(264, 20);
            this.CompanyIDLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CompanyIDLookUpEdit.TabIndex = 5;
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataSource = typeof(Modelx.Company);
            // 
            // NumberTextEdit
            // 
            this.NumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.branchesBindingSource, "Number", true));
            this.NumberTextEdit.Location = new System.Drawing.Point(1002, 64);
            this.NumberTextEdit.MenuManager = this.ribbonControl;
            this.NumberTextEdit.Name = "NumberTextEdit";
            this.NumberTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.NumberTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.NumberTextEdit.Properties.Mask.EditMask = "N0";
            this.NumberTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.NumberTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.NumberTextEdit.Size = new System.Drawing.Size(226, 20);
            this.NumberTextEdit.StyleController = this.dataLayoutControl1;
            this.NumberTextEdit.TabIndex = 6;
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.branchesBindingSource, "Name", true));
            this.NameTextEdit.Location = new System.Drawing.Point(97, 88);
            this.NameTextEdit.MenuManager = this.ribbonControl;
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.NameTextEdit.Size = new System.Drawing.Size(487, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 7;
            // 
            // AddressTextEdit
            // 
            this.AddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.branchesBindingSource, "Address", true));
            this.AddressTextEdit.Location = new System.Drawing.Point(661, 88);
            this.AddressTextEdit.MenuManager = this.ribbonControl;
            this.AddressTextEdit.Name = "AddressTextEdit";
            this.AddressTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.AddressTextEdit.Size = new System.Drawing.Size(567, 20);
            this.AddressTextEdit.StyleController = this.dataLayoutControl1;
            this.AddressTextEdit.TabIndex = 8;
            // 
            // PhoneNumberTextEdit
            // 
            this.PhoneNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.branchesBindingSource, "PhoneNumber", true));
            this.PhoneNumberTextEdit.Location = new System.Drawing.Point(97, 112);
            this.PhoneNumberTextEdit.MenuManager = this.ribbonControl;
            this.PhoneNumberTextEdit.Name = "PhoneNumberTextEdit";
            this.PhoneNumberTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.PhoneNumberTextEdit.Size = new System.Drawing.Size(487, 20);
            this.PhoneNumberTextEdit.StyleController = this.dataLayoutControl1;
            this.PhoneNumberTextEdit.TabIndex = 9;
            // 
            // FaxNumberTextEdit
            // 
            this.FaxNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.branchesBindingSource, "FaxNumber", true));
            this.FaxNumberTextEdit.Location = new System.Drawing.Point(661, 112);
            this.FaxNumberTextEdit.MenuManager = this.ribbonControl;
            this.FaxNumberTextEdit.Name = "FaxNumberTextEdit";
            this.FaxNumberTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.FaxNumberTextEdit.Size = new System.Drawing.Size(567, 20);
            this.FaxNumberTextEdit.StyleController = this.dataLayoutControl1;
            this.FaxNumberTextEdit.TabIndex = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1252, 188);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(1232, 168);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup3.CaptionImageOptions.Image")));
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForFaxNumber,
            this.ItemForAddress,
            this.ItemForCompanyID,
            this.ItemForNumber,
            this.ItemForBranchID,
            this.ItemForName,
            this.ItemForPhoneNumber});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1232, 168);
            this.layoutControlGroup3.Text = "Branch data";
            // 
            // ItemForFaxNumber
            // 
            this.ItemForFaxNumber.Control = this.FaxNumberTextEdit;
            this.ItemForFaxNumber.Location = new System.Drawing.Point(564, 48);
            this.ItemForFaxNumber.Name = "ItemForFaxNumber";
            this.ItemForFaxNumber.Size = new System.Drawing.Size(644, 56);
            this.ItemForFaxNumber.Text = "Fax Number";
            this.ItemForFaxNumber.TextSize = new System.Drawing.Size(70, 13);
            // 
            // ItemForAddress
            // 
            this.ItemForAddress.Control = this.AddressTextEdit;
            this.ItemForAddress.Location = new System.Drawing.Point(564, 24);
            this.ItemForAddress.Name = "ItemForAddress";
            this.ItemForAddress.Size = new System.Drawing.Size(644, 24);
            this.ItemForAddress.Text = "Address";
            this.ItemForAddress.TextSize = new System.Drawing.Size(70, 13);
            // 
            // ItemForCompanyID
            // 
            this.ItemForCompanyID.Control = this.CompanyIDLookUpEdit;
            this.ItemForCompanyID.Location = new System.Drawing.Point(564, 0);
            this.ItemForCompanyID.Name = "ItemForCompanyID";
            this.ItemForCompanyID.Size = new System.Drawing.Size(341, 24);
            this.ItemForCompanyID.Text = "Company ID";
            this.ItemForCompanyID.TextSize = new System.Drawing.Size(70, 13);
            // 
            // ItemForNumber
            // 
            this.ItemForNumber.Control = this.NumberTextEdit;
            this.ItemForNumber.Location = new System.Drawing.Point(905, 0);
            this.ItemForNumber.Name = "ItemForNumber";
            this.ItemForNumber.Size = new System.Drawing.Size(303, 24);
            this.ItemForNumber.Text = "Number";
            this.ItemForNumber.TextSize = new System.Drawing.Size(70, 13);
            // 
            // ItemForBranchID
            // 
            this.ItemForBranchID.Control = this.BranchIDTextEdit;
            this.ItemForBranchID.Location = new System.Drawing.Point(0, 0);
            this.ItemForBranchID.Name = "ItemForBranchID";
            this.ItemForBranchID.Size = new System.Drawing.Size(564, 24);
            this.ItemForBranchID.Text = "Branch ID";
            this.ItemForBranchID.TextSize = new System.Drawing.Size(70, 13);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 24);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(564, 24);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(70, 13);
            // 
            // ItemForPhoneNumber
            // 
            this.ItemForPhoneNumber.Control = this.PhoneNumberTextEdit;
            this.ItemForPhoneNumber.Location = new System.Drawing.Point(0, 48);
            this.ItemForPhoneNumber.Name = "ItemForPhoneNumber";
            this.ItemForPhoneNumber.Size = new System.Drawing.Size(564, 56);
            this.ItemForPhoneNumber.Text = "Phone Number";
            this.ItemForPhoneNumber.TextSize = new System.Drawing.Size(70, 13);
            // 
            // Branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Branch";
            this.Text = "Branch Form";
            this.Load += new System.EventHandler(this.Branch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BranchIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyIDLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaxNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFaxNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranchID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhoneNumber)).EndInit();
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
        private System.Windows.Forms.BindingSource branchesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchID;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyID;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colFaxNumber;
        private DevExpress.XtraEditors.TextEdit BranchIDTextEdit;
        private DevExpress.XtraEditors.LookUpEdit CompanyIDLookUpEdit;
        private DevExpress.XtraEditors.TextEdit NumberTextEdit;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.TextEdit AddressTextEdit;
        private DevExpress.XtraEditors.TextEdit PhoneNumberTextEdit;
        private DevExpress.XtraEditors.TextEdit FaxNumberTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhoneNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompanyID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBranchID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFaxNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNumber;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    }
}