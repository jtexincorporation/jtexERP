﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.Entity;
using IMS;

namespace JTex.Forms.Inventory.Yarn
{
    public partial class Define : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        IMSEntityModel iMSEntityModel;
        yDefine yDefine = new yDefine();



        public Define()
        {
            InitializeComponent();

            ShowGrid();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Modelx.ADOEntityModel dbContext = new Modelx.ADOEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Level4.Load();
            // This line of code is generated by Data Source Configuration Wizard
            level4BindingSource.DataSource = dbContext.Level4.Local.ToBindingList();
        }
        //Inventory.Yarn.Define ydObj = new Inventory.Yarn.Define();

        //yDefine ydObj = new yDefine();



        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            AddYarnDefine();
            clear();
            ShowGrid();
        }
        //Deine Yarn add method
        private void AddYarnDefine()
        {
            if (Yarn_idTextEdit.Text == string.Empty || TypeTextEdit.Text == string.Empty || CountTextEdit.Text == string.Empty || BrandNameTextEdit.Text == string.Empty || L4_idLookUpEdit.Text == string.Empty || ItemTypeTextEdit.Text == string.Empty)
            {
                MessageBox.Show("Please fill the Form Completely");
            }

            yDefine.Yarn_id = Convert.ToInt32(Yarn_idTextEdit.Text.Trim());
            yDefine.Type = TypeTextEdit.Text.Trim();
            yDefine.Count = CountTextEdit.Text.Trim();
            yDefine.BrandName = BrandNameTextEdit.Text.Trim();
            yDefine.L4_id = Convert.ToInt32(L4_idLookUpEdit.EditValue.ToString());
            yDefine.ItemType = ItemTypeTextEdit.Text.Trim();
            if (isActive.CheckState == CheckState.Checked)
            {
                yDefine.isActive = isActive.Text;
            }
            else
            {
                yDefine.isActive = "De-activate";
            }
            using (iMSEntityModel = new IMSEntityModel())
            {
                iMSEntityModel.YDefines.Add(yDefine);
                iMSEntityModel.SaveChanges();
            }
            MessageBox.Show("Record Added Successfully");
        }
        private void clear()
        {
            Yarn_idTextEdit.Text = "";
            TypeTextEdit.Text = "";
            CountTextEdit.Text = "";
            BrandNameTextEdit.Text = "";
            L4_idLookUpEdit.EditValue = null;
            ItemTypeTextEdit.Text = "";
            isActive.CheckState = CheckState.Unchecked;


        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            clear();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        private void ShowGrid()
        {
            using (iMSEntityModel = new IMSEntityModel())
            {
                var result = iMSEntityModel.YDefines.ToList();
                gridControl1.DataSource = result;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Yarn_idTextEdit.Text = gridView1.GetFocusedRowCellValue("Yarn_id").ToString();
            TypeTextEdit.Text = gridView1.GetFocusedRowCellValue("Type").ToString();
            CountTextEdit.Text = gridView1.GetFocusedRowCellValue("Count").ToString();
            BrandNameTextEdit.Text = gridView1.GetFocusedRowCellValue("BrandName").ToString();
            ItemTypeTextEdit.Text = gridView1.GetFocusedRowCellValue("ItemType").ToString();
            string chekbox = gridView1.GetFocusedRowCellValue("isActive").ToString();
            if (chekbox.Equals("IsActive"))
            {
                isActive.CheckState = CheckState.Checked;
            }
            else
            {
                isActive.CheckState = CheckState.Unchecked;
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Updatetable();
            clear();
            ShowGrid();
        }
        private void Updatetable()
        {
            yDefine.Yarn_id = Convert.ToInt32(Yarn_idTextEdit.Text.Trim());
            yDefine.Type = TypeTextEdit.Text.Trim();
            yDefine.Count = CountTextEdit.Text.Trim();
            yDefine.BrandName = BrandNameTextEdit.Text.Trim();
            yDefine.L4_id = Convert.ToInt32(L4_idLookUpEdit.EditValue.ToString());
            yDefine.ItemType = ItemTypeTextEdit.Text.Trim();
            if (isActive.CheckState == CheckState.Checked)
            {
                yDefine.isActive = isActive.Text;
            }
            else
            {
                yDefine.isActive = "De-activate";
            }
            using (iMSEntityModel = new IMSEntityModel())
            {
                iMSEntityModel.YDefines.Add(yDefine);
                iMSEntityModel.Entry(yDefine).State = EntityState.Modified;
                iMSEntityModel.SaveChanges();
            }
            MessageBox.Show("Record Updated Successfully");


        }
    }
}