namespace JTex.Forms.Inventory
{
    partial class BinsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinsForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.BinIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RackNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RowNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ShelfNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForBinID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForStoreID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRackNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRowNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForShelfNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.StoreIDTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.storesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BinIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RackNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShelfNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBinID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStoreID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRackNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRowNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShelfNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 731);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1253, 48);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // BtnClear
            // 
            this.BtnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.ImageOptions.Image")));
            this.BtnClear.Location = new System.Drawing.Point(941, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(309, 42);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(630, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(305, 42);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.ImageOptions.Image")));
            this.BtnUpdate.Location = new System.Drawing.Point(316, 3);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(308, 42);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Update";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(3, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(307, 42);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1253, 731);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1247, 567);
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
            this.dataLayoutControl1.Controls.Add(this.BinIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RackNumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RowNumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ShelfNumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.StoreIDTextEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 576);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1247, 152);
            this.dataLayoutControl1.TabIndex = 18;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // BinIDTextEdit
            // 
            this.BinIDTextEdit.Location = new System.Drawing.Point(91, 64);
            this.BinIDTextEdit.Name = "BinIDTextEdit";
            this.BinIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.BinIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BinIDTextEdit.Properties.Mask.EditMask = "N0";
            this.BinIDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.BinIDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.BinIDTextEdit.Size = new System.Drawing.Size(490, 20);
            this.BinIDTextEdit.StyleController = this.dataLayoutControl1;
            this.BinIDTextEdit.TabIndex = 4;
            // 
            // RackNumberTextEdit
            // 
            this.RackNumberTextEdit.Location = new System.Drawing.Point(91, 88);
            this.RackNumberTextEdit.Name = "RackNumberTextEdit";
            this.RackNumberTextEdit.Size = new System.Drawing.Size(490, 20);
            this.RackNumberTextEdit.StyleController = this.dataLayoutControl1;
            this.RackNumberTextEdit.TabIndex = 6;
            // 
            // RowNumberTextEdit
            // 
            this.RowNumberTextEdit.Location = new System.Drawing.Point(652, 88);
            this.RowNumberTextEdit.Name = "RowNumberTextEdit";
            this.RowNumberTextEdit.Size = new System.Drawing.Size(217, 20);
            this.RowNumberTextEdit.StyleController = this.dataLayoutControl1;
            this.RowNumberTextEdit.TabIndex = 7;
            // 
            // ShelfNumberTextEdit
            // 
            this.ShelfNumberTextEdit.Location = new System.Drawing.Point(940, 88);
            this.ShelfNumberTextEdit.Name = "ShelfNumberTextEdit";
            this.ShelfNumberTextEdit.Size = new System.Drawing.Size(283, 20);
            this.ShelfNumberTextEdit.StyleController = this.dataLayoutControl1;
            this.ShelfNumberTextEdit.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1247, 152);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(1227, 132);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup3.CaptionImageOptions.Image")));
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForBinID,
            this.ItemForStoreID,
            this.ItemForRackNumber,
            this.ItemForRowNumber,
            this.ItemForShelfNumber});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1227, 132);
            this.layoutControlGroup3.Text = "Bin E.g Acessory Store Bin#2 ";
            // 
            // ItemForBinID
            // 
            this.ItemForBinID.Control = this.BinIDTextEdit;
            this.ItemForBinID.Location = new System.Drawing.Point(0, 0);
            this.ItemForBinID.Name = "ItemForBinID";
            this.ItemForBinID.Size = new System.Drawing.Size(561, 24);
            this.ItemForBinID.Text = "Bin ID";
            this.ItemForBinID.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForStoreID
            // 
            this.ItemForStoreID.Control = this.StoreIDTextEdit;
            this.ItemForStoreID.Location = new System.Drawing.Point(561, 0);
            this.ItemForStoreID.Name = "ItemForStoreID";
            this.ItemForStoreID.Size = new System.Drawing.Size(642, 24);
            this.ItemForStoreID.Text = "Store ID";
            this.ItemForStoreID.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForRackNumber
            // 
            this.ItemForRackNumber.Control = this.RackNumberTextEdit;
            this.ItemForRackNumber.Location = new System.Drawing.Point(0, 24);
            this.ItemForRackNumber.Name = "ItemForRackNumber";
            this.ItemForRackNumber.Size = new System.Drawing.Size(561, 44);
            this.ItemForRackNumber.Text = "Rack Number";
            this.ItemForRackNumber.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForRowNumber
            // 
            this.ItemForRowNumber.Control = this.RowNumberTextEdit;
            this.ItemForRowNumber.Location = new System.Drawing.Point(561, 24);
            this.ItemForRowNumber.Name = "ItemForRowNumber";
            this.ItemForRowNumber.Size = new System.Drawing.Size(288, 44);
            this.ItemForRowNumber.Text = "Row Number";
            this.ItemForRowNumber.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForShelfNumber
            // 
            this.ItemForShelfNumber.Control = this.ShelfNumberTextEdit;
            this.ItemForShelfNumber.Location = new System.Drawing.Point(849, 24);
            this.ItemForShelfNumber.Name = "ItemForShelfNumber";
            this.ItemForShelfNumber.Size = new System.Drawing.Size(354, 44);
            this.ItemForShelfNumber.Text = "Shelf Number";
            this.ItemForShelfNumber.TextSize = new System.Drawing.Size(64, 13);
            // 
            // StoreIDTextEdit
            // 
            this.StoreIDTextEdit.Location = new System.Drawing.Point(652, 64);
            this.StoreIDTextEdit.Name = "StoreIDTextEdit";
            this.StoreIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.StoreIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.StoreIDTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StoreIDTextEdit.Properties.DataSource = this.storesBindingSource;
            this.StoreIDTextEdit.Properties.DisplayMember = "StoreID";
            this.StoreIDTextEdit.Properties.NullText = "";
            this.StoreIDTextEdit.Properties.ValueMember = "StoreID";
            this.StoreIDTextEdit.Size = new System.Drawing.Size(571, 20);
            this.StoreIDTextEdit.StyleController = this.dataLayoutControl1;
            this.StoreIDTextEdit.TabIndex = 5;
            // 
            // storesBindingSource
            // 
            this.storesBindingSource.DataMember = "Stores";
            this.storesBindingSource.Sort = "";
            // 
            // storeDataSet1
            // 
            // 
            // storesTableAdapter1
            // 
            // 
            // BinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 779);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BinsForm";
            this.Text = "BinsForm";
            this.Load += new System.EventHandler(this.BinsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BinIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RackNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShelfNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBinID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStoreID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRackNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRowNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShelfNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit BinIDTextEdit;
        private DevExpress.XtraEditors.TextEdit RackNumberTextEdit;
        private DevExpress.XtraEditors.TextEdit RowNumberTextEdit;
        private DevExpress.XtraEditors.TextEdit ShelfNumberTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBinID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStoreID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRackNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRowNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForShelfNumber;
        private DevExpress.XtraEditors.LookUpEdit StoreIDTextEdit;
        private System.Windows.Forms.BindingSource storesBindingSource;
    }
}