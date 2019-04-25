namespace JTex.Forms.HR
{
    partial class BonusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BonusForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.TBID = new DevExpress.XtraEditors.TextEdit();
            this.bonusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeIDLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.SalaryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MonthDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.BonusAmountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DescriptionMemoExEdit = new DevExpress.XtraEditors.MemoExEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForBon_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmployeeID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSalary = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMonth = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBonusAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeIDLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BonusAmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionMemoExEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBon_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployeeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBonusAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 770);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1464, 48);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // BtnClear
            // 
            this.BtnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.ImageOptions.Image")));
            this.BtnClear.Location = new System.Drawing.Point(1101, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(360, 42);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(735, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(360, 42);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.ImageOptions.Image")));
            this.BtnUpdate.Location = new System.Drawing.Point(369, 3);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(360, 42);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click_1);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(3, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(360, 42);
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
            this.gridControl1.Size = new System.Drawing.Size(1458, 533);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
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
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1464, 770);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.TBID);
            this.dataLayoutControl1.Controls.Add(this.EmployeeIDLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.SalaryTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MonthDateEdit);
            this.dataLayoutControl1.Controls.Add(this.BonusAmountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DescriptionMemoExEdit);
            this.dataLayoutControl1.DataSource = this.bonusBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 542);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1458, 225);
            this.dataLayoutControl1.TabIndex = 12;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // TBID
            // 
            this.TBID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bonusBindingSource, "Bon_ID", true));
            this.TBID.Location = new System.Drawing.Point(109, 64);
            this.TBID.Name = "TBID";
            this.TBID.Properties.Appearance.Options.UseTextOptions = true;
            this.TBID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TBID.Properties.Mask.EditMask = "N0";
            this.TBID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TBID.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TBID.Size = new System.Drawing.Size(618, 20);
            this.TBID.StyleController = this.dataLayoutControl1;
            this.TBID.TabIndex = 4;
            // 
            // bonusBindingSource
            // 
            this.bonusBindingSource.DataMember = "Bonus";
            // 
            // bonusDataSet
            // 
            // 
            // EmployeeIDLookUpEdit
            // 
            this.EmployeeIDLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bonusBindingSource, "EmployeeID", true));
            this.EmployeeIDLookUpEdit.Location = new System.Drawing.Point(816, 64);
            this.EmployeeIDLookUpEdit.Name = "EmployeeIDLookUpEdit";
            this.EmployeeIDLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.EmployeeIDLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EmployeeIDLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmployeeIDLookUpEdit.Properties.NullText = "";
            this.EmployeeIDLookUpEdit.Size = new System.Drawing.Size(618, 20);
            this.EmployeeIDLookUpEdit.StyleController = this.dataLayoutControl1;
            this.EmployeeIDLookUpEdit.TabIndex = 5;
            // 
            // SalaryTextEdit
            // 
            this.SalaryTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bonusBindingSource, "Salary", true));
            this.SalaryTextEdit.Location = new System.Drawing.Point(109, 88);
            this.SalaryTextEdit.Name = "SalaryTextEdit";
            this.SalaryTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.SalaryTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SalaryTextEdit.Properties.Mask.EditMask = "N0";
            this.SalaryTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.SalaryTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.SalaryTextEdit.Size = new System.Drawing.Size(618, 20);
            this.SalaryTextEdit.StyleController = this.dataLayoutControl1;
            this.SalaryTextEdit.TabIndex = 6;
            // 
            // MonthDateEdit
            // 
            this.MonthDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bonusBindingSource, "Month", true));
            this.MonthDateEdit.EditValue = null;
            this.MonthDateEdit.Location = new System.Drawing.Point(816, 88);
            this.MonthDateEdit.Name = "MonthDateEdit";
            this.MonthDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MonthDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MonthDateEdit.Size = new System.Drawing.Size(618, 20);
            this.MonthDateEdit.StyleController = this.dataLayoutControl1;
            this.MonthDateEdit.TabIndex = 7;
            // 
            // BonusAmountTextEdit
            // 
            this.BonusAmountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bonusBindingSource, "BonusAmount", true));
            this.BonusAmountTextEdit.Location = new System.Drawing.Point(109, 112);
            this.BonusAmountTextEdit.Name = "BonusAmountTextEdit";
            this.BonusAmountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.BonusAmountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BonusAmountTextEdit.Properties.Mask.EditMask = "N0";
            this.BonusAmountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.BonusAmountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.BonusAmountTextEdit.Size = new System.Drawing.Size(618, 20);
            this.BonusAmountTextEdit.StyleController = this.dataLayoutControl1;
            this.BonusAmountTextEdit.TabIndex = 8;
            // 
            // DescriptionMemoExEdit
            // 
            this.DescriptionMemoExEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bonusBindingSource, "Description", true));
            this.DescriptionMemoExEdit.Location = new System.Drawing.Point(816, 112);
            this.DescriptionMemoExEdit.Name = "DescriptionMemoExEdit";
            this.DescriptionMemoExEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DescriptionMemoExEdit.Size = new System.Drawing.Size(618, 20);
            this.DescriptionMemoExEdit.StyleController = this.dataLayoutControl1;
            this.DescriptionMemoExEdit.TabIndex = 9;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1458, 225);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(1438, 205);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup3.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup3.CaptionImage = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup3.CaptionImage")));
            this.layoutControlGroup3.CustomizationFormText = "Bonus Information E.g 5000 Bonus For Employee ID=9";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForBon_ID,
            this.ItemForEmployeeID,
            this.ItemForSalary,
            this.ItemForMonth,
            this.ItemForBonusAmount,
            this.ItemForDescription});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1438, 205);
            this.layoutControlGroup3.Text = "Bonus Information E.g 5000 Bonus For Employee ID=9";
            // 
            // ItemForBon_ID
            // 
            this.ItemForBon_ID.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ItemForBon_ID.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForBon_ID.Control = this.TBID;
            this.ItemForBon_ID.Location = new System.Drawing.Point(0, 0);
            this.ItemForBon_ID.Name = "ItemForBon_ID";
            this.ItemForBon_ID.Size = new System.Drawing.Size(707, 24);
            this.ItemForBon_ID.Text = "Bonus ID";
            this.ItemForBon_ID.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForEmployeeID
            // 
            this.ItemForEmployeeID.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ItemForEmployeeID.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForEmployeeID.Control = this.EmployeeIDLookUpEdit;
            this.ItemForEmployeeID.Location = new System.Drawing.Point(707, 0);
            this.ItemForEmployeeID.Name = "ItemForEmployeeID";
            this.ItemForEmployeeID.OptionsTableLayoutItem.ColumnIndex = 1;
            this.ItemForEmployeeID.Size = new System.Drawing.Size(707, 24);
            this.ItemForEmployeeID.Text = "Employee ID";
            this.ItemForEmployeeID.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForSalary
            // 
            this.ItemForSalary.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ItemForSalary.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForSalary.Control = this.SalaryTextEdit;
            this.ItemForSalary.Location = new System.Drawing.Point(0, 24);
            this.ItemForSalary.Name = "ItemForSalary";
            this.ItemForSalary.OptionsTableLayoutItem.RowIndex = 1;
            this.ItemForSalary.Size = new System.Drawing.Size(707, 24);
            this.ItemForSalary.Text = "Salary";
            this.ItemForSalary.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForMonth
            // 
            this.ItemForMonth.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ItemForMonth.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForMonth.Control = this.MonthDateEdit;
            this.ItemForMonth.Location = new System.Drawing.Point(707, 24);
            this.ItemForMonth.Name = "ItemForMonth";
            this.ItemForMonth.OptionsTableLayoutItem.ColumnIndex = 1;
            this.ItemForMonth.OptionsTableLayoutItem.RowIndex = 1;
            this.ItemForMonth.Size = new System.Drawing.Size(707, 24);
            this.ItemForMonth.Text = "Month";
            this.ItemForMonth.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForBonusAmount
            // 
            this.ItemForBonusAmount.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ItemForBonusAmount.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForBonusAmount.Control = this.BonusAmountTextEdit;
            this.ItemForBonusAmount.Location = new System.Drawing.Point(0, 48);
            this.ItemForBonusAmount.Name = "ItemForBonusAmount";
            this.ItemForBonusAmount.OptionsTableLayoutItem.RowIndex = 2;
            this.ItemForBonusAmount.Size = new System.Drawing.Size(707, 93);
            this.ItemForBonusAmount.Text = "Bonus Amount";
            this.ItemForBonusAmount.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ItemForDescription.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForDescription.Control = this.DescriptionMemoExEdit;
            this.ItemForDescription.Location = new System.Drawing.Point(707, 48);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.OptionsTableLayoutItem.ColumnIndex = 1;
            this.ItemForDescription.OptionsTableLayoutItem.RowIndex = 2;
            this.ItemForDescription.Size = new System.Drawing.Size(707, 93);
            this.ItemForDescription.Text = "Description";
            this.ItemForDescription.TextSize = new System.Drawing.Size(82, 13);
            // 
            // bonusTableAdapter
            // 
            // 
            // BonusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 818);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BonusForm";
            this.Text = "BonusForm";
            this.Load += new System.EventHandler(this.BonusForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TBID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeIDLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BonusAmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionMemoExEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBon_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployeeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBonusAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
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
        private System.Windows.Forms.BindingSource bonusBindingSource;
        private DevExpress.XtraEditors.TextEdit TBID;
        private DevExpress.XtraEditors.LookUpEdit EmployeeIDLookUpEdit;
        private DevExpress.XtraEditors.TextEdit SalaryTextEdit;
        private DevExpress.XtraEditors.DateEdit MonthDateEdit;
        private DevExpress.XtraEditors.TextEdit BonusAmountTextEdit;
        private DevExpress.XtraEditors.MemoExEdit DescriptionMemoExEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBon_ID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmployeeID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSalary;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMonth;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBonusAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
    }
}