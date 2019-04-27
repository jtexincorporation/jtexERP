namespace JTex.Forms.Inventory.Yarn
{
    partial class FormDemand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDemand));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.DemandSave = new DevExpress.XtraBars.BarButtonItem();
            this.UpdateDemand = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteDemand = new DevExpress.XtraBars.BarButtonItem();
            this.ClearDemand = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.DemandExit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.button1 = new System.Windows.Forms.Button();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Demand_idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.demandGenerateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Demand_BagsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Demand_netWeightTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Demand_GtWeightTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Demand_poTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.purchaseOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Demand_yarnIDTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.yDefinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForDemand_po = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDemand_yarnID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDemand_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDemand_Bags = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDemand_netWeight = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDemand_GtWeight = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Demand_idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandGenerateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Demand_BagsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Demand_netWeightTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Demand_GtWeightTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Demand_poTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Demand_yarnIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yDefinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDemand_po)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDemand_yarnID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDemand_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDemand_Bags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDemand_netWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDemand_GtWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.DemandSave,
            this.UpdateDemand,
            this.DeleteDemand,
            this.ClearDemand,
            this.barButtonItem1,
            this.DemandExit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbon.Size = new System.Drawing.Size(1222, 130);
            // 
            // DemandSave
            // 
            this.DemandSave.Caption = "Save";
            this.DemandSave.Id = 1;
            this.DemandSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DemandSave.ImageOptions.Image")));
            this.DemandSave.Name = "DemandSave";
            this.DemandSave.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.DemandSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DemandSave_ItemClick);
            // 
            // UpdateDemand
            // 
            this.UpdateDemand.Caption = "Update";
            this.UpdateDemand.Id = 2;
            this.UpdateDemand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("UpdateDemand.ImageOptions.Image")));
            this.UpdateDemand.Name = "UpdateDemand";
            this.UpdateDemand.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.UpdateDemand.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UpdateDemand_ItemClick);
            // 
            // DeleteDemand
            // 
            this.DeleteDemand.Caption = "Delete";
            this.DeleteDemand.Enabled = false;
            this.DeleteDemand.Id = 3;
            this.DeleteDemand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DeleteDemand.ImageOptions.Image")));
            this.DeleteDemand.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DeleteDemand.ImageOptions.LargeImage")));
            this.DeleteDemand.Name = "DeleteDemand";
            this.DeleteDemand.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // ClearDemand
            // 
            this.ClearDemand.Caption = "Clear";
            this.ClearDemand.Id = 4;
            this.ClearDemand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ClearDemand.ImageOptions.Image")));
            this.ClearDemand.Name = "ClearDemand";
            this.ClearDemand.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.ClearDemand.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClearDemand_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Print and Preview";
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // DemandExit
            // 
            this.DemandExit.Caption = "Exit";
            this.DemandExit.Id = 6;
            this.DemandExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DemandExit.ImageOptions.Image")));
            this.DemandExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DemandExit.ImageOptions.LargeImage")));
            this.DemandExit.Name = "DemandExit";
            this.DemandExit.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.DemandExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DemandExit_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Operations";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.DemandSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.UpdateDemand);
            this.ribbonPageGroup1.ItemLinks.Add(this.DeleteDemand);
            this.ribbonPageGroup1.ItemLinks.Add(this.ClearDemand);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Print and Preview";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.DemandExit);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Exit";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1222, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate Demand";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.Demand_idTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Demand_BagsTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Demand_netWeightTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Demand_GtWeightTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Demand_poTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Demand_yarnIDTextEdit);
            this.dataLayoutControl1.DataSource = this.demandGenerateBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 174);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1222, 168);
            this.dataLayoutControl1.TabIndex = 3;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Demand_idTextEdit
            // 
            this.Demand_idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.demandGenerateBindingSource, "Demand_id", true));
            this.Demand_idTextEdit.Location = new System.Drawing.Point(81, 112);
            this.Demand_idTextEdit.MenuManager = this.ribbon;
            this.Demand_idTextEdit.Name = "Demand_idTextEdit";
            this.Demand_idTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Demand_idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Demand_idTextEdit.Properties.Mask.EditMask = "d";
            this.Demand_idTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Demand_idTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Demand_idTextEdit.Size = new System.Drawing.Size(1117, 20);
            this.Demand_idTextEdit.StyleController = this.dataLayoutControl1;
            this.Demand_idTextEdit.TabIndex = 4;
            // 
            // demandGenerateBindingSource
            // 
            this.demandGenerateBindingSource.DataSource = typeof(IMS.DemandGenerate);
            // 
            // Demand_BagsTextEdit
            // 
            this.Demand_BagsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.demandGenerateBindingSource, "Demand_Bags", true));
            this.Demand_BagsTextEdit.Location = new System.Drawing.Point(671, 64);
            this.Demand_BagsTextEdit.MenuManager = this.ribbon;
            this.Demand_BagsTextEdit.Name = "Demand_BagsTextEdit";
            this.Demand_BagsTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Demand_BagsTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Demand_BagsTextEdit.Properties.Mask.EditMask = "d";
            this.Demand_BagsTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Demand_BagsTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Demand_BagsTextEdit.Size = new System.Drawing.Size(527, 20);
            this.Demand_BagsTextEdit.StyleController = this.dataLayoutControl1;
            this.Demand_BagsTextEdit.TabIndex = 7;
            this.Demand_BagsTextEdit.DoubleClick += new System.EventHandler(this.Demand_BagsTextEdit_DoubleClick);
            // 
            // Demand_netWeightTextEdit
            // 
            this.Demand_netWeightTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.demandGenerateBindingSource, "Demand_netWeight", true));
            this.Demand_netWeightTextEdit.Location = new System.Drawing.Point(669, 88);
            this.Demand_netWeightTextEdit.MenuManager = this.ribbon;
            this.Demand_netWeightTextEdit.Name = "Demand_netWeightTextEdit";
            this.Demand_netWeightTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Demand_netWeightTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Demand_netWeightTextEdit.Properties.Mask.EditMask = "F";
            this.Demand_netWeightTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Demand_netWeightTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Demand_netWeightTextEdit.Size = new System.Drawing.Size(234, 20);
            this.Demand_netWeightTextEdit.StyleController = this.dataLayoutControl1;
            this.Demand_netWeightTextEdit.TabIndex = 8;
            // 
            // Demand_GtWeightTextEdit
            // 
            this.Demand_GtWeightTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.demandGenerateBindingSource, "Demand_GtWeight", true));
            this.Demand_GtWeightTextEdit.Location = new System.Drawing.Point(964, 88);
            this.Demand_GtWeightTextEdit.MenuManager = this.ribbon;
            this.Demand_GtWeightTextEdit.Name = "Demand_GtWeightTextEdit";
            this.Demand_GtWeightTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Demand_GtWeightTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Demand_GtWeightTextEdit.Properties.Mask.EditMask = "F";
            this.Demand_GtWeightTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Demand_GtWeightTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Demand_GtWeightTextEdit.Size = new System.Drawing.Size(234, 20);
            this.Demand_GtWeightTextEdit.StyleController = this.dataLayoutControl1;
            this.Demand_GtWeightTextEdit.TabIndex = 9;
            // 
            // Demand_poTextEdit
            // 
            this.Demand_poTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.demandGenerateBindingSource, "Demand_po", true));
            this.Demand_poTextEdit.Location = new System.Drawing.Point(81, 64);
            this.Demand_poTextEdit.MenuManager = this.ribbon;
            this.Demand_poTextEdit.Name = "Demand_poTextEdit";
            this.Demand_poTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Demand_poTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Demand_poTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Demand_poTextEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("doc", "doc"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("date", "date"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("po", "PO"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("client", "clients")});
            this.Demand_poTextEdit.Properties.DataSource = this.purchaseOrdersBindingSource;
            this.Demand_poTextEdit.Properties.DisplayMember = "po";
            this.Demand_poTextEdit.Properties.NullText = "";
            this.Demand_poTextEdit.Properties.ValueMember = "doc";
            this.Demand_poTextEdit.Size = new System.Drawing.Size(529, 20);
            this.Demand_poTextEdit.StyleController = this.dataLayoutControl1;
            this.Demand_poTextEdit.TabIndex = 5;
            // 
            // purchaseOrdersBindingSource
            // 
            this.purchaseOrdersBindingSource.DataSource = typeof(Modelx.PurchaseOrder);
            // 
            // Demand_yarnIDTextEdit
            // 
            this.Demand_yarnIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.demandGenerateBindingSource, "Demand_yarnID", true));
            this.Demand_yarnIDTextEdit.Location = new System.Drawing.Point(81, 88);
            this.Demand_yarnIDTextEdit.MenuManager = this.ribbon;
            this.Demand_yarnIDTextEdit.Name = "Demand_yarnIDTextEdit";
            this.Demand_yarnIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Demand_yarnIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Demand_yarnIDTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Demand_yarnIDTextEdit.Properties.DataSource = this.yDefinesBindingSource;
            this.Demand_yarnIDTextEdit.Properties.DisplayMember = "Yarn_id";
            this.Demand_yarnIDTextEdit.Properties.NullText = "";
            this.Demand_yarnIDTextEdit.Properties.ValueMember = "Yarn_id";
            this.Demand_yarnIDTextEdit.Size = new System.Drawing.Size(527, 20);
            this.Demand_yarnIDTextEdit.StyleController = this.dataLayoutControl1;
            this.Demand_yarnIDTextEdit.TabIndex = 6;
            // 
            // yDefinesBindingSource
            // 
            this.yDefinesBindingSource.DataSource = typeof(IMS.yDefine);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1222, 168);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(1202, 148);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup3.CaptionImageOptions.Image")));
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForDemand_po,
            this.ItemForDemand_yarnID,
            this.ItemForDemand_id,
            this.ItemForDemand_Bags,
            this.ItemForDemand_netWeight,
            this.ItemForDemand_GtWeight});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1202, 148);
            this.layoutControlGroup3.Text = "Generate Demand";
            // 
            // ItemForDemand_po
            // 
            this.ItemForDemand_po.Control = this.Demand_poTextEdit;
            this.ItemForDemand_po.Location = new System.Drawing.Point(0, 0);
            this.ItemForDemand_po.Name = "ItemForDemand_po";
            this.ItemForDemand_po.Size = new System.Drawing.Size(590, 24);
            this.ItemForDemand_po.Text = "PO #";
            this.ItemForDemand_po.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForDemand_yarnID
            // 
            this.ItemForDemand_yarnID.Control = this.Demand_yarnIDTextEdit;
            this.ItemForDemand_yarnID.Location = new System.Drawing.Point(0, 24);
            this.ItemForDemand_yarnID.Name = "ItemForDemand_yarnID";
            this.ItemForDemand_yarnID.Size = new System.Drawing.Size(588, 24);
            this.ItemForDemand_yarnID.Text = "Yarn";
            this.ItemForDemand_yarnID.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForDemand_id
            // 
            this.ItemForDemand_id.Control = this.Demand_idTextEdit;
            this.ItemForDemand_id.Location = new System.Drawing.Point(0, 48);
            this.ItemForDemand_id.Name = "ItemForDemand_id";
            this.ItemForDemand_id.Size = new System.Drawing.Size(1178, 36);
            this.ItemForDemand_id.Text = "Demand_id";
            this.ItemForDemand_id.TextSize = new System.Drawing.Size(54, 13);
            this.ItemForDemand_id.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // ItemForDemand_Bags
            // 
            this.ItemForDemand_Bags.Control = this.Demand_BagsTextEdit;
            this.ItemForDemand_Bags.Location = new System.Drawing.Point(590, 0);
            this.ItemForDemand_Bags.Name = "ItemForDemand_Bags";
            this.ItemForDemand_Bags.Size = new System.Drawing.Size(588, 24);
            this.ItemForDemand_Bags.Text = "Bags";
            this.ItemForDemand_Bags.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForDemand_netWeight
            // 
            this.ItemForDemand_netWeight.Control = this.Demand_netWeightTextEdit;
            this.ItemForDemand_netWeight.Location = new System.Drawing.Point(588, 24);
            this.ItemForDemand_netWeight.Name = "ItemForDemand_netWeight";
            this.ItemForDemand_netWeight.Size = new System.Drawing.Size(295, 24);
            this.ItemForDemand_netWeight.Text = "Net Weight";
            this.ItemForDemand_netWeight.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForDemand_GtWeight
            // 
            this.ItemForDemand_GtWeight.Control = this.Demand_GtWeightTextEdit;
            this.ItemForDemand_GtWeight.Location = new System.Drawing.Point(883, 24);
            this.ItemForDemand_GtWeight.Name = "ItemForDemand_GtWeight";
            this.ItemForDemand_GtWeight.Size = new System.Drawing.Size(295, 24);
            this.ItemForDemand_GtWeight.Text = "GT Weight";
            this.ItemForDemand_GtWeight.TextSize = new System.Drawing.Size(54, 13);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 342);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1222, 403);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // FormDemand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 745);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ribbon);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Name = "FormDemand";
            this.Ribbon = this.ribbon;
            this.Text = "FormDemand";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Demand_idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandGenerateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Demand_BagsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Demand_netWeightTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Demand_GtWeightTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Demand_poTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Demand_yarnIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yDefinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDemand_po)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDemand_yarnID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDemand_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDemand_Bags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDemand_netWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDemand_GtWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem DemandSave;
        private DevExpress.XtraBars.BarButtonItem UpdateDemand;
        private DevExpress.XtraBars.BarButtonItem DeleteDemand;
        private DevExpress.XtraBars.BarButtonItem ClearDemand;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem DemandExit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit Demand_idTextEdit;
        private System.Windows.Forms.BindingSource demandGenerateBindingSource;
        private DevExpress.XtraEditors.TextEdit Demand_BagsTextEdit;
        private DevExpress.XtraEditors.TextEdit Demand_netWeightTextEdit;
        private DevExpress.XtraEditors.TextEdit Demand_GtWeightTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDemand_id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDemand_po;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDemand_yarnID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDemand_Bags;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDemand_netWeight;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDemand_GtWeight;
        private DevExpress.XtraEditors.LookUpEdit Demand_poTextEdit;
        private DevExpress.XtraEditors.LookUpEdit Demand_yarnIDTextEdit;
        private System.Windows.Forms.BindingSource purchaseOrdersBindingSource;
        private System.Windows.Forms.BindingSource yDefinesBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    }
}