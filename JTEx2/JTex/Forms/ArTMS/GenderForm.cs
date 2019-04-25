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
    public partial class GenderForm : Form
    {
        public GenderForm()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Modelx.ATMSEntityModel dbContext = new Modelx.ATMSEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Genders.Load();
            // This line of code is generated by Data Source Configuration Wizard
            gendersBindingSource.DataSource = dbContext.Genders.Local.ToBindingList();
        }
        ATMSEntityModel DbContext;
        Gender gObj = new Gender();

        private void popGrid()
        {
            DbContext = new ATMSEntityModel();
            DbContext.Genders.Load();
            gridControl1.DataSource = DbContext.Genders.Local;

        }
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gObj.name = nameTextEdit.Text.Trim();
            gObj.isActive = isActiveCheckEdit.Checked;

            DbContext = new ATMSEntityModel();
            DbContext.Genders.Add(gObj);
            DbContext.SaveChanges();
            popGrid();
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GenderIDTextEdit.Text != "")
            {
                gObj.GenderID = Convert.ToByte(GenderIDTextEdit.Text.Trim());
                gObj.name = nameTextEdit.Text.Trim();
                gObj.isActive = isActiveCheckEdit.Checked;

                DbContext = new ATMSEntityModel();
                DbContext.Entry(gObj).State = EntityState.Modified;
                DbContext.SaveChanges();
                popGrid();
            }
            else
            {
                MessageBox.Show("Please insert gender id...");
            }
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GenderIDTextEdit.Text != "")
            {
                gObj.GenderID = Convert.ToByte(GenderIDTextEdit.Text.Trim());

                DbContext = new ATMSEntityModel();
                DbContext.Entry(gObj).State = EntityState.Deleted;
                DbContext.SaveChanges();
                popGrid();
            }
            else
            {
                MessageBox.Show("Please insert gender id...");
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                GenderIDTextEdit.Text = gridView1.GetFocusedRowCellValue("GenderID").ToString().Trim();
                nameTextEdit.Text = gridView1.GetFocusedRowCellValue("Name").ToString().Trim();
                isActiveCheckEdit.Checked = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("isActive"));
            }
            catch(Exception ex)
            {

            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
