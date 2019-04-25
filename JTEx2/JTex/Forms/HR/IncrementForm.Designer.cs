namespace JTex.Forms.HR
{
    partial class IncrementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncrementForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.vwEmployeeForIncrementBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesignation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.incrementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incrementSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.TBID = new DevExpress.XtraEditors.TextEdit();
            this.ItemForinc_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.TBEmployeeID = new DevExpress.XtraEditors.TextEdit();
            this.ItemForEmployeeID = new DevExpress.XtraLayout.LayoutControlItem();
            this.DTPDate = new DevExpress.XtraEditors.DateEdit();
            this.ItemForDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.TBSalary = new DevExpress.XtraEditors.TextEdit();
            this.ItemForPreviousSalaary = new DevExpress.XtraLayout.LayoutControlItem();
            this.TBAmount = new DevExpress.XtraEditors.TextEdit();
            this.ItemForAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.TBDescription = new DevExpress.XtraEditors.MemoExEdit();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.TBIncrementPercentage = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEmployeeForIncrementBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incrementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incrementSalaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForinc_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBEmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployeeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTPDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTPDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBSalary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPreviousSalaary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBIncrementPercentage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 699);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1295, 44);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // BtnClear
            // 
            this.BtnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.ImageOptions.Image")));
            this.BtnClear.Location = new System.Drawing.Point(972, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(320, 38);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(649, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(317, 38);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.ImageOptions.Image")));
            this.BtnUpdate.Location = new System.Drawing.Point(326, 3);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(317, 38);
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
            this.BtnAdd.Size = new System.Drawing.Size(317, 38);
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
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1295, 699);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vwEmployeeForIncrementBindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1289, 483);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vwEmployeeForIncrementBindingSource1
            // 
            this.vwEmployeeForIncrementBindingSource1.DataMember = "vwEmployeeForIncrement";
            this.vwEmployeeForIncrementBindingSource1.Sort = "";
            // 
            // vwEmployeeListFIncrement2
            // 
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeID,
            this.colName,
            this.colDepartment,
            this.colDesignation,
            this.colSalary});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged_1);
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Visible = true;
            this.colEmployeeID.VisibleIndex = 1;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            // 
            // colDepartment
            // 
            this.colDepartment.FieldName = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.Visible = true;
            this.colDepartment.VisibleIndex = 3;
            // 
            // colDesignation
            // 
            this.colDesignation.FieldName = "Designation";
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.Visible = true;
            this.colDesignation.VisibleIndex = 4;
            // 
            // colSalary
            // 
            this.colSalary.FieldName = "Salary";
            this.colSalary.Name = "colSalary";
            this.colSalary.Visible = true;
            this.colSalary.VisibleIndex = 5;
            // 
            // vwEmployeeForIncrementTableAdapter2
            // 
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.TBID);
            this.dataLayoutControl1.Controls.Add(this.TBEmployeeID);
            this.dataLayoutControl1.Controls.Add(this.DTPDate);
            this.dataLayoutControl1.Controls.Add(this.TBSalary);
            this.dataLayoutControl1.Controls.Add(this.TBAmount);
            this.dataLayoutControl1.Controls.Add(this.TBDescription);
            this.dataLayoutControl1.Controls.Add(this.TBIncrementPercentage);
            this.dataLayoutControl1.DataSource = this.incrementSalaryBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 492);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1289, 204);
            this.dataLayoutControl1.TabIndex = 13;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1289, 204);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // incrementDataSet
            // 
            // 
            // incrementDataSetBindingSource
            // 
            // 
            // incrementSalaryBindingSource
            // 
            this.incrementSalaryBindingSource.DataMember = "IncrementSalary";
            this.incrementSalaryBindingSource.DataSource = this.incrementDataSetBindingSource;
            // 
            // incrementSalaryTableAdapter
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForinc_id,
            this.ItemForDate,
            this.ItemForAmount,
            this.ItemForEmployeeID,
            this.ItemForPreviousSalaary,
            this.ItemForDescription,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1269, 184);
            // 
            // TBID
            // 
            this.TBID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.incrementSalaryBindingSource, "inc_id", true));
            this.TBID.Location = new System.Drawing.Point(152, 12);
            this.TBID.Name = "TBID";
            this.TBID.Properties.Appearance.Options.UseTextOptions = true;
            this.TBID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TBID.Properties.Mask.EditMask = "N0";
            this.TBID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TBID.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TBID.Size = new System.Drawing.Size(490, 20);
            this.TBID.StyleController = this.dataLayoutControl1;
            this.TBID.TabIndex = 4;
            // 
            // ItemForinc_id
            // 
            this.ItemForinc_id.Control = this.TBID;
            this.ItemForinc_id.Location = new System.Drawing.Point(0, 0);
            this.ItemForinc_id.Name = "ItemForinc_id";
            this.ItemForinc_id.Size = new System.Drawing.Size(634, 24);
            this.ItemForinc_id.Text = "inc_id";
            this.ItemForinc_id.TextSize = new System.Drawing.Size(136, 13);
            // 
            // TBEmployeeID
            // 
            this.TBEmployeeID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.incrementSalaryBindingSource, "EmployeeID", true));
            this.TBEmployeeID.Location = new System.Drawing.Point(786, 12);
            this.TBEmployeeID.Name = "TBEmployeeID";
            this.TBEmployeeID.Properties.Appearance.Options.UseTextOptions = true;
            this.TBEmployeeID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TBEmployeeID.Properties.Mask.EditMask = "N0";
            this.TBEmployeeID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TBEmployeeID.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TBEmployeeID.Size = new System.Drawing.Size(491, 20);
            this.TBEmployeeID.StyleController = this.dataLayoutControl1;
            this.TBEmployeeID.TabIndex = 5;
            // 
            // ItemForEmployeeID
            // 
            this.ItemForEmployeeID.Control = this.TBEmployeeID;
            this.ItemForEmployeeID.Location = new System.Drawing.Point(634, 0);
            this.ItemForEmployeeID.Name = "ItemForEmployeeID";
            this.ItemForEmployeeID.Size = new System.Drawing.Size(635, 24);
            this.ItemForEmployeeID.Text = "Employee ID";
            this.ItemForEmployeeID.TextSize = new System.Drawing.Size(136, 13);
            // 
            // DTPDate
            // 
            this.DTPDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.incrementSalaryBindingSource, "Date", true));
            this.DTPDate.EditValue = null;
            this.DTPDate.Location = new System.Drawing.Point(152, 36);
            this.DTPDate.Name = "DTPDate";
            this.DTPDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DTPDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DTPDate.Size = new System.Drawing.Size(490, 20);
            this.DTPDate.StyleController = this.dataLayoutControl1;
            this.DTPDate.TabIndex = 6;
            // 
            // ItemForDate
            // 
            this.ItemForDate.Control = this.DTPDate;
            this.ItemForDate.Location = new System.Drawing.Point(0, 24);
            this.ItemForDate.Name = "ItemForDate";
            this.ItemForDate.Size = new System.Drawing.Size(634, 24);
            this.ItemForDate.Text = "Date";
            this.ItemForDate.TextSize = new System.Drawing.Size(136, 13);
            // 
            // TBSalary
            // 
            this.TBSalary.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.incrementSalaryBindingSource, "PreviousSalaary", true));
            this.TBSalary.Location = new System.Drawing.Point(786, 36);
            this.TBSalary.Name = "TBSalary";
            this.TBSalary.Properties.Appearance.Options.UseTextOptions = true;
            this.TBSalary.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TBSalary.Properties.Mask.EditMask = "N0";
            this.TBSalary.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TBSalary.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TBSalary.Size = new System.Drawing.Size(491, 20);
            this.TBSalary.StyleController = this.dataLayoutControl1;
            this.TBSalary.TabIndex = 7;
            // 
            // ItemForPreviousSalaary
            // 
            this.ItemForPreviousSalaary.Control = this.TBSalary;
            this.ItemForPreviousSalaary.Location = new System.Drawing.Point(634, 24);
            this.ItemForPreviousSalaary.Name = "ItemForPreviousSalaary";
            this.ItemForPreviousSalaary.Size = new System.Drawing.Size(635, 24);
            this.ItemForPreviousSalaary.Text = "Previous Salaary";
            this.ItemForPreviousSalaary.TextSize = new System.Drawing.Size(136, 13);
            // 
            // TBAmount
            // 
            this.TBAmount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.incrementSalaryBindingSource, "Amount", true));
            this.TBAmount.Location = new System.Drawing.Point(152, 60);
            this.TBAmount.Name = "TBAmount";
            this.TBAmount.Properties.Appearance.Options.UseTextOptions = true;
            this.TBAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TBAmount.Properties.Mask.EditMask = "N0";
            this.TBAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TBAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TBAmount.Size = new System.Drawing.Size(173, 20);
            this.TBAmount.StyleController = this.dataLayoutControl1;
            this.TBAmount.TabIndex = 8;
            // 
            // ItemForAmount
            // 
            this.ItemForAmount.Control = this.TBAmount;
            this.ItemForAmount.Location = new System.Drawing.Point(0, 48);
            this.ItemForAmount.Name = "ItemForAmount";
            this.ItemForAmount.Size = new System.Drawing.Size(317, 136);
            this.ItemForAmount.Text = "Amount";
            this.ItemForAmount.TextSize = new System.Drawing.Size(136, 13);
            // 
            // TBDescription
            // 
            this.TBDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.incrementSalaryBindingSource, "Description", true));
            this.TBDescription.Location = new System.Drawing.Point(786, 60);
            this.TBDescription.Name = "TBDescription";
            this.TBDescription.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TBDescription.Size = new System.Drawing.Size(491, 20);
            this.TBDescription.StyleController = this.dataLayoutControl1;
            this.TBDescription.TabIndex = 9;
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.Control = this.TBDescription;
            this.ItemForDescription.Location = new System.Drawing.Point(634, 48);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.Size = new System.Drawing.Size(635, 136);
            this.ItemForDescription.Text = "Description";
            this.ItemForDescription.TextSize = new System.Drawing.Size(136, 13);
            // 
            // TBIncrementPercentage
            // 
            this.TBIncrementPercentage.Location = new System.Drawing.Point(469, 60);
            this.TBIncrementPercentage.Name = "TBIncrementPercentage";
            this.TBIncrementPercentage.Size = new System.Drawing.Size(173, 20);
            this.TBIncrementPercentage.StyleController = this.dataLayoutControl1;
            this.TBIncrementPercentage.TabIndex = 10;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TBIncrementPercentage;
            this.layoutControlItem1.Location = new System.Drawing.Point(317, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(317, 136);
            this.layoutControlItem1.Text = "Enter Increment Percentage";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(136, 13);
            // 
            // IncrementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 743);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "IncrementForm";
            this.Text = "IncrementFormn";
            this.Load += new System.EventHandler(this.IncrementForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEmployeeForIncrementBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incrementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incrementSalaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForinc_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBEmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployeeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTPDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTPDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBSalary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPreviousSalaary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBIncrementPercentage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
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
        private System.Windows.Forms.BindingSource vwEmployeeForIncrementBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colDesignation;
        private DevExpress.XtraGrid.Columns.GridColumn colSalary;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource incrementDataSetBindingSource;
        private System.Windows.Forms.BindingSource incrementSalaryBindingSource;
        private DevExpress.XtraEditors.TextEdit TBID;
        private DevExpress.XtraEditors.TextEdit TBEmployeeID;
        private DevExpress.XtraEditors.DateEdit DTPDate;
        private DevExpress.XtraEditors.TextEdit TBSalary;
        private DevExpress.XtraEditors.TextEdit TBAmount;
        private DevExpress.XtraEditors.MemoExEdit TBDescription;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForinc_id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmployeeID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPreviousSalaary;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
        private DevExpress.XtraEditors.TextEdit TBIncrementPercentage;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}