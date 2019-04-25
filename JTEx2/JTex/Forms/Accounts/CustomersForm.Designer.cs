namespace JTex.Forms.Accounts
{
    partial class CustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.CustomerIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AccountIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CategoryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ContactPersonTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PhoneNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCustomerID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPhoneNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAccountID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCategory = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForContactPerson = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactPersonTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccountID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContactPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 726);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 48);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // BtnClear
            // 
            this.BtnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.ImageOptions.Image")));
            this.BtnClear.Location = new System.Drawing.Point(890, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(291, 42);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(596, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(288, 42);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.ImageOptions.Image")));
            this.BtnUpdate.Location = new System.Drawing.Point(299, 3);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(291, 42);
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
            this.BtnAdd.Size = new System.Drawing.Size(290, 42);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1184, 726);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1178, 563);
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
            this.dataLayoutControl1.Controls.Add(this.CustomerIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AccountIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CategoryTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AddressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ContactPersonTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PhoneNumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.DataMember = null;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 572);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1178, 151);
            this.dataLayoutControl1.TabIndex = 18;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // CustomerIDTextEdit
            // 
            this.CustomerIDTextEdit.Location = new System.Drawing.Point(89, 12);
            this.CustomerIDTextEdit.Name = "CustomerIDTextEdit";
            this.CustomerIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.CustomerIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CustomerIDTextEdit.Properties.Mask.EditMask = "N0";
            this.CustomerIDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.CustomerIDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.CustomerIDTextEdit.Size = new System.Drawing.Size(497, 20);
            this.CustomerIDTextEdit.StyleController = this.dataLayoutControl1;
            this.CustomerIDTextEdit.TabIndex = 4;
            // 
            // AccountIDTextEdit
            // 
            this.AccountIDTextEdit.Location = new System.Drawing.Point(667, 12);
            this.AccountIDTextEdit.Name = "AccountIDTextEdit";
            this.AccountIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.AccountIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AccountIDTextEdit.Properties.Mask.EditMask = "N0";
            this.AccountIDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.AccountIDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AccountIDTextEdit.Size = new System.Drawing.Size(499, 20);
            this.AccountIDTextEdit.StyleController = this.dataLayoutControl1;
            this.AccountIDTextEdit.TabIndex = 5;
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.Location = new System.Drawing.Point(89, 36);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(497, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 6;
            // 
            // CategoryTextEdit
            // 
            this.CategoryTextEdit.Location = new System.Drawing.Point(667, 36);
            this.CategoryTextEdit.Name = "CategoryTextEdit";
            this.CategoryTextEdit.Size = new System.Drawing.Size(499, 20);
            this.CategoryTextEdit.StyleController = this.dataLayoutControl1;
            this.CategoryTextEdit.TabIndex = 8;
            // 
            // AddressTextEdit
            // 
            this.AddressTextEdit.Location = new System.Drawing.Point(89, 60);
            this.AddressTextEdit.Name = "AddressTextEdit";
            this.AddressTextEdit.Size = new System.Drawing.Size(497, 20);
            this.AddressTextEdit.StyleController = this.dataLayoutControl1;
            this.AddressTextEdit.TabIndex = 9;
            // 
            // ContactPersonTextEdit
            // 
            this.ContactPersonTextEdit.Location = new System.Drawing.Point(667, 60);
            this.ContactPersonTextEdit.Name = "ContactPersonTextEdit";
            this.ContactPersonTextEdit.Size = new System.Drawing.Size(499, 20);
            this.ContactPersonTextEdit.StyleController = this.dataLayoutControl1;
            this.ContactPersonTextEdit.TabIndex = 10;
            // 
            // PhoneNumberTextEdit
            // 
            this.PhoneNumberTextEdit.Location = new System.Drawing.Point(89, 84);
            this.PhoneNumberTextEdit.Name = "PhoneNumberTextEdit";
            this.PhoneNumberTextEdit.Size = new System.Drawing.Size(498, 20);
            this.PhoneNumberTextEdit.StyleController = this.dataLayoutControl1;
            this.PhoneNumberTextEdit.TabIndex = 11;
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.Location = new System.Drawing.Point(668, 84);
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Size = new System.Drawing.Size(498, 20);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 12;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1178, 151);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCustomerID,
            this.ItemForName,
            this.ItemForAddress,
            this.ItemForPhoneNumber,
            this.ItemForAccountID,
            this.ItemForContactPerson,
            this.ItemForEmail,
            this.ItemForCategory});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1158, 131);
            // 
            // ItemForCustomerID
            // 
            this.ItemForCustomerID.Control = this.CustomerIDTextEdit;
            this.ItemForCustomerID.Location = new System.Drawing.Point(0, 0);
            this.ItemForCustomerID.Name = "ItemForCustomerID";
            this.ItemForCustomerID.Size = new System.Drawing.Size(578, 24);
            this.ItemForCustomerID.Text = "Customer ID";
            this.ItemForCustomerID.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 24);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(578, 24);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForAddress
            // 
            this.ItemForAddress.Control = this.AddressTextEdit;
            this.ItemForAddress.Location = new System.Drawing.Point(0, 48);
            this.ItemForAddress.Name = "ItemForAddress";
            this.ItemForAddress.Size = new System.Drawing.Size(578, 24);
            this.ItemForAddress.Text = "Address";
            this.ItemForAddress.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForPhoneNumber
            // 
            this.ItemForPhoneNumber.Control = this.PhoneNumberTextEdit;
            this.ItemForPhoneNumber.Location = new System.Drawing.Point(0, 72);
            this.ItemForPhoneNumber.Name = "ItemForPhoneNumber";
            this.ItemForPhoneNumber.Size = new System.Drawing.Size(579, 59);
            this.ItemForPhoneNumber.Text = "Phone Number";
            this.ItemForPhoneNumber.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForAccountID
            // 
            this.ItemForAccountID.Control = this.AccountIDTextEdit;
            this.ItemForAccountID.Location = new System.Drawing.Point(578, 0);
            this.ItemForAccountID.Name = "ItemForAccountID";
            this.ItemForAccountID.Size = new System.Drawing.Size(580, 24);
            this.ItemForAccountID.Text = "Account ID";
            this.ItemForAccountID.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForCategory
            // 
            this.ItemForCategory.Control = this.CategoryTextEdit;
            this.ItemForCategory.Location = new System.Drawing.Point(578, 24);
            this.ItemForCategory.Name = "ItemForCategory";
            this.ItemForCategory.Size = new System.Drawing.Size(580, 24);
            this.ItemForCategory.Text = "Category";
            this.ItemForCategory.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForContactPerson
            // 
            this.ItemForContactPerson.Control = this.ContactPersonTextEdit;
            this.ItemForContactPerson.Location = new System.Drawing.Point(578, 48);
            this.ItemForContactPerson.Name = "ItemForContactPerson";
            this.ItemForContactPerson.Size = new System.Drawing.Size(580, 24);
            this.ItemForContactPerson.Text = "Contact Person";
            this.ItemForContactPerson.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.Location = new System.Drawing.Point(579, 72);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(579, 59);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextSize = new System.Drawing.Size(74, 13);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 774);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomersForm";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactPersonTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccountID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContactPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit CustomerIDTextEdit;
        private DevExpress.XtraEditors.TextEdit AccountIDTextEdit;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.TextEdit CategoryTextEdit;
        private DevExpress.XtraEditors.TextEdit AddressTextEdit;
        private DevExpress.XtraEditors.TextEdit ContactPersonTextEdit;
        private DevExpress.XtraEditors.TextEdit PhoneNumberTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomerID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhoneNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAccountID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCategory;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContactPerson;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
    }
}