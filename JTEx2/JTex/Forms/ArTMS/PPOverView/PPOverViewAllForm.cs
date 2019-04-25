﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTex.Forms.ArTMS
{
    public partial class PPOverViewAll : Form
    {
        public PPOverViewAll()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
        }
        Modelx.ATMSEntityModel DbContext = new Modelx.ATMSEntityModel();

        public static bool FindSomething = false;
        public static int ArticleID;
        public static Decimal PoID;
        Modelx.ATMSEntityModel DbxContext = new Modelx.ATMSEntityModel();
        private void PPOverViewAll_Load(object sender, EventArgs e)
        {
            //GetArticleID();
            //MessageBox.Show(""+FindSomething);


            //FindSomething = true;

           
            //mf.NB_PO_DEFINE_LinkClicked(sender, e);
        }
        private void ViewALL()
        {
            
               
        }
        MainForm mf = new MainForm();
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiPrintPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
        public int GetArticleID()
        {
            int articleID;
            string A = gridView1.GetFocusedRowCellValue("Style#").ToString().Trim();
            using (var db = new Modelx.ATMSEntityModel())
            {
                articleID = db.Articles.Where(u => u.StyleNumber ==A).
                    Select(u => u.ArticleID).
                    SingleOrDefault();
            }
            return articleID;
        }
        public Decimal GetPOID()
        {
            Decimal PoID;
            string A = gridView1.GetFocusedRowCellValue("PO #").ToString().Trim();
            using (var db = new Modelx.ATMSEntityModel())
            {
                PoID = db.PurchaseOrders.Where(u => u.po == A).
                    Select(u => u.doc).
                    FirstOrDefault();
            }
            return PoID;
        }
        //ArticlesForm bf;
        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                MessageBox.Show("Style#   :"+ gridView1.GetFocusedRowCellValue("Style#").ToString().Trim() + "' copied...");
                //FindSomething = true;
                ArticleID = GetArticleID();
            }
            else if(e.KeyCode==Keys.F12)
            {
                MessageBox.Show("PO#    : " + gridView1.GetFocusedRowCellValue("PO #").ToString().Trim() + " is copied...");
                PoID = GetPOID();
            }
        }

        private void Bf_FormClosed(object sender, FormClosedEventArgs e)
        {
            //bf = null;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridView1.GetFocusedRowCellValue("Style#").ToString().Trim();
        }
        SectionForm sf;
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            mf.NB_ATMS_Sampling_LinkClicked(sender, e);
        }
    }
}
