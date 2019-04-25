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


namespace JTex.Forms
{
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Modelx.ADOEntityModel dbContext = new Modelx.ADOEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Companies.Load();
            // This line of code is generated by Data Source Configuration Wizard
            companiesBindingSource.DataSource = dbContext.Companies.Local.ToBindingList();

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            dbContext = new Modelx.ADOEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Groups.Load();
            // This line of code is generated by Data Source Configuration Wizard
            groupsBindingSource.DataSource = dbContext.Groups.Local.ToBindingList();
        }

        Company cObj = new Company();
        ADOEntityModel DbContext = new ADOEntityModel();

        private void popGrid()
        {
            DbContext = new Modelx.ADOEntityModel();
            DbContext.Companies.Load();
            gridControl1.DataSource = DbContext.Companies.Local;
        }


        private void CompanyForm_Load(object sender, EventArgs e)
        {
           
        }

        private void bbiPrintPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                cObj.GroupID = Convert.ToInt32(GroupIDLookUpEdit.Text.Trim());
                cObj.Name = NameTextEdit.Text.Trim();
            cObj.ShortName = ShortNameTextEdit.Text.Trim();
            cObj.NTN = NTNTextEdit.Text.Trim();
            cObj.STN = STNTextEdit.Text.Trim();
            cObj.Email = EmailTextEdit.Text.Trim();
            cObj.Website = WebsiteTextEdit.Text.Trim();
                using (var myDbEntities = new ADOEntityModel())
                {

                    myDbEntities.Companies.Add(cObj);
                    myDbEntities.SaveChanges();
                }
                popGrid();      
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cObj.CompanyID = Convert.ToInt32(CompanyIDTextEdit.Text.Trim());
            if (CompanyIDTextEdit.Text != "")
            {
                using (var myDbEntities = new ADOEntityModel())
                {
                    var entery = myDbEntities.Entry(cObj);
                    if (entery.State == System.Data.Entity.EntityState.Detached)
                    {
                        myDbEntities.Companies.Attach(cObj);
                        myDbEntities.Companies.Remove(cObj);
                        myDbEntities.SaveChanges();
                    }
                }
                popGrid();
            }
            else
            {
                MessageBox.Show("Please enter group id...");
            }
        }


        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CompanyIDTextEdit.Text != "")
            {
                cObj.CompanyID = Convert.ToInt32(CompanyIDTextEdit.Text.Trim());
                cObj.GroupID = Convert.ToInt32(GroupIDLookUpEdit.Text.Trim());
                cObj.Name = NameTextEdit.Text.Trim();
                cObj.ShortName = ShortNameTextEdit.Text.Trim();
                cObj.NTN = NTNTextEdit.Text.Trim();
                cObj.STN = STNTextEdit.Text.Trim();
                cObj.Email = EmailTextEdit.Text.Trim();
                cObj.Website = WebsiteTextEdit.Text.Trim();
                using (var myDbEntities = new ADOEntityModel())
                {
                    myDbEntities.Entry(cObj).State = EntityState.Modified;
                    myDbEntities.SaveChanges();
                }
                popGrid();
            }
            else
            {
                MessageBox.Show("Please fill all the fields...");
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CompanyIDTextEdit.Text = gridView1.GetFocusedRowCellValue("CompanyID").ToString().Trim();
            GroupIDLookUpEdit.Text = gridView1.GetFocusedRowCellValue("GroupID").ToString().Trim();
            NameTextEdit.Text = gridView1.GetFocusedRowCellValue("Name").ToString().Trim();
            ShortNameTextEdit.Text = gridView1.GetFocusedRowCellValue("ShortName").ToString().Trim();
            NTNTextEdit.Text = gridView1.GetFocusedRowCellValue("NTN").ToString().Trim();
            STNTextEdit.Text = gridView1.GetFocusedRowCellValue("STN").ToString().Trim();
            WebsiteTextEdit.Text = gridView1.GetFocusedRowCellValue("Website").ToString().Trim();
            EmailTextEdit.Text = gridView1.GetFocusedRowCellValue("Email").ToString().Trim();
        }
    }
}