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

namespace JTex.Forms.ArTMS
{
    public partial class StatusCategoryForm : Form
    {
        public StatusCategoryForm()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Modelx.ATMSEntityModel dbContext = new Modelx.ATMSEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.StatusCategories.Load();
            // This line of code is generated by Data Source Configuration Wizard
            statusCategoriesBindingSource.DataSource = dbContext.StatusCategories.Local.ToBindingList();
        }

        ATMSEntityModel DbContext;
        Modelx.StatusCategory scObj = new Modelx.StatusCategory();


        private void popGrid()
        {
            DbContext = new ATMSEntityModel();
            DbContext.StatusCategories.Load();
            gridControl1.DataSource = DbContext.StatusCategories.Local;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiPrintPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            scObj.category = categoryTextEdit.Text.Trim();
            scObj.name = nameTextEdit.Text.Trim();
            scObj.description = descriptionTextEdit.Text.Trim();
            scObj.isactive = isactiveCheckEdit.Checked;

            using (var DbEntities = new ATMSEntityModel())
            {
                DbEntities.StatusCategories.Add(scObj);
                DbEntities.SaveChanges();
            }
            popGrid();

        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (statusidTextEdit.Text != "")
            {
                scObj.statusid = Convert.ToByte(statusidTextEdit.Text.Trim());
                scObj.category = categoryTextEdit.Text.Trim();
                scObj.name = nameTextEdit.Text.Trim();
                scObj.description = descriptionTextEdit.Text.Trim();
                scObj.isactive = isactiveCheckEdit.Checked;

                DbContext = new ATMSEntityModel();
                DbContext.Entry(scObj).State = EntityState.Modified;
                DbContext.SaveChanges();

                popGrid();
            }
            else
            {
                MessageBox.Show("Please insert status category...");
            }
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (statusidTextEdit.Text != "")
            {
                scObj.statusid = Convert.ToByte(statusidTextEdit.Text.Trim());
                DbContext = new ATMSEntityModel();

                DbContext.Entry(scObj).State = EntityState.Deleted;
                DbContext.SaveChanges();
                popGrid();
            }
            else
            {
                MessageBox.Show("Please insert status category...");
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                statusidTextEdit.Text = gridView1.GetFocusedRowCellValue("statusid").ToString().Trim();
                nameTextEdit.Text= gridView1.GetFocusedRowCellValue("name").ToString().Trim();
                categoryTextEdit.Text= gridView1.GetFocusedRowCellValue("category").ToString().Trim();
                descriptionTextEdit.Text= gridView1.GetFocusedRowCellValue("description").ToString().Trim();
                isactiveCheckEdit.Checked = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("isactive").ToString().Trim());
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }
    }
}
