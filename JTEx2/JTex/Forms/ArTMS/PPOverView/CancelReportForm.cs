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
using System.Collections;

namespace JTex.Forms.ArTMS
{
    public partial class CancelReportForm : Form
    {
        public CancelReportForm()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Modelx.ATMSEntityModel dbContext = new Modelx.ATMSEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.StatusCategories.Load();
            // This line of code is generated by Data Source Configuration Wizard
            statusCategoriesBindingSource.DataSource = dbContext.StatusCategories.Local.ToBindingList();
        }
        ATMSEntityModel DbContext;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiPrintPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void CancelReportForm_Load(object sender, EventArgs e)
        {
         
        }
        StatusCategoryForm stf;
        private void FindIDBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stf == null)
            {
                stf = new StatusCategoryForm();
                stf.Show();
                stf.BringToFront();
                stf.FormClosed += Stf_FormClosed;
            }
            else if (stf != null)
            {
                stf.BringToFront();
            }
            else
            {
                stf.Activate();
            }
        }

        private void Stf_FormClosed(object sender, FormClosedEventArgs e)
        {
            stf = null;
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ArrayList rows = new ArrayList();
            Int32[] selectedRowHandles = gridView1.GetSelectedRows();
            if (lookUpEdit1.EditValue.ToString() == "")
            {
                MessageBox.Show("Please select status category...");
            }
            else
            {
                for (int i = 0; i < selectedRowHandles.Length; i++)
                {
                    using (var DbContex = new ATMSEntityModel())
                    {
                        try
                        {
                            DbContex.PurchaseOrders.Load();
                            var ninjas = DbContex.Database.ExecuteSqlCommand("EXEC spPOUpdation {0},{1},{2}",
                            Convert.ToInt16(lookUpEdit1.EditValue.ToString().Trim()),
                            gridView1.GetRowCellValue(selectedRowHandles[i], gridView1.Columns[4]).ToString().Trim(),
                            Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandles[i], gridView1.Columns[0]).ToString()));
                            if (ninjas > 0)
                            {

                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("" + ex.Message);
                        }
                        finally
                        {
                            MessageBox.Show("Shifted into :" + lookUpEdit1.Text + " successfuly...");
                            sqlDataSource1.Fill();
                            gridView1.ClearSelection();
                        }
                    }
                }
            }

        }
    }
}
