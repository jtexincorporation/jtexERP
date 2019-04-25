namespace JTex.Forms.Inventory
{
    partial class StockxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockxForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Stock_idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.QtyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RemarksTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForStock_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUnitID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGPID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForQty = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRemarks = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEnteryType = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBinID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForProductID = new DevExpress.XtraLayout.LayoutControlItem();
            this.EnteryTypeTextEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.GPIDTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.gatePassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BinIDTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.vwBinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UnitIDTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductIDTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stock_idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStock_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGPID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEnteryType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBinID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnteryTypeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatePassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBinsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.09579F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.80843F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.BtnClear, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnDelete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnUpdate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnAdd, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 716);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1281, 48);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // BtnClear
            // 
            this.BtnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.ImageOptions.Image")));
            this.BtnClear.Location = new System.Drawing.Point(962, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(316, 42);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(644, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(312, 42);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.ImageOptions.Image")));
            this.BtnUpdate.Location = new System.Drawing.Point(323, 3);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(315, 42);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Update";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(3, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(314, 42);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataLayoutControl1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.4336F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.5664F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1281, 716);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1275, 555);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.Stock_idTextEdit);
            this.dataLayoutControl1.Controls.Add(this.QtyTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RemarksTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EnteryTypeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.GPIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BinIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UnitIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ProductIDTextEdit);
            this.dataLayoutControl1.DataMember = "Stock";
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 564);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(759, 513, 650, 400);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1275, 149);
            this.dataLayoutControl1.TabIndex = 18;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Stock_idTextEdit
            // 
            this.Stock_idTextEdit.Location = new System.Drawing.Point(86, 33);
            this.Stock_idTextEdit.Name = "Stock_idTextEdit";
            this.Stock_idTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Stock_idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Stock_idTextEdit.Properties.Mask.EditMask = "N0";
            this.Stock_idTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Stock_idTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Stock_idTextEdit.Size = new System.Drawing.Size(541, 20);
            this.Stock_idTextEdit.StyleController = this.dataLayoutControl1;
            this.Stock_idTextEdit.TabIndex = 4;
            // 
            // QtyTextEdit
            // 
            this.QtyTextEdit.Location = new System.Drawing.Point(86, 105);
            this.QtyTextEdit.Name = "QtyTextEdit";
            this.QtyTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.QtyTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.QtyTextEdit.Properties.Mask.EditMask = "N0";
            this.QtyTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.QtyTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.QtyTextEdit.Size = new System.Drawing.Size(541, 20);
            this.QtyTextEdit.StyleController = this.dataLayoutControl1;
            this.QtyTextEdit.TabIndex = 10;
            // 
            // RemarksTextEdit
            // 
            this.RemarksTextEdit.Location = new System.Drawing.Point(693, 105);
            this.RemarksTextEdit.Name = "RemarksTextEdit";
            this.RemarksTextEdit.Size = new System.Drawing.Size(541, 20);
            this.RemarksTextEdit.StyleController = this.dataLayoutControl1;
            this.RemarksTextEdit.TabIndex = 11;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1258, 180);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(1238, 160);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup3.CaptionImageOptions.Image")));
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForStock_id,
            this.ItemForUnitID,
            this.ItemForGPID,
            this.ItemForQty,
            this.ItemForRemarks,
            this.ItemForEnteryType,
            this.ItemForBinID,
            this.ItemForProductID});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1238, 160);
            this.layoutControlGroup3.Text = "Stock Operations e.g Store, Issue, Claim, Damage";
            // 
            // ItemForStock_id
            // 
            this.ItemForStock_id.Control = this.Stock_idTextEdit;
            this.ItemForStock_id.Location = new System.Drawing.Point(0, 0);
            this.ItemForStock_id.Name = "ItemForStock_id";
            this.ItemForStock_id.Size = new System.Drawing.Size(607, 24);
            this.ItemForStock_id.Text = "Stock_id";
            this.ItemForStock_id.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForUnitID
            // 
            this.ItemForUnitID.Control = this.UnitIDTextEdit;
            this.ItemForUnitID.Location = new System.Drawing.Point(0, 24);
            this.ItemForUnitID.Name = "ItemForUnitID";
            this.ItemForUnitID.Size = new System.Drawing.Size(607, 24);
            this.ItemForUnitID.Text = "Unit ID";
            this.ItemForUnitID.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForGPID
            // 
            this.ItemForGPID.Control = this.GPIDTextEdit;
            this.ItemForGPID.Location = new System.Drawing.Point(0, 48);
            this.ItemForGPID.Name = "ItemForGPID";
            this.ItemForGPID.Size = new System.Drawing.Size(607, 24);
            this.ItemForGPID.Text = "GPID";
            this.ItemForGPID.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForQty
            // 
            this.ItemForQty.Control = this.QtyTextEdit;
            this.ItemForQty.Location = new System.Drawing.Point(0, 72);
            this.ItemForQty.Name = "ItemForQty";
            this.ItemForQty.Size = new System.Drawing.Size(607, 24);
            this.ItemForQty.Text = "Qty";
            this.ItemForQty.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForRemarks
            // 
            this.ItemForRemarks.Control = this.RemarksTextEdit;
            this.ItemForRemarks.Location = new System.Drawing.Point(607, 72);
            this.ItemForRemarks.Name = "ItemForRemarks";
            this.ItemForRemarks.Size = new System.Drawing.Size(607, 24);
            this.ItemForRemarks.Text = "Remarks";
            this.ItemForRemarks.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForEnteryType
            // 
            this.ItemForEnteryType.Control = this.EnteryTypeTextEdit;
            this.ItemForEnteryType.Location = new System.Drawing.Point(607, 48);
            this.ItemForEnteryType.Name = "ItemForEnteryType";
            this.ItemForEnteryType.Size = new System.Drawing.Size(607, 24);
            this.ItemForEnteryType.Text = "Entery Type";
            this.ItemForEnteryType.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForBinID
            // 
            this.ItemForBinID.Control = this.BinIDTextEdit;
            this.ItemForBinID.Location = new System.Drawing.Point(607, 24);
            this.ItemForBinID.Name = "ItemForBinID";
            this.ItemForBinID.Size = new System.Drawing.Size(607, 24);
            this.ItemForBinID.Text = "Bin ID";
            this.ItemForBinID.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForProductID
            // 
            this.ItemForProductID.Control = this.ProductIDTextEdit;
            this.ItemForProductID.Location = new System.Drawing.Point(607, 0);
            this.ItemForProductID.Name = "ItemForProductID";
            this.ItemForProductID.Size = new System.Drawing.Size(607, 24);
            this.ItemForProductID.Text = "Product ID";
            this.ItemForProductID.TextSize = new System.Drawing.Size(59, 13);
            // 
            // EnteryTypeTextEdit
            // 
            this.EnteryTypeTextEdit.Location = new System.Drawing.Point(693, 81);
            this.EnteryTypeTextEdit.Name = "EnteryTypeTextEdit";
            this.EnteryTypeTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EnteryTypeTextEdit.Properties.Items.AddRange(new object[] {
            "Store",
            "Issue",
            "Claim",
            "Damage"});
            this.EnteryTypeTextEdit.Size = new System.Drawing.Size(541, 20);
            this.EnteryTypeTextEdit.StyleController = this.dataLayoutControl1;
            this.EnteryTypeTextEdit.TabIndex = 9;
            // 
            // GPIDTextEdit
            // 
            this.GPIDTextEdit.Location = new System.Drawing.Point(86, 81);
            this.GPIDTextEdit.Name = "GPIDTextEdit";
            this.GPIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.GPIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.GPIDTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GPIDTextEdit.Properties.DataSource = this.gatePassBindingSource;
            this.GPIDTextEdit.Properties.DisplayMember = "GPID";
            this.GPIDTextEdit.Properties.NullText = "";
            this.GPIDTextEdit.Properties.ValueMember = "GPID";
            this.GPIDTextEdit.Size = new System.Drawing.Size(541, 20);
            this.GPIDTextEdit.StyleController = this.dataLayoutControl1;
            this.GPIDTextEdit.TabIndex = 8;
            // 
            // gatePassBindingSource
            // 
            this.gatePassBindingSource.DataMember = "GatePass";
            this.gatePassBindingSource.Sort = "";
            // 
            // gatePassDataSet1
            // 
            // 
            // BinIDTextEdit
            // 
            this.BinIDTextEdit.Location = new System.Drawing.Point(693, 57);
            this.BinIDTextEdit.Name = "BinIDTextEdit";
            this.BinIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.BinIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BinIDTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BinIDTextEdit.Properties.DataSource = this.vwBinsBindingSource;
            this.BinIDTextEdit.Properties.DisplayMember = "BinID";
            this.BinIDTextEdit.Properties.NullText = "";
            this.BinIDTextEdit.Size = new System.Drawing.Size(541, 20);
            this.BinIDTextEdit.StyleController = this.dataLayoutControl1;
            this.BinIDTextEdit.TabIndex = 7;
            // 
            // vwBinsBindingSource
            // 
            this.vwBinsBindingSource.DataMember = "vwBins";
            this.vwBinsBindingSource.Sort = "";
            // 
            // binDataSet1
            // 
            // UnitIDTextEdit
            // 
            this.UnitIDTextEdit.Location = new System.Drawing.Point(86, 57);
            this.UnitIDTextEdit.Name = "UnitIDTextEdit";
            this.UnitIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.UnitIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.UnitIDTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UnitIDTextEdit.Properties.DataSource = this.unitBindingSource;
            this.UnitIDTextEdit.Properties.DisplayMember = "UnitID";
            this.UnitIDTextEdit.Properties.NullText = "";
            this.UnitIDTextEdit.Properties.ValueMember = "UnitID";
            this.UnitIDTextEdit.Size = new System.Drawing.Size(541, 20);
            this.UnitIDTextEdit.StyleController = this.dataLayoutControl1;
            this.UnitIDTextEdit.TabIndex = 6;
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "Unit";
            this.unitBindingSource.Sort = "";
            // 
            // unitDataSet1
            // 
            // 
            // ProductIDTextEdit
            // 
            this.ProductIDTextEdit.Location = new System.Drawing.Point(693, 33);
            this.ProductIDTextEdit.Name = "ProductIDTextEdit";
            this.ProductIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ProductIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ProductIDTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ProductIDTextEdit.Properties.DataSource = this.productsBindingSource;
            this.ProductIDTextEdit.Properties.DisplayMember = "ProductID";
            this.ProductIDTextEdit.Properties.NullText = "";
            this.ProductIDTextEdit.Properties.ValueMember = "ProductID";
            this.ProductIDTextEdit.Size = new System.Drawing.Size(541, 20);
            this.ProductIDTextEdit.StyleController = this.dataLayoutControl1;
            this.ProductIDTextEdit.TabIndex = 5;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.Sort = "";
            // 
            // productDataSet1
            // 
            // productsTableAdapter1
            // 
            // StockxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 764);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StockxForm";
            this.Text = "StockxForm";
            this.Load += new System.EventHandler(this.StockxForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Stock_idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStock_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGPID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEnteryType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBinID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnteryTypeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatePassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBinsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton BtnClear;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit Stock_idTextEdit;
        private DevExpress.XtraEditors.TextEdit QtyTextEdit;
        private DevExpress.XtraEditors.TextEdit RemarksTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStock_id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUnitID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGPID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForQty;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemarks;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEnteryType;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBinID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProductID;
        private DevExpress.XtraEditors.ComboBoxEdit EnteryTypeTextEdit;
        private DevExpress.XtraEditors.LookUpEdit GPIDTextEdit;
        private System.Windows.Forms.BindingSource gatePassBindingSource;
        private DevExpress.XtraEditors.LookUpEdit BinIDTextEdit;
        private System.Windows.Forms.BindingSource vwBinsBindingSource;
        private DevExpress.XtraEditors.LookUpEdit UnitIDTextEdit;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private DevExpress.XtraEditors.LookUpEdit ProductIDTextEdit;
        private System.Windows.Forms.BindingSource productsBindingSource;
    }
}