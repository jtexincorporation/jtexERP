namespace JTex.Forms.Accounts
{
    partial class BankForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBankID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIBANNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSwiftCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataLayoutControl2 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.BankIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AccountIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AccountNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IBANNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AccountTitleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SwiftCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForBankID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIBANNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAccountNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAccountID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAccountTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSwiftCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.banksBindingSource = new System.Windows.Forms.BindingSource();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).BeginInit();
            this.dataLayoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IBANNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountTitleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwiftCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBankID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIBANNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccountNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccountID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccountTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSwiftCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 564);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1033, 48);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // BtnClear
            // 
            this.BtnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.ImageOptions.Image")));
            this.BtnClear.Location = new System.Drawing.Point(776, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(254, 42);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(520, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(250, 42);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.ImageOptions.Image")));
            this.BtnUpdate.Location = new System.Drawing.Point(261, 3);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(253, 42);
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
            this.BtnAdd.Size = new System.Drawing.Size(252, 42);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataLayoutControl2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.81609F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.18391F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1033, 564);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1027, 376);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBankID,
            this.colAccountID,
            this.colName,
            this.colAccountNumber,
            this.colIBANNumber,
            this.colAccountTitle,
            this.colSwiftCode});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colBankID
            // 
            this.colBankID.FieldName = "BankID";
            this.colBankID.Name = "colBankID";
            this.colBankID.Visible = true;
            this.colBankID.VisibleIndex = 0;
            // 
            // colAccountID
            // 
            this.colAccountID.FieldName = "AccountID";
            this.colAccountID.Name = "colAccountID";
            this.colAccountID.Visible = true;
            this.colAccountID.VisibleIndex = 1;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            // 
            // colAccountNumber
            // 
            this.colAccountNumber.FieldName = "AccountNumber";
            this.colAccountNumber.Name = "colAccountNumber";
            this.colAccountNumber.Visible = true;
            this.colAccountNumber.VisibleIndex = 3;
            // 
            // colIBANNumber
            // 
            this.colIBANNumber.FieldName = "IBANNumber";
            this.colIBANNumber.Name = "colIBANNumber";
            this.colIBANNumber.Visible = true;
            this.colIBANNumber.VisibleIndex = 4;
            // 
            // colAccountTitle
            // 
            this.colAccountTitle.FieldName = "AccountTitle";
            this.colAccountTitle.Name = "colAccountTitle";
            this.colAccountTitle.Visible = true;
            this.colAccountTitle.VisibleIndex = 5;
            // 
            // colSwiftCode
            // 
            this.colSwiftCode.FieldName = "SwiftCode";
            this.colSwiftCode.Name = "colSwiftCode";
            this.colSwiftCode.Visible = true;
            this.colSwiftCode.VisibleIndex = 6;
            // 
            // dataLayoutControl2
            // 
            this.dataLayoutControl2.Controls.Add(this.BankIDTextEdit);
            this.dataLayoutControl2.Controls.Add(this.AccountIDTextEdit);
            this.dataLayoutControl2.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl2.Controls.Add(this.AccountNumberTextEdit);
            this.dataLayoutControl2.Controls.Add(this.IBANNumberTextEdit);
            this.dataLayoutControl2.Controls.Add(this.AccountTitleTextEdit);
            this.dataLayoutControl2.Controls.Add(this.SwiftCodeTextEdit);
            this.dataLayoutControl2.DataMember = "Banks";
            this.dataLayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl2.Location = new System.Drawing.Point(3, 385);
            this.dataLayoutControl2.Name = "dataLayoutControl2";
            this.dataLayoutControl2.Root = this.layoutControlGroup3;
            this.dataLayoutControl2.Size = new System.Drawing.Size(1027, 176);
            this.dataLayoutControl2.TabIndex = 2;
            this.dataLayoutControl2.Text = "dataLayoutControl2";
            // 
            // BankIDTextEdit
            // 
            this.BankIDTextEdit.Location = new System.Drawing.Point(123, 64);
            this.BankIDTextEdit.Name = "BankIDTextEdit";
            this.BankIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.BankIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BankIDTextEdit.Properties.Mask.EditMask = "N0";
            this.BankIDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.BankIDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.BankIDTextEdit.Size = new System.Drawing.Size(380, 20);
            this.BankIDTextEdit.StyleController = this.dataLayoutControl2;
            this.BankIDTextEdit.TabIndex = 4;
            // 
            // AccountIDTextEdit
            // 
            this.AccountIDTextEdit.Location = new System.Drawing.Point(606, 64);
            this.AccountIDTextEdit.Name = "AccountIDTextEdit";
            this.AccountIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.AccountIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AccountIDTextEdit.Properties.Mask.EditMask = "N0";
            this.AccountIDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.AccountIDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AccountIDTextEdit.Size = new System.Drawing.Size(380, 20);
            this.AccountIDTextEdit.StyleController = this.dataLayoutControl2;
            this.AccountIDTextEdit.TabIndex = 5;
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.Location = new System.Drawing.Point(123, 88);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(380, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl2;
            this.NameTextEdit.TabIndex = 6;
            // 
            // AccountNumberTextEdit
            // 
            this.AccountNumberTextEdit.Location = new System.Drawing.Point(606, 88);
            this.AccountNumberTextEdit.Name = "AccountNumberTextEdit";
            this.AccountNumberTextEdit.Size = new System.Drawing.Size(380, 20);
            this.AccountNumberTextEdit.StyleController = this.dataLayoutControl2;
            this.AccountNumberTextEdit.TabIndex = 7;
            // 
            // IBANNumberTextEdit
            // 
            this.IBANNumberTextEdit.Location = new System.Drawing.Point(123, 112);
            this.IBANNumberTextEdit.Name = "IBANNumberTextEdit";
            this.IBANNumberTextEdit.Size = new System.Drawing.Size(380, 20);
            this.IBANNumberTextEdit.StyleController = this.dataLayoutControl2;
            this.IBANNumberTextEdit.TabIndex = 8;
            // 
            // AccountTitleTextEdit
            // 
            this.AccountTitleTextEdit.Location = new System.Drawing.Point(606, 112);
            this.AccountTitleTextEdit.Name = "AccountTitleTextEdit";
            this.AccountTitleTextEdit.Size = new System.Drawing.Size(380, 20);
            this.AccountTitleTextEdit.StyleController = this.dataLayoutControl2;
            this.AccountTitleTextEdit.TabIndex = 9;
            // 
            // SwiftCodeTextEdit
            // 
            this.SwiftCodeTextEdit.Location = new System.Drawing.Point(123, 136);
            this.SwiftCodeTextEdit.Name = "SwiftCodeTextEdit";
            this.SwiftCodeTextEdit.Size = new System.Drawing.Size(863, 20);
            this.SwiftCodeTextEdit.StyleController = this.dataLayoutControl2;
            this.SwiftCodeTextEdit.TabIndex = 10;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1010, 180);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(990, 160);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup2.CaptionImageOptions.Image")));
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForBankID,
            this.ItemForName,
            this.ItemForIBANNumber,
            this.ItemForAccountNumber,
            this.ItemForAccountID,
            this.ItemForAccountTitle,
            this.ItemForSwiftCode});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(990, 160);
            this.layoutControlGroup2.Text = "Bank";
            // 
            // ItemForBankID
            // 
            this.ItemForBankID.Control = this.BankIDTextEdit;
            this.ItemForBankID.Location = new System.Drawing.Point(0, 0);
            this.ItemForBankID.Name = "ItemForBankID";
            this.ItemForBankID.Size = new System.Drawing.Size(483, 24);
            this.ItemForBankID.Text = "Bank ID";
            this.ItemForBankID.TextSize = new System.Drawing.Size(96, 13);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 24);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(483, 24);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(96, 13);
            // 
            // ItemForIBANNumber
            // 
            this.ItemForIBANNumber.Control = this.IBANNumberTextEdit;
            this.ItemForIBANNumber.Location = new System.Drawing.Point(0, 48);
            this.ItemForIBANNumber.Name = "ItemForIBANNumber";
            this.ItemForIBANNumber.Size = new System.Drawing.Size(483, 24);
            this.ItemForIBANNumber.Text = "IBAN Number";
            this.ItemForIBANNumber.TextSize = new System.Drawing.Size(96, 13);
            // 
            // ItemForAccountNumber
            // 
            this.ItemForAccountNumber.Control = this.AccountNumberTextEdit;
            this.ItemForAccountNumber.Location = new System.Drawing.Point(483, 24);
            this.ItemForAccountNumber.Name = "ItemForAccountNumber";
            this.ItemForAccountNumber.Size = new System.Drawing.Size(483, 24);
            this.ItemForAccountNumber.Text = "Account Number";
            this.ItemForAccountNumber.TextSize = new System.Drawing.Size(96, 13);
            // 
            // ItemForAccountID
            // 
            this.ItemForAccountID.Control = this.AccountIDTextEdit;
            this.ItemForAccountID.Location = new System.Drawing.Point(483, 0);
            this.ItemForAccountID.Name = "ItemForAccountID";
            this.ItemForAccountID.Size = new System.Drawing.Size(483, 24);
            this.ItemForAccountID.Text = "Chart of Account ID";
            this.ItemForAccountID.TextSize = new System.Drawing.Size(96, 13);
            // 
            // ItemForAccountTitle
            // 
            this.ItemForAccountTitle.Control = this.AccountTitleTextEdit;
            this.ItemForAccountTitle.Location = new System.Drawing.Point(483, 48);
            this.ItemForAccountTitle.Name = "ItemForAccountTitle";
            this.ItemForAccountTitle.Size = new System.Drawing.Size(483, 24);
            this.ItemForAccountTitle.Text = "Account Title";
            this.ItemForAccountTitle.TextSize = new System.Drawing.Size(96, 13);
            // 
            // ItemForSwiftCode
            // 
            this.ItemForSwiftCode.Control = this.SwiftCodeTextEdit;
            this.ItemForSwiftCode.Location = new System.Drawing.Point(0, 72);
            this.ItemForSwiftCode.Name = "ItemForSwiftCode";
            this.ItemForSwiftCode.Size = new System.Drawing.Size(966, 24);
            this.ItemForSwiftCode.Text = "Swift Code";
            this.ItemForSwiftCode.TextSize = new System.Drawing.Size(96, 13);
            // 
            // BankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 612);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BankForm";
            this.Text = "BankForm";
            this.Load += new System.EventHandler(this.BankForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).EndInit();
            this.dataLayoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BankIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IBANNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountTitleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwiftCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBankID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIBANNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccountNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccountID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccountTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSwiftCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton BtnClear;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraEditors.TextEdit BankIDTextEdit;
        private DevExpress.XtraEditors.TextEdit AccountIDTextEdit;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.TextEdit AccountNumberTextEdit;
        private DevExpress.XtraEditors.TextEdit IBANNumberTextEdit;
        private DevExpress.XtraEditors.TextEdit AccountTitleTextEdit;
        private DevExpress.XtraEditors.TextEdit SwiftCodeTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBankID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIBANNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAccountNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAccountID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAccountTitle;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSwiftCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBankID;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colIBANNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colSwiftCode;
        private System.Windows.Forms.BindingSource banksBindingSource;
    }
}