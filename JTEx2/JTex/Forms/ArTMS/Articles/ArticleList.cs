using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace JTex.Forms.ArTMS
{
    public partial class ArticleList : Form
    {
        public ArticleList()
        {
            InitializeComponent();

            sqlDataSource1.Fill();
        }
        private void GetPicture()
        {
            try
            {
                string fName = gridView1.GetFocusedRowCellValue("PicturePath").ToString().Trim();
                string folder = @"\\Acc-stock\jtex\PO Files Data\Article Pictures\";
                string PathString = System.IO.Path.Combine(folder, fName);
                pictureEdit1.Image = Image.FromFile(PathString);
            }
            catch (Exception ex)
            {
               
            }
        }
        private void ArticleList_Load(object sender, EventArgs e)
        {
            
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            GetPicture();
        }

        private void bbiPrintPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }
    }
}
