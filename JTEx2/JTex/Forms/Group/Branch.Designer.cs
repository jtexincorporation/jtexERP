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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Branch));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.GroupIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TBNumber = new DevExpress.XtraEditors.TextEdit();
            this.TBName = new DevExpress.XtraEditors.TextEdit();
            this.TBAddress = new DevExpress.XtraEditors.TextEdit();
            this.TBPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.TBFaxNumber = new DevExpress.XtraEditors.TextEdit();
            this.TBCompanyID = new DevExpress.XtraEditors.LookUpEdit();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForBranchID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCompanyID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPhoneNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFaxNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBFaxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBCompanyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranchID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFaxNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.BtnClear, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnDelete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnUpdate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnAdd, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 700);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1258, 49);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // BtnClear
            // 
            this.BtnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.ImageOptions.Image")));
            this.BtnClear.Location = new System.Drawing.Point(945, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(310, 43);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(631, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(308, 43);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.ImageOptions.Image")));
            this.BtnUpdate.Location = new System.Drawing.Point(317, 3);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(308, 43);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(3, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(308, 43);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1252, 484);
            this.gridControl1.TabIndex = 4;
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
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataLayoutControl1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1258, 700);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.GroupIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TBNumber);
            this.dataLayoutControl1.Controls.Add(this.TBName);
            this.dataLayoutControl1.Controls.Add(this.TBAddress);
            this.dataLayoutControl1.Controls.Add(this.TBPhoneNumber);
            this.dataLayoutControl1.Controls.Add(this.TBFaxNumber);
            this.dataLayoutControl1.Controls.Add(this.TBCompanyID);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 493);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(668, 254, 450, 400);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1252, 204);
            this.dataLayoutControl1.TabIndex = 5;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // GroupIDTextEdit
            // 
            this.GroupIDTextEdit.Location = new System.Drawing.Point(109, 64);
            this.GroupIDTextEdit.Name = "GroupIDTextEdit";
            this.GroupIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.GroupIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.GroupIDTextEdit.Properties.Mask.EditMask = "N0";
            this.GroupIDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.GroupIDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.GroupIDTextEdit.Size = new System.Drawing.Size(505, 20);
            this.GroupIDTextEdit.StyleController = this.dataLayoutControl1;
            this.GroupIDTextEdit.TabIndex = 4;
            // 
            // TBNumber
            // 
            this.TBNumber.Location = new System.Drawing.Point(703, 88);
            this.TBNumber.Name = "TBNumber";
            this.TBNumber.Properties.Appearance.Options.UseTextOptions = true;
            this.TBNumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TBNumber.Properties.Mask.EditMask = "N0";
            this.TBNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TBNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TBNumber.Size = new System.Drawing.Size(525, 20);
            this.TBNumber.StyleController = this.dataLayoutControl1;
            this.TBNumber.TabIndex = 6;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(109, 88);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(505, 20);
            this.TBName.StyleController = this.dataLayoutControl1;
            this.TBName.TabIndex = 7;
            // 
            // TBAddress
            // 
            this.TBAddress.Location = new System.Drawing.Point(109, 112);
            this.TBAddress.Name = "TBAddress";
            this.TBAddress.Size = new System.Drawing.Size(505, 20);
            this.TBAddress.StyleController = this.dataLayoutControl1;
            this.TBAddress.TabIndex = 8;
            // 
            // TBPhoneNumber
            // 
            this.TBPhoneNumber.Location = new System.Drawing.Point(703, 112);
            this.TBPhoneNumber.Name = "TBPhoneNumber";
            this.TBPhoneNumber.Size = new System.Drawing.Size(525, 20);
            this.TBPhoneNumber.StyleController = this.dataLayoutControl1;
            this.TBPhoneNumber.TabIndex = 9;
            // 
            // TBFaxNumber
            // 
            this.TBFaxNumber.Location = new System.Drawing.Point(109, 136);
            this.TBFaxNumber.Name = "TBFaxNumber";
            this.TBFaxNumber.Size = new System.Drawing.Size(1119, 20);
            this.TBFaxNumber.StyleController = this.dataLayoutControl1;
            this.TBFaxNumber.TabIndex = 10;
            // 
            // TBCompanyID
            // 
            this.TBCompanyID.Location = new System.Drawing.Point(703, 64);
            this.TBCompanyID.Name = "TBCompanyID";
            this.TBCompanyID.Properties.Appearance.Options.UseTextOptions = true;
            this.TBCompanyID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TBCompanyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TBCompanyID.Properties.DataSource = this.companyBindingSource;
            this.TBCompanyID.Properties.DisplayMember = "CompanyID";
            this.TBCompanyID.Properties.NullText = "";
            this.TBCompanyID.Properties.ValueMember = "CompanyID";
            this.TBCompanyID.Size = new System.Drawing.Size(525, 20);
            this.TBCompanyID.StyleController = this.dataLayoutControl1;
            this.TBCompanyID.TabIndex = 5;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.Sort = "";
            // 
            // companyDataSet1
            // 
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1252, 204);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(1232, 184);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup3.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup3.CaptionImage = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup3.CaptionImage")));
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForBranchID,
            this.ItemForCompanyID,
            this.ItemForName,
            this.ItemForNumber,
            this.ItemForAddress,
            this.ItemForPhoneNumber,
            this.ItemForFaxNumber});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1232, 184);
            this.layoutControlGroup3.Text = "Branch Infromation E.g Main Branch";
            // 
            // ItemForBranchID
            // 
            this.ItemForBranchID.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ItemForBranchID.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForBranchID.Control = this.GroupIDTextEdit;
            this.ItemForBranchID.Location = new System.Drawing.Point(0, 0);
            this.ItemForBranchID.Name = "ItemForBranchID";
            this.ItemForBranchID.Size = new System.Drawing.Size(594, 24);
            this.ItemForBranchID.Text = "Branch ID";
            this.ItemForBranchID.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForCompanyID
            // 
            this.ItemForCompanyID.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ItemForCompanyID.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForCompanyID.Control = this.TBCompanyID;
            this.ItemForCompanyID.Location = new System.Drawing.Point(594, 0);
            this.ItemForCompanyID.Name = "ItemForCompanyID";
            this.ItemForCompanyID.OptionsTableLayoutItem.ColumnIndex = 1;
            this.ItemForCompanyID.Size = new System.Drawing.Size(614, 24);
            this.ItemForCompanyID.Text = "Company ID";
            this.ItemForCompanyID.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForName
            // 
            this.ItemForName.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ItemForName.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForName.Control = this.TBName;
            this.ItemForName.Location = new System.Drawing.Point(0, 24);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.OptionsTableLayoutItem.RowIndex = 1;
            this.ItemForName.Size = new System.Drawing.Size(594, 24);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForNumber
            // 
            this.ItemForNumber.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ItemForNumber.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForNumber.Control = this.TBNumber;
            this.ItemForNumber.Location = new System.Drawing.Point(594, 24);
            this.ItemForNumber.Name = "ItemForNumber";
            this.ItemForNumber.OptionsTableLayoutItem.ColumnIndex = 1;
            this.ItemForNumber.OptionsTableLayoutItem.RowIndex = 1;
            this.ItemForNumber.Size = new System.Drawing.Size(614, 24);
            this.ItemForNumber.Text = "Number";
            this.ItemForNumber.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForAddress
            // 
            this.ItemForAddress.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ItemForAddress.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForAddress.Control = this.TBAddress;
            this.ItemForAddress.Location = new System.Drawing.Point(0, 48);
            this.ItemForAddress.Name = "ItemForAddress";
            this.ItemForAddress.OptionsTableLayoutItem.RowIndex = 2;
            this.ItemForAddress.Size = new System.Drawing.Size(594, 24);
            this.ItemForAddress.Text = "Address";
            this.ItemForAddress.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForPhoneNumber
            // 
            this.ItemForPhoneNumber.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ItemForPhoneNumber.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForPhoneNumber.Control = this.TBPhoneNumber;
            this.ItemForPhoneNumber.Location = new System.Drawing.Point(594, 48);
            this.ItemForPhoneNumber.Name = "ItemForPhoneNumber";
            this.ItemForPhoneNumber.OptionsTableLayoutItem.ColumnIndex = 1;
            this.ItemForPhoneNumber.OptionsTableLayoutItem.RowIndex = 2;
            this.ItemForPhoneNumber.Size = new System.Drawing.Size(614, 24);
            this.ItemForPhoneNumber.Text = "Phone Number";
            this.ItemForPhoneNumber.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForFaxNumber
            // 
            this.ItemForFaxNumber.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ItemForFaxNumber.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForFaxNumber.Control = this.TBFaxNumber;
            this.ItemForFaxNumber.Location = new System.Drawing.Point(0, 72);
            this.ItemForFaxNumber.Name = "ItemForFaxNumber";
            this.ItemForFaxNumber.OptionsTableLayoutItem.RowIndex = 3;
            this.ItemForFaxNumber.Size = new System.Drawing.Size(1208, 48);
            this.ItemForFaxNumber.Text = "Fax Number";
            this.ItemForFaxNumber.TextSize = new System.Drawing.Size(82, 13);
            // 
            // companyTableAdapter1
            // 
            // 
            // Branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 749);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Branch";
            this.Text = "Branch";
            this.Load += new System.EventHandler(this.Branch_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBFaxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBCompanyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranchID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFaxNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton BtnClear;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit GroupIDTextEdit;
        private DevExpress.XtraEditors.TextEdit TBNumber;
        private DevExpress.XtraEditors.TextEdit TBName;
        private DevExpress.XtraEditors.TextEdit TBAddress;
        private DevExpress.XtraEditors.TextEdit TBPhoneNumber;
        private DevExpress.XtraEditors.TextEdit TBFaxNumber;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBranchID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhoneNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFaxNumber;
        private DevExpress.XtraEditors.LookUpEdit TBCompanyID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompanyID;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private System.Windows.Forms.BindingSource companyBindingSource;

    }
}