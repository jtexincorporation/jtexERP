﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JTex.Forms.HR
{
    public partial class IncrementForm : Form
    {
        public IncrementForm()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
        }


        private void clearALL()
        {
            TBID.Text = "";
            TBEmployeeID.Text = "";
            TBSalary.Text = "";
            TBAmount.Text = "";
            TBDescription.Text = "";
            DTPDate.Text = "";
        }
        private void IncrementSelection()
        {
            
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
            }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearALL();
        }


        private void IncrementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'incrementDataSet.IncrementSalary' table. You can move, or remove it, as needed.
            TBAmount.Text = "";
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
        }
    }
}
