namespace JTex.Forms.Inventory
{
    partial class ProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ProductIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.productDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UnitIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ProductNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CategoryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PicturePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.PicturePathTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.StoreIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForPicture = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForUnitID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForStoreID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPicturePath = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForProductID = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForProductName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCategory = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePathTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStoreID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPicturePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategory)).BeginInit();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 755);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 48);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // BtnClear
            // 
            this.BtnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.ImageOptions.Image")));
            this.BtnClear.Location = new System.Drawing.Point(887, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(292, 42);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(594, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(287, 42);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.ImageOptions.Image")));
            this.BtnUpdate.Location = new System.Drawing.Point(298, 3);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(290, 42);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Update";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(3, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(289, 42);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1182, 755);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1176, 586);
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
            this.dataLayoutControl1.Controls.Add(this.ProductIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UnitIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ProductNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CategoryTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PicturePictureEdit);
            this.dataLayoutControl1.Controls.Add(this.PicturePathTextEdit);
            this.dataLayoutControl1.Controls.Add(this.StoreIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.textEdit1);
            this.dataLayoutControl1.DataMember = "Products";
            this.dataLayoutControl1.DataSource = this.productDataSetBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 595);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1176, 157);
            this.dataLayoutControl1.TabIndex = 18;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // ProductIDTextEdit
            // 
            this.ProductIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productDataSetBindingSource, "Products.ProductID", true));
            this.ProductIDTextEdit.Location = new System.Drawing.Point(94, 64);
            this.ProductIDTextEdit.Name = "ProductIDTextEdit";
            this.ProductIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ProductIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ProductIDTextEdit.Properties.Mask.EditMask = "N0";
            this.ProductIDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ProductIDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ProductIDTextEdit.Size = new System.Drawing.Size(301, 20);
            this.ProductIDTextEdit.StyleController = this.dataLayoutControl1;
            this.ProductIDTextEdit.TabIndex = 4;
            // 
            // productDataSetBindingSource
            // 
            this.productDataSetBindingSource.Position = 0;
            // 
            // productDataSet
            // 
            // 
            // UnitIDTextEdit
            // 
            this.UnitIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productDataSetBindingSource, "Products.UnitID", true));
            this.UnitIDTextEdit.Location = new System.Drawing.Point(469, 64);
            this.UnitIDTextEdit.Name = "UnitIDTextEdit";
            this.UnitIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.UnitIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.UnitIDTextEdit.Properties.Mask.EditMask = "N0";
            this.UnitIDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.UnitIDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.UnitIDTextEdit.Size = new System.Drawing.Size(191, 20);
            this.UnitIDTextEdit.StyleController = this.dataLayoutControl1;
            this.UnitIDTextEdit.TabIndex = 5;
            // 
            // ProductNameTextEdit
            // 
            this.ProductNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productDataSetBindingSource, "Products.ProductName", true));
            this.ProductNameTextEdit.Location = new System.Drawing.Point(469, 88);
            this.ProductNameTextEdit.Name = "ProductNameTextEdit";
            this.ProductNameTextEdit.Size = new System.Drawing.Size(191, 20);
            this.ProductNameTextEdit.StyleController = this.dataLayoutControl1;
            this.ProductNameTextEdit.TabIndex = 6;
            // 
            // CategoryTextEdit
            // 
            this.CategoryTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productDataSetBindingSource, "Products.Category", true));
            this.CategoryTextEdit.Location = new System.Drawing.Point(734, 88);
            this.CategoryTextEdit.Name = "CategoryTextEdit";
            this.CategoryTextEdit.Size = new System.Drawing.Size(191, 20);
            this.CategoryTextEdit.StyleController = this.dataLayoutControl1;
            this.CategoryTextEdit.TabIndex = 7;
            // 
            // PicturePictureEdit
            // 
            this.PicturePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productDataSetBindingSource, "Products.Picture", true));
            this.PicturePictureEdit.Location = new System.Drawing.Point(941, 12);
            this.PicturePictureEdit.Name = "PicturePictureEdit";
            this.PicturePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.PicturePictureEdit.Size = new System.Drawing.Size(223, 133);
            this.PicturePictureEdit.StyleController = this.dataLayoutControl1;
            this.PicturePictureEdit.TabIndex = 8;
            // 
            // PicturePathTextEdit
            // 
            this.PicturePathTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productDataSetBindingSource, "Products.PicturePath", true));
            this.PicturePathTextEdit.Location = new System.Drawing.Point(94, 112);
            this.PicturePathTextEdit.Name = "PicturePathTextEdit";
            this.PicturePathTextEdit.Size = new System.Drawing.Size(831, 20);
            this.PicturePathTextEdit.StyleController = this.dataLayoutControl1;
            this.PicturePathTextEdit.TabIndex = 9;
            // 
            // StoreIDTextEdit
            // 
            this.StoreIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productDataSetBindingSource, "Products.StoreID", true));
            this.StoreIDTextEdit.Location = new System.Drawing.Point(94, 88);
            this.StoreIDTextEdit.Name = "StoreIDTextEdit";
            this.StoreIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.StoreIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.StoreIDTextEdit.Properties.Mask.EditMask = "N0";
            this.StoreIDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.StoreIDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.StoreIDTextEdit.Size = new System.Drawing.Size(301, 20);
            this.StoreIDTextEdit.StyleController = this.dataLayoutControl1;
            this.StoreIDTextEdit.TabIndex = 10;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(734, 64);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(191, 20);
            this.textEdit1.StyleController = this.dataLayoutControl1;
            this.textEdit1.TabIndex = 11;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1176, 157);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForPicture,
            this.layoutControlGroup3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1156, 137);
            // 
            // ItemForPicture
            // 
            this.ItemForPicture.Control = this.PicturePictureEdit;
            this.ItemForPicture.Location = new System.Drawing.Point(929, 0);
            this.ItemForPicture.Name = "ItemForPicture";
            this.ItemForPicture.Size = new System.Drawing.Size(227, 137);
            this.ItemForPicture.StartNewLine = true;
            this.ItemForPicture.Text = "Picture";
            this.ItemForPicture.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForPicture.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup3.CaptionImageOptions.Image")));
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForUnitID,
            this.ItemForStoreID,
            this.ItemForPicturePath,
            this.ItemForProductID,
            this.layoutControlItem1,
            this.ItemForProductName,
            this.ItemForCategory});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(929, 137);
            this.layoutControlGroup3.Text = "Product E.g labels";
            // 
            // ItemForUnitID
            // 
            this.ItemForUnitID.Control = this.UnitIDTextEdit;
            this.ItemForUnitID.Location = new System.Drawing.Point(375, 0);
            this.ItemForUnitID.Name = "ItemForUnitID";
            this.ItemForUnitID.Size = new System.Drawing.Size(265, 24);
            this.ItemForUnitID.Text = "Unit ID";
            this.ItemForUnitID.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForStoreID
            // 
            this.ItemForStoreID.Control = this.StoreIDTextEdit;
            this.ItemForStoreID.Location = new System.Drawing.Point(0, 24);
            this.ItemForStoreID.Name = "ItemForStoreID";
            this.ItemForStoreID.Size = new System.Drawing.Size(375, 24);
            this.ItemForStoreID.Text = "Store ID";
            this.ItemForStoreID.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForPicturePath
            // 
            this.ItemForPicturePath.Control = this.PicturePathTextEdit;
            this.ItemForPicturePath.Location = new System.Drawing.Point(0, 48);
            this.ItemForPicturePath.Name = "ItemForPicturePath";
            this.ItemForPicturePath.Size = new System.Drawing.Size(905, 25);
            this.ItemForPicturePath.Text = "Picture Path";
            this.ItemForPicturePath.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForProductID
            // 
            this.ItemForProductID.Control = this.ProductIDTextEdit;
            this.ItemForProductID.Location = new System.Drawing.Point(0, 0);
            this.ItemForProductID.Name = "ItemForProductID";
            this.ItemForProductID.Size = new System.Drawing.Size(375, 24);
            this.ItemForProductID.Text = "Product ID";
            this.ItemForProductID.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(640, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(265, 24);
            this.layoutControlItem1.Text = "AccountID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForProductName
            // 
            this.ItemForProductName.Control = this.ProductNameTextEdit;
            this.ItemForProductName.Location = new System.Drawing.Point(375, 24);
            this.ItemForProductName.Name = "ItemForProductName";
            this.ItemForProductName.Size = new System.Drawing.Size(265, 24);
            this.ItemForProductName.Text = "Product Name";
            this.ItemForProductName.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForCategory
            // 
            this.ItemForCategory.Control = this.CategoryTextEdit;
            this.ItemForCategory.Location = new System.Drawing.Point(640, 24);
            this.ItemForCategory.Name = "ItemForCategory";
            this.ItemForCategory.Size = new System.Drawing.Size(265, 24);
            this.ItemForCategory.Text = "Category";
            this.ItemForCategory.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 803);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePathTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStoreID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPicturePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategory)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit ProductIDTextEdit;
        private System.Windows.Forms.BindingSource productDataSetBindingSource;
        private DevExpress.XtraEditors.TextEdit UnitIDTextEdit;
        private DevExpress.XtraEditors.TextEdit ProductNameTextEdit;
        private DevExpress.XtraEditors.TextEdit CategoryTextEdit;
        private DevExpress.XtraEditors.PictureEdit PicturePictureEdit;
        private DevExpress.XtraEditors.TextEdit PicturePathTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProductID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUnitID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProductName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCategory;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPicturePath;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPicture;
        private DevExpress.XtraEditors.TextEdit StoreIDTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStoreID;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}