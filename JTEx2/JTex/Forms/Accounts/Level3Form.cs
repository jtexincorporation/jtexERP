﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.Entity;
using Modelx;

namespace JTex.Forms.Accounts
{
    public partial class Level3Form : Form
    {
        public Level3Form()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Modelx.ADOEntityModel dbContext = new Modelx.ADOEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Level2.Load();
            // This line of code is generated by Data Source Configuration Wizard
            L2_idTextEdit.Properties.DataSource = dbContext.Level2.Local.ToBindingList();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            dbContext = new Modelx.ADOEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Level3.Load();
            // This line of code is generated by Data Source Configuration Wizard
            gridControl1.DataSource = dbContext.Level3.Local.ToBindingList();
        }
        ADOEntityModel amObj = new ADOEntityModel();
        Modelx.Level3 lObj = new Modelx.Level3();
        DataTable dt = new DataTable();

        private void Level3Form_Load(object sender, EventArgs e)
        {
            
        }
        private bool Validations()
        {
            bool isSuccess = false;
            if (L2_idTextEdit.Text != "")
                if (L3_idTextEdit.Text != "")
                    if (NameTextEdit.Text != "")
                        isSuccess = true;
                    else
                        isSuccess = false;
            return isSuccess;
        }
        private bool GetIntArray()
        {
            bool isSuccess;
            int num = Convert.ToInt32(L2_idTextEdit.Text.Trim());
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();

            int num1 = Convert.ToInt32(L3_idTextEdit.Text.Trim());
            List<int> listOfInts1 = new List<int>();
            while (num1 > 0)
            {
                listOfInts1.Add(num1 % 10);
                num1 = num1 / 10;
            }
            listOfInts1.Reverse();

            if (listOfInts[0].ToString() == listOfInts1[0].ToString() && listOfInts[1].ToString() == listOfInts1[1].ToString())
                return isSuccess = true;
            else
                return isSuccess = false;
        }
        public void popGrid()
        {
            using (ADOEntityModel amObj = new ADOEntityModel())
            {
                gridControl1.DataSource = amObj.Level3.ToList();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(GetIntArray()==true)
            {
                if(Validations())
                {
                    lObj.L3_id = Convert.ToInt32(L3_idTextEdit.Text.Trim());
                    lObj.L2_id = Convert.ToInt32(L2_idTextEdit.Text.Trim());
                    lObj.Name = NameTextEdit.Text.Trim();

                    using (ADOEntityModel amObj = new ADOEntityModel())
                    {
                        amObj.Level3.Add(lObj);
                        amObj.SaveChanges();
                    }
                    popGrid();
                }
                else
                {
                    MessageBox.Show("Please fill data in all fields...");
                }
                
            }
            else
            {
                MessageBox.Show("Codes are not correct...");
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            lObj.L3_id = Convert.ToInt32(L3_idTextEdit.Text.Trim());
            if(L3_idTextEdit.Text!="")
            {
                using (ADOEntityModel amObj = new ADOEntityModel())
                {
                    amObj.Level3.Attach(lObj);
                    amObj.Level3.Remove(lObj);
                    amObj.SaveChanges();
                }
                popGrid();
            }
           else
            {
                MessageBox.Show("Please enter Level 3 code...");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if(GetIntArray()==true)
            {
                if(Validations())
                {
                    lObj.L3_id = Convert.ToInt32(L3_idTextEdit.Text.Trim());
                    lObj.L2_id = Convert.ToInt32(L2_idTextEdit.Text.Trim());
                    lObj.Name = NameTextEdit.Text.Trim();

                    using (ADOEntityModel amObj = new ADOEntityModel())
                    {
                        amObj.Entry(lObj).State = EntityState.Modified;
                        amObj.SaveChanges();
                    }
                    popGrid();
                }
                else
                {
                    MessageBox.Show("Please fill data in all fields....");
                }
            }
            else
            {
                MessageBox.Show("Codes are not correct...");
            }
        }


        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                L3_idTextEdit.Text = gridView1.GetFocusedRowCellValue("L3_id").ToString().Trim();
                L2_idTextEdit.Text = gridView1.GetFocusedRowCellValue("L2_id").ToString().Trim();
                NameTextEdit.Text = gridView1.GetFocusedRowCellValue("Name").ToString().Trim();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
