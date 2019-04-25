﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Modelx;

namespace JTex.Forms.ArTMS.PPOverView
{
    public partial class StatusUpdateForm : Form
    {
        public StatusUpdateForm()
        {
            InitializeComponent();

            Modelx.ATMSEntityModel dbContext = new Modelx.ATMSEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.PurchaseOrders.Load();
            // This line of code is generated by Data Source Configuration Wizard
            purchaseOrdersBindingSource.DataSource = dbContext.PurchaseOrders.Local.ToBindingList();


            dbContext = new Modelx.ATMSEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.StatusCategories.Load();
            // This line of code is generated by Data Source Configuration Wizard
            statusCategoryBindingSource.DataSource = dbContext.StatusCategories.Local.ToBindingList();


            dbContext = new Modelx.ATMSEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Seasons.Load();
            // This line of code is generated by Data Source Configuration Wizard
            seasonBindingSource.DataSource = dbContext.Seasons.Local.ToBindingList();
            //// This line of code is generated by Data Source Configuration Wizard
            //// Fill a SqlDataSource
            //sqlDataSource1.Fill();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();

          
        }

        private void StatusUpdateForm_Load(object sender, EventArgs e)
        {
            
        }
        private void UpdateStatus(decimal doc,decimal id,int articleID,DateTime delivery,DateTime commentsDate, DateTime approvalDate, string comments, string feedback, string willship, string remarks)
        {

            using (var db = new ATMSEntityModel())
            {
                var statusUpdate = db.Database.ExecuteSqlCommand("EXEC spppp {0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                    doc,id,articleID,delivery,commentsDate,approvalDate,comments,feedback,willship,remarks);
               
            }
        }
        Modelx.Brand bObj = new Brand();
        private void Search(int ArticleID)
        {
            ATMSEntityModel DbContext = new ATMSEntityModel();
            try
            {   
                var Brand = (from a in DbContext.Articles
                             join b in DbContext.Brands on a.Brand equals b.BrandID
                             where a.ArticleID == ArticleID
                             select new
                             {
                                 Name=b.Name
                             }).Take(1);
                foreach(var p in Brand)
                {
                    gridView1.SetFocusedRowCellValue("packing", p.Name);
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid id...");
            }
        }
        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32[] selectedRowHandles = gridView1.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                // Update Function
               
                decimal doc = Convert.ToDecimal(gridView1.GetRowCellValue(selectedRowHandles[i], "doc").ToString().Trim());
                decimal id = Convert.ToDecimal(gridView1.GetRowCellValue(selectedRowHandles[i], "id").ToString().Trim());
                int articleID = Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandles[i], "articleid").ToString().Trim());
                DateTime deliveryDate = Convert.ToDateTime(gridView1.GetRowCellValue(selectedRowHandles[i], "delivery").ToString().Trim());
                DateTime commentsDate = Convert.ToDateTime(gridView1.GetRowCellValue(selectedRowHandles[i], "commentsDate").ToString().Trim());
                DateTime approvalDate = Convert.ToDateTime(gridView1.GetRowCellValue(selectedRowHandles[i], "approvalDate").ToString().Trim());
                string comments = gridView1.GetRowCellValue(selectedRowHandles[i],"Comments").ToString();
                string feedBack = gridView1.GetRowCellValue(selectedRowHandles[i],"FeedBack").ToString().Trim();
                string willShip = gridView1.GetRowCellValue(selectedRowHandles[i],"WillShip").ToString().Trim();
                string Remarks = gridView1.GetRowCellValue(selectedRowHandles[i],"remarks").ToString().Trim();

                UpdateStatus(doc, id, articleID, deliveryDate, commentsDate, approvalDate,comments,feedBack,willShip,Remarks);
            }
        }


        private void FindIDBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.SelectAll();
            Int32[] selectedRowHandles = gridView1.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                Search(Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandles[i], "articleid").ToString().Trim()));
                gridView1.MoveNext();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //MessageBox.Show(""+gridView1.GetFocusedRowCellValue("Comments"));
            //MessageBox.Show("" + gridView1.GetFocusedRowCellValue("WillShip"));
            //MessageBox.Show("" + gridView1.GetFocusedRowCellValue("FeedBack"));
            //MessageBox.Show("" + gridView1.GetFocusedRowCellValue("approvalDate"));
            //MessageBox.Show("" + gridView1.GetFocusedRowCellValue("commentsDate"));
            
        }
    }
}
