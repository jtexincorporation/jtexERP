namespace JTex.Forms
{
    partial class SubsectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubsectionForm));
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
            this.subsectionsBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSubsectionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSectionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbbrevation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.SubsectionIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SectionIDLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource();
            this.NumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AbbrevationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAbbrevation = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSectionID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSubsectionID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subsectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubsectionIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SectionIDLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbbrevationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAbbrevation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSectionID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSubsectionID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(1253, 103);
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
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataLayoutControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1253, 692);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.subsectionsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1247, 478);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // subsectionsBindingSource
            // 
            this.subsectionsBindingSource.DataSource = typeof(Modelx.Subsection);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubsectionID,
            this.colSectionID,
            this.colNumber,
            this.colName,
            this.colAbbrevation});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colSubsectionID
            // 
            this.colSubsectionID.FieldName = "SubsectionID";
            this.colSubsectionID.Name = "colSubsectionID";
            this.colSubsectionID.Visible = true;
            this.colSubsectionID.VisibleIndex = 0;
            // 
            // colSectionID
            // 
            this.colSectionID.FieldName = "SectionID";
            this.colSectionID.Name = "colSectionID";
            this.colSectionID.Visible = true;
            this.colSectionID.VisibleIndex = 1;
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
            this.dataLayoutControl1.Controls.Add(this.SubsectionIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SectionIDLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.NumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AbbrevationTextEdit);
            this.dataLayoutControl1.DataSource = this.subsectionsBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 487);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1247, 202);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // SubsectionIDTextEdit
            // 
            this.SubsectionIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subsectionsBindingSource, "SubsectionID", true));
            this.SubsectionIDTextEdit.Location = new System.Drawing.Point(93, 64);
            this.SubsectionIDTextEdit.MenuManager = this.ribbonControl;
            this.SubsectionIDTextEdit.Name = "SubsectionIDTextEdit";
            this.SubsectionIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.SubsectionIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SubsectionIDTextEdit.Properties.Mask.EditMask = "N0";
            this.SubsectionIDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.SubsectionIDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.SubsectionIDTextEdit.Size = new System.Drawing.Size(528, 20);
            this.SubsectionIDTextEdit.StyleController = this.dataLayoutControl1;
            this.SubsectionIDTextEdit.TabIndex = 4;
            // 
            // SectionIDLookUpEdit
            // 
            this.SectionIDLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subsectionsBindingSource, "SectionID", true));
            this.SectionIDLookUpEdit.Location = new System.Drawing.Point(694, 64);
            this.SectionIDLookUpEdit.MenuManager = this.ribbonControl;
            this.SectionIDLookUpEdit.Name = "SectionIDLookUpEdit";
            this.SectionIDLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.SectionIDLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SectionIDLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SectionIDLookUpEdit.Properties.DataSource = this.sectionsBindingSource;
            this.SectionIDLookUpEdit.Properties.DisplayMember = "SectionID";
            this.SectionIDLookUpEdit.Properties.NullText = "";
            this.SectionIDLookUpEdit.Properties.ValueMember = "SectionID";
            this.SectionIDLookUpEdit.Size = new System.Drawing.Size(233, 20);
            this.SectionIDLookUpEdit.StyleController = this.dataLayoutControl1;
            this.SectionIDLookUpEdit.TabIndex = 5;
            // 
            // sectionsBindingSource
            // 
            this.sectionsBindingSource.DataSource = typeof(Modelx.Section);
            // 
            // NumberTextEdit
            // 
            this.NumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subsectionsBindingSource, "Number", true));
            this.NumberTextEdit.Location = new System.Drawing.Point(1000, 64);
            this.NumberTextEdit.MenuManager = this.ribbonControl;
            this.NumberTextEdit.Name = "NumberTextEdit";
            this.NumberTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.NumberTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.NumberTextEdit.Properties.Mask.EditMask = "d";
            this.NumberTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.NumberTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.NumberTextEdit.Size = new System.Drawing.Size(223, 20);
            this.NumberTextEdit.StyleController = this.dataLayoutControl1;
            this.NumberTextEdit.TabIndex = 6;
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subsectionsBindingSource, "Name", true));
            this.NameTextEdit.Location = new System.Drawing.Point(93, 88);
            this.NameTextEdit.MenuManager = this.ribbonControl;
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.NameTextEdit.Size = new System.Drawing.Size(528, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 7;
            // 
            // AbbrevationTextEdit
            // 
            this.AbbrevationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subsectionsBindingSource, "Abbrevation", true));
            this.AbbrevationTextEdit.Location = new System.Drawing.Point(694, 88);
            this.AbbrevationTextEdit.MenuManager = this.ribbonControl;
            this.AbbrevationTextEdit.Name = "AbbrevationTextEdit";
            this.AbbrevationTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.AbbrevationTextEdit.Size = new System.Drawing.Size(529, 20);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(1247, 202);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(1227, 182);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup3.CaptionImageOptions.Image")));
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForNumber,
            this.ItemForAbbrevation,
            this.ItemForSectionID,
            this.ItemForSubsectionID,
            this.ItemForName});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1227, 182);
            this.layoutControlGroup3.Text = "Subsection data";
            // 
            // ItemForNumber
            // 
            this.ItemForNumber.Control = this.NumberTextEdit;
            this.ItemForNumber.Location = new System.Drawing.Point(907, 0);
            this.ItemForNumber.Name = "ItemForNumber";
            this.ItemForNumber.Size = new System.Drawing.Size(296, 24);
            this.ItemForNumber.Text = "Number";
            this.ItemForNumber.TextSize = new System.Drawing.Size(66, 13);
            // 
            // ItemForAbbrevation
            // 
            this.ItemForAbbrevation.Control = this.AbbrevationTextEdit;
            this.ItemForAbbrevation.Location = new System.Drawing.Point(601, 24);
            this.ItemForAbbrevation.Name = "ItemForAbbrevation";
            this.ItemForAbbrevation.Size = new System.Drawing.Size(602, 94);
            this.ItemForAbbrevation.Text = "Abbrevation";
            this.ItemForAbbrevation.TextSize = new System.Drawing.Size(66, 13);
            // 
            // ItemForSectionID
            // 
            this.ItemForSectionID.Control = this.SectionIDLookUpEdit;
            this.ItemForSectionID.Location = new System.Drawing.Point(601, 0);
            this.ItemForSectionID.Name = "ItemForSectionID";
            this.ItemForSectionID.Size = new System.Drawing.Size(306, 24);
            this.ItemForSectionID.Text = "Section ID";
            this.ItemForSectionID.TextSize = new System.Drawing.Size(66, 13);
            // 
            // ItemForSubsectionID
            // 
            this.ItemForSubsectionID.Control = this.SubsectionIDTextEdit;
            this.ItemForSubsectionID.Location = new System.Drawing.Point(0, 0);
            this.ItemForSubsectionID.Name = "ItemForSubsectionID";
            this.ItemForSubsectionID.Size = new System.Drawing.Size(601, 24);
            this.ItemForSubsectionID.Text = "Subsection ID";
            this.ItemForSubsectionID.TextSize = new System.Drawing.Size(66, 13);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 24);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(601, 94);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(66, 13);
            // 
            // SubsectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 795);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "SubsectionForm";
            this.Text = "SubsectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subsectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubsectionIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SectionIDLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbbrevationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAbbrevation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSectionID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSubsectionID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
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
        private System.Windows.Forms.BindingSource subsectionsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSubsectionID;
        private DevExpress.XtraGrid.Columns.GridColumn colSectionID;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAbbrevation;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit SubsectionIDTextEdit;
        private DevExpress.XtraEditors.LookUpEdit SectionIDLookUpEdit;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
        private DevExpress.XtraEditors.TextEdit NumberTextEdit;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.TextEdit AbbrevationTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSubsectionID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAbbrevation;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSectionID;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    }
}