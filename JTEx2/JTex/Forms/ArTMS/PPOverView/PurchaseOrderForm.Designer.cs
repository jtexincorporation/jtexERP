namespace JTex.Forms.ArTMS
{
    partial class PurchaseOrderForm
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
            DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderForm));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.poTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.clientLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packingTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ticketingTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.paymenttermTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.polybagTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.RefreshClientBtn = new DevExpress.XtraEditors.SimpleButton();
            this.CreateNewIDBtn = new DevExpress.XtraEditors.SimpleButton();
            this.purchaseOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForid = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemFordate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForpo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForclient = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForpolybag = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForpaymentterm = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForticketing = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForpacking = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.seasonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packingTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketingTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymenttermTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polybagTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFordate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForclient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpolybag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpaymentterm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForticketing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpacking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "ArticleName";
            gridColumn2.FieldName = "packing";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 2;
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
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 28;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1126, 116);
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Find using PO ";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Find";
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
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Update";
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
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Save";
            this.barButtonItem2.Id = 25;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Delete";
            this.barButtonItem3.Id = 26;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Clear";
            this.barButtonItem4.Id = 27;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem4);
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
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Purchase Order";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 116);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(1126, 48);
            this.bunifuFlatButton1.TabIndex = 6;
            this.bunifuFlatButton1.Text = "Purchase Order";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataLayoutControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 164);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1126, 195);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.idTextEdit);
            this.dataLayoutControl1.Controls.Add(this.dateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.poTextEdit);
            this.dataLayoutControl1.Controls.Add(this.clientLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.packingTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ticketingTextEdit);
            this.dataLayoutControl1.Controls.Add(this.paymenttermTextEdit);
            this.dataLayoutControl1.Controls.Add(this.polybagTextEdit);
            this.dataLayoutControl1.Controls.Add(this.simpleButton1);
            this.dataLayoutControl1.Controls.Add(this.RefreshClientBtn);
            this.dataLayoutControl1.Controls.Add(this.CreateNewIDBtn);
            this.dataLayoutControl1.DataSource = this.purchaseOrdersBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 3);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1120, 189);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // idTextEdit
            // 
            this.idTextEdit.Location = new System.Drawing.Point(91, 64);
            this.idTextEdit.MenuManager = this.ribbonControl;
            this.idTextEdit.Name = "idTextEdit";
            this.idTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.idTextEdit.Properties.Mask.EditMask = "d";
            this.idTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.idTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.idTextEdit.Size = new System.Drawing.Size(197, 20);
            this.idTextEdit.StyleController = this.dataLayoutControl1;
            this.idTextEdit.TabIndex = 4;
            this.idTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idTextEdit_KeyDown);
            // 
            // dateDateEdit
            // 
            this.dateDateEdit.EditValue = null;
            this.dateDateEdit.Location = new System.Drawing.Point(91, 90);
            this.dateDateEdit.MenuManager = this.ribbonControl;
            this.dateDateEdit.Name = "dateDateEdit";
            this.dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDateEdit.Size = new System.Drawing.Size(466, 20);
            this.dateDateEdit.StyleController = this.dataLayoutControl1;
            this.dateDateEdit.TabIndex = 5;
            // 
            // poTextEdit
            // 
            this.poTextEdit.Location = new System.Drawing.Point(91, 114);
            this.poTextEdit.MenuManager = this.ribbonControl;
            this.poTextEdit.Name = "poTextEdit";
            this.poTextEdit.Size = new System.Drawing.Size(466, 20);
            this.poTextEdit.StyleController = this.dataLayoutControl1;
            this.poTextEdit.TabIndex = 6;
            // 
            // clientLookUpEdit
            // 
            this.clientLookUpEdit.Location = new System.Drawing.Point(91, 138);
            this.clientLookUpEdit.MenuManager = this.ribbonControl;
            this.clientLookUpEdit.Name = "clientLookUpEdit";
            this.clientLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.clientLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.clientLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.clientLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("clientid", "clientid", 56, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("L4_id", "L4_id", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 36, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("address", "address", 48, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.clientLookUpEdit.Properties.DataSource = this.clientsBindingSource;
            this.clientLookUpEdit.Properties.DisplayMember = "name";
            this.clientLookUpEdit.Properties.NullText = "";
            this.clientLookUpEdit.Properties.ValueMember = "clientid";
            this.clientLookUpEdit.Size = new System.Drawing.Size(300, 20);
            this.clientLookUpEdit.StyleController = this.dataLayoutControl1;
            this.clientLookUpEdit.TabIndex = 7;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(Modelx.Client);
            // 
            // packingTextEdit
            // 
            this.packingTextEdit.EditValue = "N/A";
            this.packingTextEdit.Location = new System.Drawing.Point(628, 64);
            this.packingTextEdit.MenuManager = this.ribbonControl;
            this.packingTextEdit.Name = "packingTextEdit";
            this.packingTextEdit.Size = new System.Drawing.Size(468, 20);
            this.packingTextEdit.StyleController = this.dataLayoutControl1;
            this.packingTextEdit.TabIndex = 8;
            // 
            // ticketingTextEdit
            // 
            this.ticketingTextEdit.EditValue = "N/A";
            this.ticketingTextEdit.Location = new System.Drawing.Point(628, 90);
            this.ticketingTextEdit.MenuManager = this.ribbonControl;
            this.ticketingTextEdit.Name = "ticketingTextEdit";
            this.ticketingTextEdit.Size = new System.Drawing.Size(468, 20);
            this.ticketingTextEdit.StyleController = this.dataLayoutControl1;
            this.ticketingTextEdit.TabIndex = 9;
            // 
            // paymenttermTextEdit
            // 
            this.paymenttermTextEdit.EditValue = "N/A";
            this.paymenttermTextEdit.Location = new System.Drawing.Point(628, 114);
            this.paymenttermTextEdit.MenuManager = this.ribbonControl;
            this.paymenttermTextEdit.Name = "paymenttermTextEdit";
            this.paymenttermTextEdit.Size = new System.Drawing.Size(468, 20);
            this.paymenttermTextEdit.StyleController = this.dataLayoutControl1;
            this.paymenttermTextEdit.TabIndex = 10;
            // 
            // polybagTextEdit
            // 
            this.polybagTextEdit.EditValue = "N/A";
            this.polybagTextEdit.Location = new System.Drawing.Point(628, 138);
            this.polybagTextEdit.MenuManager = this.ribbonControl;
            this.polybagTextEdit.Name = "polybagTextEdit";
            this.polybagTextEdit.Size = new System.Drawing.Size(468, 20);
            this.polybagTextEdit.StyleController = this.dataLayoutControl1;
            this.polybagTextEdit.TabIndex = 11;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.Location = new System.Drawing.Point(395, 138);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(80, 22);
            this.simpleButton1.StyleController = this.dataLayoutControl1;
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "New";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // RefreshClientBtn
            // 
            this.RefreshClientBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RefreshClientBtn.ImageOptions.Image")));
            this.RefreshClientBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.RefreshClientBtn.Location = new System.Drawing.Point(479, 138);
            this.RefreshClientBtn.Name = "RefreshClientBtn";
            this.RefreshClientBtn.Size = new System.Drawing.Size(78, 22);
            this.RefreshClientBtn.StyleController = this.dataLayoutControl1;
            this.RefreshClientBtn.TabIndex = 13;
            this.RefreshClientBtn.Text = "Refresh";
            this.RefreshClientBtn.Click += new System.EventHandler(this.RefreshClientBtn_Click);
            // 
            // CreateNewIDBtn
            // 
            this.CreateNewIDBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CreateNewIDBtn.ImageOptions.Image")));
            this.CreateNewIDBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.CreateNewIDBtn.Location = new System.Drawing.Point(292, 64);
            this.CreateNewIDBtn.Name = "CreateNewIDBtn";
            this.CreateNewIDBtn.Size = new System.Drawing.Size(265, 22);
            this.CreateNewIDBtn.StyleController = this.dataLayoutControl1;
            this.CreateNewIDBtn.TabIndex = 14;
            this.CreateNewIDBtn.Text = "Create new ID";
            this.CreateNewIDBtn.Click += new System.EventHandler(this.CreateNewIDBtn_Click);
            // 
            // purchaseOrdersBindingSource
            // 
            this.purchaseOrdersBindingSource.DataSource = typeof(Modelx.PurchaseOrder);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1120, 189);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(1100, 169);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup3.CaptionImageOptions.Image")));
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForid,
            this.ItemFordate,
            this.ItemForpo,
            this.ItemForclient,
            this.ItemForpolybag,
            this.ItemForpaymentterm,
            this.ItemForticketing,
            this.ItemForpacking,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1100, 169);
            this.layoutControlGroup3.Text = "Purchase Order";
            // 
            // ItemForid
            // 
            this.ItemForid.Control = this.idTextEdit;
            this.ItemForid.Location = new System.Drawing.Point(0, 0);
            this.ItemForid.Name = "ItemForid";
            this.ItemForid.Size = new System.Drawing.Size(268, 26);
            this.ItemForid.Text = "id";
            this.ItemForid.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemFordate
            // 
            this.ItemFordate.Control = this.dateDateEdit;
            this.ItemFordate.Location = new System.Drawing.Point(0, 26);
            this.ItemFordate.Name = "ItemFordate";
            this.ItemFordate.Size = new System.Drawing.Size(537, 24);
            this.ItemFordate.Text = "date";
            this.ItemFordate.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForpo
            // 
            this.ItemForpo.Control = this.poTextEdit;
            this.ItemForpo.Location = new System.Drawing.Point(0, 50);
            this.ItemForpo.Name = "ItemForpo";
            this.ItemForpo.Size = new System.Drawing.Size(537, 24);
            this.ItemForpo.Text = "po";
            this.ItemForpo.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForclient
            // 
            this.ItemForclient.Control = this.clientLookUpEdit;
            this.ItemForclient.Location = new System.Drawing.Point(0, 74);
            this.ItemForclient.Name = "ItemForclient";
            this.ItemForclient.Size = new System.Drawing.Size(371, 31);
            this.ItemForclient.Text = "client";
            this.ItemForclient.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForpolybag
            // 
            this.ItemForpolybag.Control = this.polybagTextEdit;
            this.ItemForpolybag.Location = new System.Drawing.Point(537, 74);
            this.ItemForpolybag.Name = "ItemForpolybag";
            this.ItemForpolybag.Size = new System.Drawing.Size(539, 31);
            this.ItemForpolybag.Text = "polybag";
            this.ItemForpolybag.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForpaymentterm
            // 
            this.ItemForpaymentterm.Control = this.paymenttermTextEdit;
            this.ItemForpaymentterm.Location = new System.Drawing.Point(537, 50);
            this.ItemForpaymentterm.Name = "ItemForpaymentterm";
            this.ItemForpaymentterm.Size = new System.Drawing.Size(539, 24);
            this.ItemForpaymentterm.Text = "paymentterm";
            this.ItemForpaymentterm.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForticketing
            // 
            this.ItemForticketing.Control = this.ticketingTextEdit;
            this.ItemForticketing.Location = new System.Drawing.Point(537, 26);
            this.ItemForticketing.Name = "ItemForticketing";
            this.ItemForticketing.Size = new System.Drawing.Size(539, 24);
            this.ItemForticketing.Text = "ticketing";
            this.ItemForticketing.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForpacking
            // 
            this.ItemForpacking.Control = this.packingTextEdit;
            this.ItemForpacking.Location = new System.Drawing.Point(537, 0);
            this.ItemForpacking.Name = "ItemForpacking";
            this.ItemForpacking.Size = new System.Drawing.Size(539, 26);
            this.ItemForpacking.Text = "packing";
            this.ItemForpacking.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton1;
            this.layoutControlItem1.Location = new System.Drawing.Point(371, 74);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(84, 31);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.RefreshClientBtn;
            this.layoutControlItem2.Location = new System.Drawing.Point(455, 74);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(82, 31);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.CreateNewIDBtn;
            this.layoutControlItem3.Location = new System.Drawing.Point(268, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(269, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // seasonBindingSource
            // 
            this.seasonBindingSource.DataSource = typeof(Modelx.Season);
            // 
            // statusCategoryBindingSource
            // 
            this.statusCategoryBindingSource.DataSource = typeof(Modelx.StatusCategory);
            // 
            // queryBindingSource
            // 
            this.queryBindingSource.DataMember = "Query";
            this.queryBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ATMSEntityModel";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "SELECT ArticleID,StyleNumber,Name FROM Articles";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 684);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1126, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(251, 17);
            this.toolStripStatusLabel1.Text = "Press Tab on Article Name Column to get data";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.purchaseOrdersBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 359);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemSearchLookUpEdit2,
            this.repositoryItemSearchLookUpEdit3});
            this.gridControl1.Size = new System.Drawing.Size(1126, 325);
            this.gridControl1.TabIndex = 25;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn11,
            gridColumn2,
            this.gridColumn3,
            this.gridColumn10,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown_2);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Style#";
            this.gridColumn1.ColumnEdit = this.repositoryItemSearchLookUpEdit1;
            this.gridColumn1.FieldName = "articleid";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.DataSource = this.queryBindingSource;
            this.repositoryItemSearchLookUpEdit1.DisplayMember = "StyleNumber";
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.PopupView = this.repositoryItemSearchLookUpEdit1View;
            this.repositoryItemSearchLookUpEdit1.ValueMember = "ArticleID";
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Amount";
            this.gridColumn11.FieldName = "gridColumn11";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "gridColumn11", "SUM={0:0.##}")});
            this.gridColumn11.UnboundExpression = "[price] * [qty]";
            this.gridColumn11.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 7;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Composition";
            this.gridColumn3.FieldName = "paymentterm";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Weight";
            this.gridColumn10.FieldName = "polybag";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Season";
            this.gridColumn4.ColumnEdit = this.repositoryItemSearchLookUpEdit3;
            this.gridColumn4.FieldName = "season";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 10;
            // 
            // repositoryItemSearchLookUpEdit3
            // 
            this.repositoryItemSearchLookUpEdit3.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit3.DataSource = this.seasonBindingSource;
            this.repositoryItemSearchLookUpEdit3.DisplayMember = "Name";
            this.repositoryItemSearchLookUpEdit3.Name = "repositoryItemSearchLookUpEdit3";
            this.repositoryItemSearchLookUpEdit3.PopupView = this.repositoryItemSearchLookUpEdit3View;
            this.repositoryItemSearchLookUpEdit3.ValueMember = "SeasonID";
            // 
            // repositoryItemSearchLookUpEdit3View
            // 
            this.repositoryItemSearchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit3View.Name = "repositoryItemSearchLookUpEdit3View";
            this.repositoryItemSearchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "qty";
            this.gridColumn5.FieldName = "qty";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", "SUM={0:0.##}")});
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "price";
            this.gridColumn6.FieldName = "price";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "priceby";
            this.gridColumn7.ColumnEdit = this.repositoryItemComboBox1;
            this.gridColumn7.FieldName = "priceby";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 8;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "By Air",
            "By Sea",
            "F.O.B"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "delivery";
            this.gridColumn8.FieldName = "delivery";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 9;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "remarks";
            this.gridColumn9.FieldName = "remarks";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 11;
            // 
            // repositoryItemSearchLookUpEdit2
            // 
            this.repositoryItemSearchLookUpEdit2.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit2.DataSource = this.seasonBindingSource;
            this.repositoryItemSearchLookUpEdit2.DisplayMember = "Name";
            this.repositoryItemSearchLookUpEdit2.Name = "repositoryItemSearchLookUpEdit2";
            this.repositoryItemSearchLookUpEdit2.PopupView = this.repositoryItemSearchLookUpEdit2View;
            this.repositoryItemSearchLookUpEdit2.ValueMember = "SeasonID";
            // 
            // repositoryItemSearchLookUpEdit2View
            // 
            this.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
            this.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // PurchaseOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 706);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "PurchaseOrderForm";
            this.Text = "PurchaseOrderForm";
            this.Load += new System.EventHandler(this.PurchaseOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packingTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketingTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymenttermTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polybagTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFordate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForclient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpolybag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpaymentterm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForticketing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpacking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).EndInit();
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
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.BindingSource purchaseOrdersBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit idTextEdit;
        private DevExpress.XtraEditors.DateEdit dateDateEdit;
        private DevExpress.XtraEditors.TextEdit poTextEdit;
        private DevExpress.XtraEditors.LookUpEdit clientLookUpEdit;
        private DevExpress.XtraEditors.TextEdit packingTextEdit;
        private DevExpress.XtraEditors.TextEdit ticketingTextEdit;
        private DevExpress.XtraEditors.TextEdit paymenttermTextEdit;
        private DevExpress.XtraEditors.TextEdit polybagTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForid;
        private DevExpress.XtraLayout.LayoutControlItem ItemFordate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForpo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForclient;
        private DevExpress.XtraLayout.LayoutControlItem ItemForpolybag;
        private DevExpress.XtraLayout.LayoutControlItem ItemForpaymentterm;
        private DevExpress.XtraLayout.LayoutControlItem ItemForticketing;
        private DevExpress.XtraLayout.LayoutControlItem ItemForpacking;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton RefreshClientBtn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.BindingSource seasonBindingSource;
        private System.Windows.Forms.BindingSource statusCategoryBindingSource;
        private System.Windows.Forms.BindingSource queryBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit3View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.SimpleButton CreateNewIDBtn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}