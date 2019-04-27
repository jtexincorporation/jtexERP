namespace JTex.Forms.Inventory.Yarn
{
    partial class YarnStockEnteryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YarnStockEnteryForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.DemandSave = new DevExpress.XtraBars.BarButtonItem();
            this.UpdateDemand = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteDemand = new DevExpress.XtraBars.BarButtonItem();
            this.ClearDemand = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.DemandExit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.button1 = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.yarnStocksBindingSource = new System.Windows.Forms.BindingSource();
            this.colStoreID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYarnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYarn_Po = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYarnsBags = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyarnGatepass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGP_Category = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYarnNetweighy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDriverName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVehicleNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yarnStocksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.DemandSave,
            this.UpdateDemand,
            this.DeleteDemand,
            this.ClearDemand,
            this.barButtonItem1,
            this.DemandExit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbon.Size = new System.Drawing.Size(1078, 130);
            // 
            // DemandSave
            // 
            this.DemandSave.Caption = "Save";
            this.DemandSave.Id = 1;
            this.DemandSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DemandSave.ImageOptions.Image")));
            this.DemandSave.Name = "DemandSave";
            this.DemandSave.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // UpdateDemand
            // 
            this.UpdateDemand.Caption = "Update";
            this.UpdateDemand.Id = 2;
            this.UpdateDemand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("UpdateDemand.ImageOptions.Image")));
            this.UpdateDemand.Name = "UpdateDemand";
            this.UpdateDemand.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // DeleteDemand
            // 
            this.DeleteDemand.Caption = "Delete";
            this.DeleteDemand.Enabled = false;
            this.DeleteDemand.Id = 3;
            this.DeleteDemand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DeleteDemand.ImageOptions.Image")));
            this.DeleteDemand.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DeleteDemand.ImageOptions.LargeImage")));
            this.DeleteDemand.Name = "DeleteDemand";
            this.DeleteDemand.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // ClearDemand
            // 
            this.ClearDemand.Caption = "Clear";
            this.ClearDemand.Id = 4;
            this.ClearDemand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ClearDemand.ImageOptions.Image")));
            this.ClearDemand.Name = "ClearDemand";
            this.ClearDemand.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Print and Preview";
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // DemandExit
            // 
            this.DemandExit.Caption = "Exit";
            this.DemandExit.Id = 6;
            this.DemandExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DemandExit.ImageOptions.Image")));
            this.DemandExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DemandExit.ImageOptions.LargeImage")));
            this.DemandExit.Name = "DemandExit";
            this.DemandExit.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Operations";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.DemandSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.UpdateDemand);
            this.ribbonPageGroup1.ItemLinks.Add(this.DeleteDemand);
            this.ribbonPageGroup1.ItemLinks.Add(this.ClearDemand);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Print and Preview";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.DemandExit);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Exit";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1078, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "View Stock Enteries";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.yarnStocksBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 174);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1078, 563);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStoreID,
            this.colYarnID,
            this.colYarn_Po,
            this.colPartyID,
            this.colYarnsBags,
            this.colyarnGatepass,
            this.colGP_Category,
            this.colYarnNetweighy,
            this.colDescription,
            this.colDate,
            this.colCategory,
            this.colAmount,
            this.colDriverName,
            this.colVehicleNumber,
            this.colDepartment,
            this.colAccountID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // yarnStocksBindingSource
            // 
            this.yarnStocksBindingSource.DataSource = typeof(IMS.YarnStock);
            // 
            // colStoreID
            // 
            this.colStoreID.Caption = "ID";
            this.colStoreID.FieldName = "StoreID";
            this.colStoreID.Name = "colStoreID";
            this.colStoreID.Visible = true;
            this.colStoreID.VisibleIndex = 0;
            // 
            // colYarnID
            // 
            this.colYarnID.Caption = "Yarn ID";
            this.colYarnID.FieldName = "YarnID";
            this.colYarnID.Name = "colYarnID";
            this.colYarnID.Visible = true;
            this.colYarnID.VisibleIndex = 1;
            // 
            // colYarn_Po
            // 
            this.colYarn_Po.Caption = "PO #";
            this.colYarn_Po.FieldName = "Yarn_Po";
            this.colYarn_Po.Name = "colYarn_Po";
            this.colYarn_Po.Visible = true;
            this.colYarn_Po.VisibleIndex = 2;
            // 
            // colPartyID
            // 
            this.colPartyID.Caption = "Supplier ID";
            this.colPartyID.FieldName = "PartyID";
            this.colPartyID.Name = "colPartyID";
            this.colPartyID.Visible = true;
            this.colPartyID.VisibleIndex = 3;
            // 
            // colYarnsBags
            // 
            this.colYarnsBags.Caption = "Bags";
            this.colYarnsBags.FieldName = "YarnsBags";
            this.colYarnsBags.Name = "colYarnsBags";
            this.colYarnsBags.Visible = true;
            this.colYarnsBags.VisibleIndex = 4;
            // 
            // colyarnGatepass
            // 
            this.colyarnGatepass.Caption = "Gate Pass #";
            this.colyarnGatepass.FieldName = "yarnGatepass";
            this.colyarnGatepass.Name = "colyarnGatepass";
            this.colyarnGatepass.Visible = true;
            this.colyarnGatepass.VisibleIndex = 5;
            // 
            // colGP_Category
            // 
            this.colGP_Category.FieldName = "GP_Category";
            this.colGP_Category.Name = "colGP_Category";
            this.colGP_Category.Visible = true;
            this.colGP_Category.VisibleIndex = 6;
            // 
            // colYarnNetweighy
            // 
            this.colYarnNetweighy.FieldName = "YarnNetweighy";
            this.colYarnNetweighy.Name = "colYarnNetweighy";
            this.colYarnNetweighy.Visible = true;
            this.colYarnNetweighy.VisibleIndex = 7;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 8;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 9;
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 10;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 11;
            // 
            // colDriverName
            // 
            this.colDriverName.FieldName = "DriverName";
            this.colDriverName.Name = "colDriverName";
            this.colDriverName.Visible = true;
            this.colDriverName.VisibleIndex = 12;
            // 
            // colVehicleNumber
            // 
            this.colVehicleNumber.FieldName = "VehicleNumber";
            this.colVehicleNumber.Name = "colVehicleNumber";
            this.colVehicleNumber.Visible = true;
            this.colVehicleNumber.VisibleIndex = 13;
            // 
            // colDepartment
            // 
            this.colDepartment.FieldName = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.Visible = true;
            this.colDepartment.VisibleIndex = 14;
            // 
            // colAccountID
            // 
            this.colAccountID.FieldName = "AccountID";
            this.colAccountID.Name = "colAccountID";
            this.colAccountID.Visible = true;
            this.colAccountID.VisibleIndex = 15;
            // 
            // YarnStockEnteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 737);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ribbon);
            this.Name = "YarnStockEnteryForm";
            this.Ribbon = this.ribbon;
            this.Text = "YarnStockEnteryForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yarnStocksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem DemandSave;
        private DevExpress.XtraBars.BarButtonItem UpdateDemand;
        private DevExpress.XtraBars.BarButtonItem DeleteDemand;
        private DevExpress.XtraBars.BarButtonItem ClearDemand;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem DemandExit;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource yarnStocksBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colStoreID;
        private DevExpress.XtraGrid.Columns.GridColumn colYarnID;
        private DevExpress.XtraGrid.Columns.GridColumn colYarn_Po;
        private DevExpress.XtraGrid.Columns.GridColumn colPartyID;
        private DevExpress.XtraGrid.Columns.GridColumn colYarnsBags;
        private DevExpress.XtraGrid.Columns.GridColumn colyarnGatepass;
        private DevExpress.XtraGrid.Columns.GridColumn colGP_Category;
        private DevExpress.XtraGrid.Columns.GridColumn colYarnNetweighy;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDriverName;
        private DevExpress.XtraGrid.Columns.GridColumn colVehicleNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountID;
    }
}