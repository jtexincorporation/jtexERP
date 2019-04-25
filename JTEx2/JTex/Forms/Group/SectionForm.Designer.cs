namespace JTex.Forms
{
    partial class SectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectionForm));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSectionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbbrevation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.SectionIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DepartmentIDLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AbbrevationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForDepartmentID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAbbrevation = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSectionID = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SectionIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentIDLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbbrevationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDepartmentID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAbbrevation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSectionID)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 20;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1220, 103);
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            this.bbiPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "Add";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Operations";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Print and Export";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataLayoutControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1220, 714);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sectionsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1214, 493);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sectionsBindingSource
            // 
            this.sectionsBindingSource.DataSource = typeof(Modelx.Section);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSectionID,
            this.colDepartmentID,
            this.colNumber,
            this.colName,
            this.colAbbrevation});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSectionID, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged_1);
            // 
            // colSectionID
            // 
            this.colSectionID.FieldName = "SectionID";
            this.colSectionID.Name = "colSectionID";
            this.colSectionID.Visible = true;
            this.colSectionID.VisibleIndex = 0;
            // 
            // colDepartmentID
            // 
            this.colDepartmentID.FieldName = "DepartmentID";
            this.colDepartmentID.Name = "colDepartmentID";
            this.colDepartmentID.Visible = true;
            this.colDepartmentID.VisibleIndex = 1;
            // 
            // colNumber
            // 
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 2;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 3;
            // 
            // colAbbrevation
            // 
            this.colAbbrevation.FieldName = "Abbrevation";
            this.colAbbrevation.Name = "colAbbrevation";
            this.colAbbrevation.Visible = true;
            this.colAbbrevation.VisibleIndex = 4;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.SectionIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DepartmentIDLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.NumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AbbrevationTextEdit);
            this.dataLayoutControl1.DataSource = this.sectionsBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 502);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1214, 209);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // SectionIDTextEdit
            // 
            this.SectionIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sectionsBindingSource, "SectionID", true));
            this.SectionIDTextEdit.Location = new System.Drawing.Point(98, 64);
            this.SectionIDTextEdit.MenuManager = this.ribbonControl;
            this.SectionIDTextEdit.Name = "SectionIDTextEdit";
            this.SectionIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.SectionIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SectionIDTextEdit.Properties.Mask.EditMask = "N0";
            this.SectionIDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.SectionIDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.SectionIDTextEdit.Size = new System.Drawing.Size(333, 20);
            this.SectionIDTextEdit.StyleController = this.dataLayoutControl1;
            this.SectionIDTextEdit.TabIndex = 4;
            // 
            // DepartmentIDLookUpEdit
            // 
            this.DepartmentIDLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sectionsBindingSource, "DepartmentID", true));
            this.DepartmentIDLookUpEdit.Location = new System.Drawing.Point(509, 64);
            this.DepartmentIDLookUpEdit.MenuManager = this.ribbonControl;
            this.DepartmentIDLookUpEdit.Name = "DepartmentIDLookUpEdit";
            this.DepartmentIDLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.DepartmentIDLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DepartmentIDLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DepartmentIDLookUpEdit.Properties.DataSource = this.departmentsBindingSource;
            this.DepartmentIDLookUpEdit.Properties.DisplayMember = "DepartmentID";
            this.DepartmentIDLookUpEdit.Properties.NullText = "";
            this.DepartmentIDLookUpEdit.Properties.ValueMember = "DepartmentID";
            this.DepartmentIDLookUpEdit.Size = new System.Drawing.Size(302, 20);
            this.DepartmentIDLookUpEdit.StyleController = this.dataLayoutControl1;
            this.DepartmentIDLookUpEdit.TabIndex = 5;
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataSource = typeof(Modelx.Department);
            // 
            // NumberTextEdit
            // 
            this.NumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sectionsBindingSource, "Number", true));
            this.NumberTextEdit.Location = new System.Drawing.Point(889, 64);
            this.NumberTextEdit.MenuManager = this.ribbonControl;
            this.NumberTextEdit.Name = "NumberTextEdit";
            this.NumberTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.NumberTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.NumberTextEdit.Properties.Mask.EditMask = "d";
            this.NumberTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.NumberTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.NumberTextEdit.Size = new System.Drawing.Size(301, 20);
            this.NumberTextEdit.StyleController = this.dataLayoutControl1;
            this.NumberTextEdit.TabIndex = 6;
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sectionsBindingSource, "Name", true));
            this.NameTextEdit.Location = new System.Drawing.Point(98, 88);
            this.NameTextEdit.MenuManager = this.ribbonControl;
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.NameTextEdit.Size = new System.Drawing.Size(507, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 7;
            // 
            // AbbrevationTextEdit
            // 
            this.AbbrevationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sectionsBindingSource, "Abbrevation", true));
            this.AbbrevationTextEdit.Location = new System.Drawing.Point(683, 88);
            this.AbbrevationTextEdit.MenuManager = this.ribbonControl;
            this.AbbrevationTextEdit.Name = "AbbrevationTextEdit";
            this.AbbrevationTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.AbbrevationTextEdit.Size = new System.Drawing.Size(507, 20);
            this.AbbrevationTextEdit.StyleController = this.dataLayoutControl1;
            this.AbbrevationTextEdit.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1214, 209);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(1194, 189);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup3.CaptionImageOptions.Image")));
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForDepartmentID,
            this.ItemForAbbrevation,
            this.ItemForName,
            this.ItemForNumber,
            this.ItemForSectionID});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1194, 189);
            this.layoutControlGroup3.Text = "Section data";
            // 
            // ItemForDepartmentID
            // 
            this.ItemForDepartmentID.Control = this.DepartmentIDLookUpEdit;
            this.ItemForDepartmentID.Location = new System.Drawing.Point(411, 0);
            this.ItemForDepartmentID.Name = "ItemForDepartmentID";
            this.ItemForDepartmentID.Size = new System.Drawing.Size(380, 24);
            this.ItemForDepartmentID.Text = "Department ID";
            this.ItemForDepartmentID.TextSize = new System.Drawing.Size(71, 13);
            // 
            // ItemForAbbrevation
            // 
            this.ItemForAbbrevation.Control = this.AbbrevationTextEdit;
            this.ItemForAbbrevation.Location = new System.Drawing.Point(585, 24);
            this.ItemForAbbrevation.Name = "ItemForAbbrevation";
            this.ItemForAbbrevation.Size = new System.Drawing.Size(585, 101);
            this.ItemForAbbrevation.Text = "Abbrevation";
            this.ItemForAbbrevation.TextSize = new System.Drawing.Size(71, 13);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 24);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(585, 101);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(71, 13);
            // 
            // ItemForNumber
            // 
            this.ItemForNumber.Control = this.NumberTextEdit;
            this.ItemForNumber.Location = new System.Drawing.Point(791, 0);
            this.ItemForNumber.Name = "ItemForNumber";
            this.ItemForNumber.Size = new System.Drawing.Size(379, 24);
            this.ItemForNumber.Text = "Number";
            this.ItemForNumber.TextSize = new System.Drawing.Size(71, 13);
            // 
            // ItemForSectionID
            // 
            this.ItemForSectionID.Control = this.SectionIDTextEdit;
            this.ItemForSectionID.Location = new System.Drawing.Point(0, 0);
            this.ItemForSectionID.Name = "ItemForSectionID";
            this.ItemForSectionID.Size = new System.Drawing.Size(411, 24);
            this.ItemForSectionID.Text = "Section ID";
            this.ItemForSectionID.TextSize = new System.Drawing.Size(71, 13);
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 817);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "SectionForm";
            this.Text = "Section Form";
            this.Load += new System.EventHandler(this.SectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SectionIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentIDLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbbrevationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDepartmentID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAbbrevation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSectionID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSectionID;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentID;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAbbrevation;
        private DevExpress.XtraEditors.TextEdit SectionIDTextEdit;
        private DevExpress.XtraEditors.LookUpEdit DepartmentIDLookUpEdit;
        private DevExpress.XtraEditors.TextEdit NumberTextEdit;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.TextEdit AbbrevationTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDepartmentID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAbbrevation;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSectionID;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
    }
}