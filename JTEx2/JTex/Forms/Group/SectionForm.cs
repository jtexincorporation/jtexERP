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
    public partial class SectionForm : Form
    {
        public SectionForm()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Modelx.ADOEntityModel dbContext = new Modelx.ADOEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Sections.Load();
            // This line of code is generated by Data Source Configuration Wizard
            sectionsBindingSource.DataSource = dbContext.Sections.Local.ToBindingList();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
             dbContext = new Modelx.ADOEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Departments.Load();
            // This line of code is generated by Data Source Configuration Wizard
            departmentsBindingSource.DataSource = dbContext.Departments.Local.ToBindingList();

        }

        ADOEntityModel DbContext = new ADOEntityModel();
        Section sObj = new Section();
        private bool Validation()
        {
            bool isSuccess= false;
            if (DepartmentIDLookUpEdit.Text != "")
                if (NumberTextEdit.Text != "")
                    if (NameTextEdit.Text != "")
                        if (AbbrevationTextEdit.Text != "")
                            isSuccess = true;
                        else
                            isSuccess = false;
            return isSuccess;
        }
        private void popGrid()
        {
            DbContext = new Modelx.ADOEntityModel();
            DbContext.Sections.Load();
            gridControl1.DataSource = DbContext.Sections.Local;
        }
        private void SectionForm_Load(object sender, EventArgs e)
        {
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //to be implement
        }

        private void bbiPrintPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Validation())
            {
                sObj.DepartmentID = Convert.ToInt32(DepartmentIDLookUpEdit.Text.Trim());
                sObj.Name = NameTextEdit.Text.Trim();
                sObj.Number = Convert.ToInt32(NumberTextEdit.Text.Trim());
                sObj.Abbrevation = AbbrevationTextEdit.Text.Trim();

                using (var dbEntities = new ADOEntityModel())
                {
                    dbEntities.Sections.Add(sObj);
                    dbEntities.SaveChanges();
                }
                popGrid();
            }
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(SectionIDTextEdit.Text!="")
            {
                sObj.SectionID = Convert.ToInt32(SectionIDTextEdit.Text.Trim());
                sObj.DepartmentID = Convert.ToInt32(DepartmentIDLookUpEdit.Text.Trim());
                sObj.Name = NameTextEdit.Text.Trim();
                sObj.Number = Convert.ToInt32(NumberTextEdit.Text.Trim());
                sObj.Abbrevation = AbbrevationTextEdit.Text.Trim();

                using (var myDbEntities = new ADOEntityModel())
                {
                    myDbEntities.Entry(sObj).State = EntityState.Modified;
                    myDbEntities.SaveChanges();
                }
                popGrid();
            }
            else
            {
                MessageBox.Show("Please enter section id...");
            }
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (SectionIDTextEdit.Text != "")
            {
                sObj.SectionID = Convert.ToInt32(SectionIDTextEdit.Text.Trim());
                using (var myDbEntities = new ADOEntityModel())
                {
                    var entery = myDbEntities.Entry(sObj);
                    if (entery.State == System.Data.Entity.EntityState.Detached)
                    {
                        myDbEntities.Sections.Attach(sObj);
                        myDbEntities.Sections.Remove(sObj);
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

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                SectionIDTextEdit.Text = gridView1.GetFocusedRowCellValue("SectionID").ToString().Trim();
                DepartmentIDLookUpEdit.Text = gridView1.GetFocusedRowCellValue("DepartmentID").ToString().Trim();
                NumberTextEdit.Text = gridView1.GetFocusedRowCellValue("Number").ToString().Trim();
                NameTextEdit.Text = gridView1.GetFocusedRowCellValue("Name").ToString().Trim();
                AbbrevationTextEdit.Text = gridView1.GetFocusedRowCellValue("Abbrevation").ToString().Trim();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
