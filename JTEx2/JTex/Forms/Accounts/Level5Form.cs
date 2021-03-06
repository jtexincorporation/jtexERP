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
using Modelx.Classes.Accounts;

namespace JTex.Forms.Accounts
{
    public partial class Level5Form : Form
    {
        public Level5Form()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Modelx.ADOEntityModel dbContext = new Modelx.ADOEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Level5.Load();
            // This line of code is generated by Data Source Configuration Wizard
            level5BindingSource.DataSource = dbContext.Level5.Local.ToBindingList();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            dbContext = new Modelx.ADOEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Level4.Load();
            // This line of code is generated by Data Source Configuration Wizard
            level4BindingSource.DataSource = dbContext.Level4.Local.ToBindingList();
        }
        ADOEntityModel DbContext = new ADOEntityModel();
        Level5 lObj = new Level5();

        private void popGrid()
        {
            DbContext = new ADOEntityModel();
            DbContext.Level5.Load();
            gridControl1.DataSource =DbContext.Level5.Local;
        }

        private void Level5Form_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
           
            lObj.L5_id = Convert.ToInt32(L5_idTextEdit.Text.Trim());
            lObj.L4_id = Convert.ToInt32(L4_idLookUpEdit.Text.Trim());
            lObj.Name = NameTextEdit.Text.Trim();

            using (var dbEntities = new ADOEntityModel())
            {
                dbEntities.Level5.Attach(lObj);
                dbEntities.Level5.Add(lObj);
                dbEntities.SaveChanges();
            }
            popGrid();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            lObj.L5_id = Convert.ToInt32(L5_idTextEdit.Text.Trim());
            lObj.L4_id = Convert.ToInt32(L4_idLookUpEdit.Text.Trim());
            lObj.Name = NameTextEdit.Text.Trim();
            using (var dbEntities = new ADOEntityModel())
            {
                dbEntities.Entry(lObj).State = EntityState.Modified;
                dbEntities.SaveChanges();
            }
            popGrid();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            lObj.L5_id = Convert.ToInt32(L5_idTextEdit.Text.Trim());
            using (var dbEntities = new ADOEntityModel())
            {
                dbEntities.Level5.Attach(lObj);
                dbEntities.Level5.Remove(lObj);
                dbEntities.SaveChanges();
            }
            popGrid();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                L5_idTextEdit.Text = gridView1.GetFocusedRowCellValue("L5_id").ToString().Trim();
                L4_idLookUpEdit.Text = gridView1.GetFocusedRowCellValue("L4_id").ToString().Trim();
                NameTextEdit.Text = gridView1.GetFocusedRowCellValue("Name").ToString().Trim();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
