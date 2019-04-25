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
using System.IO;
using System.Diagnostics;
using System.Net;
using Modelx;


namespace JTex.Forms.ArTMS
{
    public partial class ArticlesForm : Form
    {
        public ArticlesForm()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Modelx.ATMSEntityModel dbContext = new Modelx.ATMSEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Articles.Load();
            // This line of code is generated by Data Source Configuration Wizard
            articlesBindingSource.DataSource = dbContext.Articles.Local.ToBindingList();
            // This line of code is generated by Data Source Configuration Wizard
            dbContext = new Modelx.ATMSEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Genders.Load();
            // This line of code is generated by Data Source Configuration Wizard
            gendersBindingSource.DataSource = dbContext.Genders.Local.ToBindingList();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            dbContext = new Modelx.ATMSEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Colors.Load();
            // This line of code is generated by Data Source Configuration Wizard
            colorsBindingSource.DataSource = dbContext.Colors.Local.ToBindingList();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            dbContext = new Modelx.ATMSEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Currencies.Load();
            // This line of code is generated by Data Source Configuration Wizard
            currenciesBindingSource.DataSource = dbContext.Currencies.Local.ToBindingList();
            Brands();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext


            //dbContext = new Modelx.ATMSEntityModel();
            //dbContext.ArticleBarcodes.Load();
            //articleBarcodesBindingSource.DataSource = dbContext.ArticleBarcodes.Local.ToBindingList();
             dbContext = new Modelx.ATMSEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Files.Load();
            // This line of code is generated by Data Source Configuration Wizard
            filesBindingSource.DataSource = dbContext.Files.Local.ToBindingList();
        }

        ATMSEntityModel DbContext = new ATMSEntityModel();
        Modelx.Article artObj = new Modelx.Article();

        #region Methods
        private void CreateArticle()
        {
            //Save Article Data
            int ArticleID = Convert.ToInt32(ArticleIDTextEdit.Text.Trim());
            string StyleNumber = StyleNumberTextEdit.Text.Trim();
            string PriceBy = PriceByTextEdit.Text.Trim();
            string Name = NameTextEdit.Text.Trim();
            MessageBox.Show("Gender" + GenderTextEdit.EditValue);
            Int16 Gender = Convert.ToInt16(GenderTextEdit.EditValue);
            Int16 Color = Convert.ToInt16(ColorTextEdit.EditValue);
            string comp = CompTextEdit.Text.Trim();
            float weight = float.Parse(CompTextEdit.Text.Trim());
            Decimal money = Decimal.Parse(PriceTextEdit.Text.Trim());
            Int16 currency = Convert.ToInt16(CurrencyTextEdit.EditValue);
            string picturePath = PicturePathTextEdit.Text.Trim();
            Boolean isActive = Convert.ToBoolean(isActiveCheckEdit.EditValue);
            Int16 Brand = Convert.ToInt16(BrandTextEdit.EditValue);
            using (var myDbEntities = new Modelx.ATMSEntityModel())
            {
                myDbEntities.Articles.Load();
                var ninjas = myDbEntities.Database.ExecuteSqlCommand("EXEC spSaveArticle {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}",
                ArticleID,
                StyleNumber,
                PriceBy,
                Name,
                Gender,
                Color,
                comp,
                weight,
                money,
                currency,
                picturePath,
                isActive,
                Brand);
                if (ninjas > 0)
                {
                    MessageBox.Show("Inserted successfuly....");
                }
                else
                {
                    MessageBox.Show("Failed to insert....");
                }
            }
        }
        private int GetMaxOne()
        {
            DbContext = new ATMSEntityModel();
            int ArticlID = DbContext.Articles.Max(age => age.ArticleID);
            ArticlID++;
            return ArticlID;
        }
        private void Search(int ArticleID)
        {
            DbContext = new ATMSEntityModel();
            try
            {
                var Article = DbContext.Articles.Find(ArticleID);

                StyleNumberTextEdit.Text = Article.StyleNumber.Trim();

                PriceByTextEdit.Text = Article.PriceBy;

                NameTextEdit.Text = Article.Name.ToString().Trim();

                GenderTextEdit.EditValue = Article.Gender;

                GenderTextEdit.EditValue = Article.Gender;

                ColorTextEdit.EditValue = Article.Color;

                CompTextEdit.Text = Article.Comp;

                WeightTextEdit.Text = Article.Weight.ToString().Trim();

                PriceTextEdit.Text = Article.Price.ToString().Trim();

                CurrencyTextEdit.EditValue = Article.Currency;

                PicturePathTextEdit.Text = Article.PicturePath;

                isActiveCheckEdit.EditValue = Article.isActive;

                BrandTextEdit.EditValue = Article.Brand;

                GetPicture();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid id...");
            }

        }
        private void SearchArticleBarcode(int ArticleID)
        {
            DbContext = new ATMSEntityModel();
            try
            {
                var Article = DbContext.ArticleBarcodes;
                foreach( var a in Article)
                {
                    gridView1.Columns.add
                }
            }
            catch(Exception ex)
            {

            }
        }
        private void GetPicture()
        {
            try
            {
                string fName = PicturePathTextEdit.Text.Trim();
                string folder = @"\\HR-PO\PO Files Data\Article Pictures\";
                string PathString = System.IO.Path.Combine(folder, fName);
                pictureEdit1.Image = Image.FromFile(PathString);
            }
            catch (Exception ex)
            {

            }
        }

        #endregion
        private void Brands()
        {
            Modelx.ATMSEntityModel dbContext = new Modelx.ATMSEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Brands.Load();
            // This line of code is generated by Data Source Configuration Wizard
            brandsBindingSource.DataSource = dbContext.Brands.Local.ToBindingList();
        }
        private void ArticlesForm_Load(object sender, EventArgs e)
        {

            ATMSEntityModel dbContext = new Modelx.ATMSEntityModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Sizes.Load();
            // This line of code is generated by Data Source Configuration Wizard
            repositoryItemGridLookUpEdit1.DataSource = dbContext.Sizes.Local.ToBindingList();

            repositoryItemGridLookUpEdit1.DisplayMember = "Name";
            repositoryItemGridLookUpEdit1.ValueMember = "SizeID";

        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }
        private void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            GetPicture();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void bbiPrintPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }  
        private void BrowseBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browse Text Files"
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Test" + openFileDialog1.FileName.ToString());
            }
        }
        private void ArticleIDTextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search(Convert.ToInt32(ArticleIDTextEdit.Text.Trim()));
            }
        }
        string FileName;
        string FolderPath;
        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FolderPath = @"\\192.168.1.116\PO Files Data\Barcode Sheets";
            try
            {
            FileName = gridView2.GetFocusedRowCellValue("FileName").ToString();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex.Message);
            }
            

        }
        private void CreateNewIDButton_Click(object sender, EventArgs e)
        {
            //Here call MaxOne Method
            ArticleIDTextEdit.Text = GetMaxOne().ToString().Trim();
        }
    }
}