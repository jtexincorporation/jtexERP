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
    public partial class CurrencyForm : Form
    {
        public CurrencyForm()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Modelx.ATMSEntityModel dbContext = new Modelx.ATMSEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Currencies.Load();
            // This line of code is generated by Data Source Configuration Wizard
            currenciesBindingSource.DataSource = dbContext.Currencies.Local.ToBindingList();
        }

        private void bbiPrintPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
        ATMSEntityModel DbContext = new ATMSEntityModel();
        Currency cObj = new Currency();

        private void popGrid()
        {
            DbContext = new ATMSEntityModel();
            DbContext.Currencies.Load();
            gridControl1.DataSource = DbContext.Currencies.Local;
        }
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cObj.Name = NameTextEdit.Text.Trim();
            cObj.Description = DescriptionTextEdit.Text.Trim();
            cObj.isActive = isActiveCheckEdit.Checked;

            using (var dbEntities = new ATMSEntityModel())
            {
                dbEntities.Currencies.Add(cObj);
                dbEntities.SaveChanges();
            }
            popGrid();
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CurrencyIDTextEdit.Text != "")
            {
                cObj.CurrencyID = Convert.ToByte(CurrencyIDTextEdit.Text.Trim());
                cObj.Name = NameTextEdit.Text.Trim();
                cObj.Description = DescriptionTextEdit.Text.Trim();
                cObj.isActive = isActiveCheckEdit.Checked;

                using (var DbEntities = new ATMSEntityModel())
                {
                    DbEntities.Entry(cObj).State = EntityState.Modified;
                    DbEntities.SaveChanges();
                }
                popGrid();
            }
            else
            {
                MessageBox.Show("Please enter currency id....");
            }
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CurrencyIDTextEdit.Text != "")
            {
                cObj.CurrencyID = Convert.ToByte(CurrencyIDTextEdit.Text.Trim());

                using (var DbEntities = new ATMSEntityModel())
                {
                    DbEntities.Currencies.Attach(cObj);
                    DbEntities.Currencies.Remove(cObj);
                    DbEntities.SaveChanges();
                }
                popGrid();
            }
            else
            {
                MessageBox.Show("Please enter currency id....");
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                CurrencyIDTextEdit.Text = gridView1.GetFocusedRowCellValue("CurrencyID").ToString().Trim();
                NameTextEdit.Text = gridView1.GetFocusedRowCellValue("Name").ToString().Trim();
                DescriptionTextEdit.Text = gridView1.GetFocusedRowCellValue("Description").ToString().Trim();
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
