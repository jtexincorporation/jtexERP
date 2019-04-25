namespace JTex.Forms.Accounts
{
    partial class InvoicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesForm));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gL_Voucher_Item_TypeBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVoucherItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.VoucherItemIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AccountIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DebitTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CreditTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NarrationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAccountID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForVoucherItemID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNarration = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDebit = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCredit = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gL_Voucher_Item_TypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherItemIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebitTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccountID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVoucherItemID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDebit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
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
            this.bbiRefresh,
            this.barButtonItem1});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 21;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1125, 143);
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
            this.bbiNew.Caption = "Save";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Add";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Display Transactions";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Delete";
            this.barButtonItem1.Id = 20;
            this.barButtonItem1.ImageOptions.ImageUri.Uri = "Delete";
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Functions";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 143);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1125, 571);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.gL_Voucher_Item_TypeBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1119, 393);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gL_Voucher_Item_TypeBindingSource
            // 
            this.gL_Voucher_Item_TypeBindingSource.DataSource = typeof(Modelx.GL_Voucher_Item_Type);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVoucherItemID,
            this.colAccountID,
            this.colDebit,
            this.colCredit,
            this.colNarration,
            this.colDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit", this.colCredit, "(Credit: SUM={0:0.##})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit", this.colDebit, "(Debit: SUM={0:0.##})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colVoucherItemID
            // 
            this.colVoucherItemID.FieldName = "VoucherItemID";
            this.colVoucherItemID.Name = "colVoucherItemID";
            this.colVoucherItemID.Visible = true;
            this.colVoucherItemID.VisibleIndex = 0;
            // 
            // colAccountID
            // 
            this.colAccountID.FieldName = "AccountID";
            this.colAccountID.Name = "colAccountID";
            this.colAccountID.Visible = true;
            this.colAccountID.VisibleIndex = 1;
            // 
            // colDebit
            // 
            this.colDebit.FieldName = "Debit";
            this.colDebit.Name = "colDebit";
            this.colDebit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit", "SUM={0:0.##}")});
            this.colDebit.Visible = true;
            this.colDebit.VisibleIndex = 2;
            // 
            // colCredit
            // 
            this.colCredit.FieldName = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit", "SUM={0:0.##}")});
            this.colCredit.Visible = true;
            this.colCredit.VisibleIndex = 3;
            // 
            // colNarration
            // 
            this.colNarration.FieldName = "Narration";
            this.colNarration.Name = "colNarration";
            this.colNarration.Visible = true;
            this.colNarration.VisibleIndex = 4;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 5;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.VoucherItemIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AccountIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DebitTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CreditTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NarrationTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DateDateEdit);
            this.dataLayoutControl1.DataSource = this.gL_Voucher_Item_TypeBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 402);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1119, 166);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // VoucherItemIDTextEdit
            // 
            this.VoucherItemIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gL_Voucher_Item_TypeBindingSource, "VoucherItemID", true));
            this.VoucherItemIDTextEdit.Location = new System.Drawing.Point(105, 64);
            this.VoucherItemIDTextEdit.MenuManager = this.ribbonControl;
            this.VoucherItemIDTextEdit.Name = "VoucherItemIDTextEdit";
            this.VoucherItemIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.VoucherItemIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.VoucherItemIDTextEdit.Properties.Mask.EditMask = "N0";
            this.VoucherItemIDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.VoucherItemIDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.VoucherItemIDTextEdit.Size = new System.Drawing.Size(277, 20);
            this.VoucherItemIDTextEdit.StyleController = this.dataLayoutControl1;
            this.VoucherItemIDTextEdit.TabIndex = 4;
            // 
            // AccountIDTextEdit
            // 
            this.AccountIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gL_Voucher_Item_TypeBindingSource, "AccountID", true));
            this.AccountIDTextEdit.Location = new System.Drawing.Point(105, 88);
            this.AccountIDTextEdit.MenuManager = this.ribbonControl;
            this.AccountIDTextEdit.Name = "AccountIDTextEdit";
            this.AccountIDTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.AccountIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.AccountIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AccountIDTextEdit.Properties.Mask.EditMask = "d";
            this.AccountIDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.AccountIDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AccountIDTextEdit.Size = new System.Drawing.Size(277, 20);
            this.AccountIDTextEdit.StyleController = this.dataLayoutControl1;
            this.AccountIDTextEdit.TabIndex = 5;
            // 
            // DebitTextEdit
            // 
            this.DebitTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gL_Voucher_Item_TypeBindingSource, "Debit", true));
            this.DebitTextEdit.Location = new System.Drawing.Point(467, 88);
            this.DebitTextEdit.MenuManager = this.ribbonControl;
            this.DebitTextEdit.Name = "DebitTextEdit";
            this.DebitTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.DebitTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.DebitTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DebitTextEdit.Properties.Mask.EditMask = "d";
            this.DebitTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.DebitTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.DebitTextEdit.Size = new System.Drawing.Size(284, 20);
            this.DebitTextEdit.StyleController = this.dataLayoutControl1;
            this.DebitTextEdit.TabIndex = 6;
            // 
            // CreditTextEdit
            // 
            this.CreditTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gL_Voucher_Item_TypeBindingSource, "Credit", true));
            this.CreditTextEdit.Location = new System.Drawing.Point(836, 88);
            this.CreditTextEdit.MenuManager = this.ribbonControl;
            this.CreditTextEdit.Name = "CreditTextEdit";
            this.CreditTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.CreditTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.CreditTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CreditTextEdit.Properties.Mask.EditMask = "d";
            this.CreditTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.CreditTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.CreditTextEdit.Size = new System.Drawing.Size(259, 20);
            this.CreditTextEdit.StyleController = this.dataLayoutControl1;
            this.CreditTextEdit.TabIndex = 7;
            // 
            // NarrationTextEdit
            // 
            this.NarrationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gL_Voucher_Item_TypeBindingSource, "Narration", true));
            this.NarrationTextEdit.Location = new System.Drawing.Point(467, 64);
            this.NarrationTextEdit.MenuManager = this.ribbonControl;
            this.NarrationTextEdit.Name = "NarrationTextEdit";
            this.NarrationTextEdit.Size = new System.Drawing.Size(284, 20);
            this.NarrationTextEdit.StyleController = this.dataLayoutControl1;
            this.NarrationTextEdit.TabIndex = 8;
            // 
            // DateDateEdit
            // 
            this.DateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gL_Voucher_Item_TypeBindingSource, "Date", true));
            this.DateDateEdit.EditValue = null;
            this.DateDateEdit.Location = new System.Drawing.Point(836, 64);
            this.DateDateEdit.MenuManager = this.ribbonControl;
            this.DateDateEdit.Name = "DateDateEdit";
            this.DateDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.DateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateDateEdit.Size = new System.Drawing.Size(259, 20);
            this.DateDateEdit.StyleController = this.dataLayoutControl1;
            this.DateDateEdit.TabIndex = 9;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1119, 166);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(1099, 146);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup3.CaptionImageOptions.Image")));
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForAccountID,
            this.ItemForVoucherItemID,
            this.ItemForNarration,
            this.ItemForDebit,
            this.ItemForCredit,
            this.ItemForDate});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1099, 146);
            this.layoutControlGroup3.Text = "JV Enteries";
            // 
            // ItemForAccountID
            // 
            this.ItemForAccountID.Control = this.AccountIDTextEdit;
            this.ItemForAccountID.Location = new System.Drawing.Point(0, 24);
            this.ItemForAccountID.Name = "ItemForAccountID";
            this.ItemForAccountID.Size = new System.Drawing.Size(362, 58);
            this.ItemForAccountID.Text = "Account ID";
            this.ItemForAccountID.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForVoucherItemID
            // 
            this.ItemForVoucherItemID.Control = this.VoucherItemIDTextEdit;
            this.ItemForVoucherItemID.Location = new System.Drawing.Point(0, 0);
            this.ItemForVoucherItemID.Name = "ItemForVoucherItemID";
            this.ItemForVoucherItemID.Size = new System.Drawing.Size(362, 24);
            this.ItemForVoucherItemID.Text = "Voucher Item ID";
            this.ItemForVoucherItemID.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForNarration
            // 
            this.ItemForNarration.Control = this.NarrationTextEdit;
            this.ItemForNarration.Location = new System.Drawing.Point(362, 0);
            this.ItemForNarration.Name = "ItemForNarration";
            this.ItemForNarration.Size = new System.Drawing.Size(369, 24);
            this.ItemForNarration.Text = "Narration";
            this.ItemForNarration.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForDebit
            // 
            this.ItemForDebit.Control = this.DebitTextEdit;
            this.ItemForDebit.Location = new System.Drawing.Point(362, 24);
            this.ItemForDebit.Name = "ItemForDebit";
            this.ItemForDebit.Size = new System.Drawing.Size(369, 58);
            this.ItemForDebit.Text = "Debit";
            this.ItemForDebit.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForCredit
            // 
            this.ItemForCredit.Control = this.CreditTextEdit;
            this.ItemForCredit.Location = new System.Drawing.Point(731, 24);
            this.ItemForCredit.Name = "ItemForCredit";
            this.ItemForCredit.Size = new System.Drawing.Size(344, 58);
            this.ItemForCredit.Text = "Credit";
            this.ItemForCredit.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForDate
            // 
            this.ItemForDate.Control = this.DateDateEdit;
            this.ItemForDate.Location = new System.Drawing.Point(731, 0);
            this.ItemForDate.Name = "ItemForDate";
            this.ItemForDate.Size = new System.Drawing.Size(344, 24);
            this.ItemForDate.Text = "Date";
            this.ItemForDate.TextSize = new System.Drawing.Size(78, 13);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Enteries View";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDelete.ImageOptions.Image")));
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Columns";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Controls.Add(this.backstageViewClientControl1);
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem1);
            this.backstageViewControl1.Location = new System.Drawing.Point(71, 214);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.Size = new System.Drawing.Size(480, 150);
            this.backstageViewControl1.TabIndex = 4;
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Location = new System.Drawing.Point(188, 0);
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.Size = new System.Drawing.Size(292, 150);
            this.backstageViewClientControl1.TabIndex = 1;
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.Caption = "backstageViewTabItem1";
            this.backstageViewTabItem1.ContentControl = this.backstageViewClientControl1;
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            // 
            // InvoicesForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 714);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "InvoicesForm";
            this.Ribbon = this.ribbonControl;
            this.Text = "Journal Voucher Entery Form";
            this.Load += new System.EventHandler(this.GLEnteriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gL_Voucher_Item_TypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VoucherItemIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebitTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccountID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVoucherItemID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDebit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource gL_Voucher_Item_TypeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colVoucherItemID;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountID;
        private DevExpress.XtraGrid.Columns.GridColumn colDebit;
        private DevExpress.XtraGrid.Columns.GridColumn colCredit;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit VoucherItemIDTextEdit;
        private DevExpress.XtraEditors.TextEdit AccountIDTextEdit;
        private DevExpress.XtraEditors.TextEdit DebitTextEdit;
        private DevExpress.XtraEditors.TextEdit CreditTextEdit;
        private DevExpress.XtraEditors.TextEdit NarrationTextEdit;
        private DevExpress.XtraEditors.DateEdit DateDateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForVoucherItemID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAccountID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDebit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCredit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNarration;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDate;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
    }
}