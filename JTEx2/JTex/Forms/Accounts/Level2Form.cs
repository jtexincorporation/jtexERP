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

namespace JTex.Forms.Accounts
{
    public partial class Level2Form : Form
    {
        public Level2Form()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Modelx.ADOEntityModel dbContext = new Modelx.ADOEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Level1.Load();
            // This line of code is generated by Data Source Configuration Wizard
            L1_idTextEdit.Properties.DataSource = dbContext.Level1.Local.ToBindingList();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            dbContext = new Modelx.ADOEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Level2.Load();
            // This line of code is generated by Data Source Configuration Wizard
            gridControl1.DataSource = dbContext.Level2.Local.ToBindingList();
        }

        DataTable dt = new DataTable();
        ADOEntityModel amObj = new ADOEntityModel();
        Modelx.Level2 lObj = new Modelx.Level2();

        private bool GetIntArray()
        {
            bool isSuccess;
            int num = Convert.ToInt32(L1_idTextEdit.Text.Trim());
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();

            int num1 = Convert.ToInt32(L2_idTextEdit.Text.Trim());
            List<int> listOfInts1 = new List<int>();
            while (num1 > 0)
            {
                listOfInts1.Add(num1 % 10);
                num1 = num1 / 10;
            }
            listOfInts1.Reverse();

            if (listOfInts[0].ToString() == listOfInts1[0].ToString())
                return isSuccess = true;
            else
                return isSuccess = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(GetIntArray()==true)
            {
                if(Validations())
                {
                    lObj.L2_id = Convert.ToInt32(L2_idTextEdit.Text.Trim());
                    lObj.L1_id = Convert.ToInt32(L1_idTextEdit.Text.Trim());
                    lObj.Name = NameTextEdit.Text.Trim();
                    using (var myDbEntities = new ADOEntityModel())
                    {
                        myDbEntities.Level2.Add(lObj);
                        myDbEntities.SaveChanges();
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
            lObj.L2_id = Convert.ToInt32(L2_idTextEdit.Text.Trim());
            if(L2_idTextEdit.Text!="")
            {
                using (var myDbEntities = new ADOEntityModel())
                {
                    var entery = myDbEntities.Entry(lObj);
                    if (entery.State == System.Data.Entity.EntityState.Detached)
                    {
                        myDbEntities.Level2.Attach(lObj);
                        myDbEntities.Level2.Remove(lObj);
                        myDbEntities.SaveChanges();
                    }
                }
                popGrid();
            }
            else
            {
                MessageBox.Show("Please enter Level 2 code...");
            }
        }

        private void Level2Form_Load(object sender, EventArgs e)
        {
            
        }
        private bool Validations()
        {
            bool isSuccess = false;
            if (L2_idTextEdit.Text != "")
                if (L1_idTextEdit.Text != "")
                    if (NameTextEdit.Text != "")
                        isSuccess = true;
                    else
                        isSuccess = false;
            return isSuccess;
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (GetIntArray() == true)
            {
                if(Validations())
                {
                    lObj.L2_id = Convert.ToInt32(L2_idTextEdit.Text.Trim());
                    lObj.L1_id = Convert.ToInt32(L1_idTextEdit.Text.Trim());
                    lObj.Name = NameTextEdit.Text.Trim();
                    using (var myDbEntities = new ADOEntityModel())
                    {
                        myDbEntities.Entry(lObj).State = System.Data.Entity.EntityState.Modified;
                        myDbEntities.SaveChanges();
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
        private void popGrid()
        {
            ADOEntityModel db = new ADOEntityModel();
            gridControl1.DataSource = db.Level2.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                L2_idTextEdit.Text = gridView1.GetFocusedRowCellValue("L2_id").ToString().Trim();
                L1_idTextEdit.Text = gridView1.GetFocusedRowCellValue("L1_id").ToString().Trim();
                NameTextEdit.Text = gridView1.GetFocusedRowCellValue("Name").ToString().Trim();
            }
            catch(Exception ex)
            {

            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            
        }
    }
}
