namespace JTex.Forms.HR
{
    partial class LoanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanForm));
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coll_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartitions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colissueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainingAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.l_idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmployeeIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AmountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PartitionsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.issueDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.RemainingAmountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ClearCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForl_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForissueDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForClear = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmployeeID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPartitions = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRemainingAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.l_idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartitionsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemainingAmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForl_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForissueDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployeeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPartitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemainingAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(3, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(313, 40);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.ImageOptions.Image")));
            this.BtnUpdate.Location = new System.Drawing.Point(322, 3);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(313, 40);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(641, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(313, 40);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.ImageOptions.Image")));
            this.BtnClear.Location = new System.Drawing.Point(960, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(313, 40);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 694);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1276, 46);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataLayoutControl1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1276, 694);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.loanBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1270, 479);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataMember = "Loan";
            this.loanBindingSource.Sort = "";
            // 
            // loanDataSet1
            // 
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coll_id,
            this.colEmployeeID,
            this.colAmount,
            this.colPartitions,
            this.colissueDate,
            this.colRemainingAmount,
            this.colClear});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coll_id, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // coll_id
            // 
            this.coll_id.FieldName = "l_id";
            this.coll_id.Name = "coll_id";
            this.coll_id.Visible = true;
            this.coll_id.VisibleIndex = 0;
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Visible = true;
            this.colEmployeeID.VisibleIndex = 1;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 2;
            // 
            // colPartitions
            // 
            this.colPartitions.FieldName = "Partitions";
            this.colPartitions.Name = "colPartitions";
            this.colPartitions.Visible = true;
            this.colPartitions.VisibleIndex = 3;
            // 
            // colissueDate
            // 
            this.colissueDate.FieldName = "issueDate";
            this.colissueDate.Name = "colissueDate";
            this.colissueDate.Visible = true;
            this.colissueDate.VisibleIndex = 4;
            // 
            // colRemainingAmount
            // 
            this.colRemainingAmount.FieldName = "RemainingAmount";
            this.colRemainingAmount.Name = "colRemainingAmount";
            this.colRemainingAmount.Visible = true;
            this.colRemainingAmount.VisibleIndex = 5;
            // 
            // colClear
            // 
            this.colClear.FieldName = "Clear";
            this.colClear.Name = "colClear";
            this.colClear.Visible = true;
            this.colClear.VisibleIndex = 6;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.l_idTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmployeeIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AmountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PartitionsTextEdit);
            this.dataLayoutControl1.Controls.Add(this.issueDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.RemainingAmountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ClearCheckEdit);
            this.dataLayoutControl1.DataSource = this.loanBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 488);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1270, 203);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // l_idTextEdit
            // 
            this.l_idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loanBindingSource, "l_id", true));
            this.l_idTextEdit.Location = new System.Drawing.Point(104, 12);
            this.l_idTextEdit.Name = "l_idTextEdit";
            this.l_idTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.l_idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.l_idTextEdit.Properties.Mask.EditMask = "N0";
            this.l_idTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.l_idTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.l_idTextEdit.Size = new System.Drawing.Size(529, 20);
            this.l_idTextEdit.StyleController = this.dataLayoutControl1;
            this.l_idTextEdit.TabIndex = 4;
            // 
            // EmployeeIDTextEdit
            // 
            this.EmployeeIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loanBindingSource, "EmployeeID", true));
            this.EmployeeIDTextEdit.Location = new System.Drawing.Point(729, 12);
            this.EmployeeIDTextEdit.Name = "EmployeeIDTextEdit";
            this.EmployeeIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.EmployeeIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EmployeeIDTextEdit.Properties.Mask.EditMask = "N0";
            this.EmployeeIDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.EmployeeIDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.EmployeeIDTextEdit.Size = new System.Drawing.Size(529, 20);
            this.EmployeeIDTextEdit.StyleController = this.dataLayoutControl1;
            this.EmployeeIDTextEdit.TabIndex = 5;
            // 
            // AmountTextEdit
            // 
            this.AmountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loanBindingSource, "Amount", true));
            this.AmountTextEdit.Location = new System.Drawing.Point(104, 36);
            this.AmountTextEdit.Name = "AmountTextEdit";
            this.AmountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.AmountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AmountTextEdit.Properties.Mask.EditMask = "d";
            this.AmountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.AmountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AmountTextEdit.Size = new System.Drawing.Size(529, 20);
            this.AmountTextEdit.StyleController = this.dataLayoutControl1;
            this.AmountTextEdit.TabIndex = 6;
            // 
            // PartitionsTextEdit
            // 
            this.PartitionsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loanBindingSource, "Partitions", true));
            this.PartitionsTextEdit.Location = new System.Drawing.Point(729, 36);
            this.PartitionsTextEdit.Name = "PartitionsTextEdit";
            this.PartitionsTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.PartitionsTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PartitionsTextEdit.Properties.Mask.EditMask = "N0";
            this.PartitionsTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.PartitionsTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.PartitionsTextEdit.Size = new System.Drawing.Size(529, 20);
            this.PartitionsTextEdit.StyleController = this.dataLayoutControl1;
            this.PartitionsTextEdit.TabIndex = 7;
            // 
            // issueDateDateEdit
            // 
            this.issueDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loanBindingSource, "issueDate", true));
            this.issueDateDateEdit.EditValue = null;
            this.issueDateDateEdit.Location = new System.Drawing.Point(104, 60);
            this.issueDateDateEdit.Name = "issueDateDateEdit";
            this.issueDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.issueDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.issueDateDateEdit.Size = new System.Drawing.Size(529, 20);
            this.issueDateDateEdit.StyleController = this.dataLayoutControl1;
            this.issueDateDateEdit.TabIndex = 8;
            // 
            // RemainingAmountTextEdit
            // 
            this.RemainingAmountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loanBindingSource, "RemainingAmount", true));
            this.RemainingAmountTextEdit.Location = new System.Drawing.Point(729, 60);
            this.RemainingAmountTextEdit.Name = "RemainingAmountTextEdit";
            this.RemainingAmountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.RemainingAmountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RemainingAmountTextEdit.Properties.Mask.EditMask = "N0";
            this.RemainingAmountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RemainingAmountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.RemainingAmountTextEdit.Size = new System.Drawing.Size(529, 20);
            this.RemainingAmountTextEdit.StyleController = this.dataLayoutControl1;
            this.RemainingAmountTextEdit.TabIndex = 9;
            // 
            // ClearCheckEdit
            // 
            this.ClearCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loanBindingSource, "Clear", true));
            this.ClearCheckEdit.Location = new System.Drawing.Point(12, 84);
            this.ClearCheckEdit.Name = "ClearCheckEdit";
            this.ClearCheckEdit.Properties.Caption = "Clear ";
            this.ClearCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.ClearCheckEdit.Size = new System.Drawing.Size(1246, 19);
            this.ClearCheckEdit.StyleController = this.dataLayoutControl1;
            this.ClearCheckEdit.TabIndex = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1270, 203);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForl_id,
            this.ItemForAmount,
            this.ItemForissueDate,
            this.ItemForClear,
            this.ItemForEmployeeID,
            this.ItemForPartitions,
            this.ItemForRemainingAmount});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1250, 183);
            // 
            // ItemForl_id
            // 
            this.ItemForl_id.Control = this.l_idTextEdit;
            this.ItemForl_id.Location = new System.Drawing.Point(0, 0);
            this.ItemForl_id.Name = "ItemForl_id";
            this.ItemForl_id.Size = new System.Drawing.Size(625, 24);
            this.ItemForl_id.Text = "l_id";
            this.ItemForl_id.TextSize = new System.Drawing.Size(89, 13);
            // 
            // ItemForAmount
            // 
            this.ItemForAmount.Control = this.AmountTextEdit;
            this.ItemForAmount.Location = new System.Drawing.Point(0, 24);
            this.ItemForAmount.Name = "ItemForAmount";
            this.ItemForAmount.Size = new System.Drawing.Size(625, 24);
            this.ItemForAmount.Text = "Amount";
            this.ItemForAmount.TextSize = new System.Drawing.Size(89, 13);
            // 
            // ItemForissueDate
            // 
            this.ItemForissueDate.Control = this.issueDateDateEdit;
            this.ItemForissueDate.Location = new System.Drawing.Point(0, 48);
            this.ItemForissueDate.Name = "ItemForissueDate";
            this.ItemForissueDate.Size = new System.Drawing.Size(625, 24);
            this.ItemForissueDate.Text = "Issue Date";
            this.ItemForissueDate.TextSize = new System.Drawing.Size(89, 13);
            // 
            // ItemForClear
            // 
            this.ItemForClear.Control = this.ClearCheckEdit;
            this.ItemForClear.Location = new System.Drawing.Point(0, 72);
            this.ItemForClear.Name = "ItemForClear";
            this.ItemForClear.Size = new System.Drawing.Size(1250, 111);
            this.ItemForClear.Text = "Clear";
            this.ItemForClear.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForClear.TextVisible = false;
            // 
            // ItemForEmployeeID
            // 
            this.ItemForEmployeeID.Control = this.EmployeeIDTextEdit;
            this.ItemForEmployeeID.Location = new System.Drawing.Point(625, 0);
            this.ItemForEmployeeID.Name = "ItemForEmployeeID";
            this.ItemForEmployeeID.Size = new System.Drawing.Size(625, 24);
            this.ItemForEmployeeID.Text = "Employee ID";
            this.ItemForEmployeeID.TextSize = new System.Drawing.Size(89, 13);
            // 
            // ItemForPartitions
            // 
            this.ItemForPartitions.Control = this.PartitionsTextEdit;
            this.ItemForPartitions.Location = new System.Drawing.Point(625, 24);
            this.ItemForPartitions.Name = "ItemForPartitions";
            this.ItemForPartitions.Size = new System.Drawing.Size(625, 24);
            this.ItemForPartitions.Text = "Partitions";
            this.ItemForPartitions.TextSize = new System.Drawing.Size(89, 13);
            // 
            // ItemForRemainingAmount
            // 
            this.ItemForRemainingAmount.Control = this.RemainingAmountTextEdit;
            this.ItemForRemainingAmount.Location = new System.Drawing.Point(625, 48);
            this.ItemForRemainingAmount.Name = "ItemForRemainingAmount";
            this.ItemForRemainingAmount.Size = new System.Drawing.Size(625, 24);
            this.ItemForRemainingAmount.Text = "Remaining Amount";
            this.ItemForRemainingAmount.TextSize = new System.Drawing.Size(89, 13);
            // 
            // loanTableAdapter1
            // 
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 740);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LoanForm";
            this.Text = "LoanForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.l_idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartitionsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemainingAmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForl_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForissueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployeeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPartitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemainingAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coll_id;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPartitions;
        private DevExpress.XtraGrid.Columns.GridColumn colissueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainingAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colClear;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit l_idTextEdit;
        private DevExpress.XtraEditors.TextEdit EmployeeIDTextEdit;
        private DevExpress.XtraEditors.TextEdit AmountTextEdit;
        private DevExpress.XtraEditors.TextEdit PartitionsTextEdit;
        private DevExpress.XtraEditors.DateEdit issueDateDateEdit;
        private DevExpress.XtraEditors.TextEdit RemainingAmountTextEdit;
        private DevExpress.XtraEditors.CheckEdit ClearCheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForl_id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForissueDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForClear;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmployeeID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPartitions;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemainingAmount;
    }
}