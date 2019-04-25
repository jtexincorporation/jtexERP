using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JTex.Forms
{
    public partial class Branch : Form
    {
        public Branch()
        {
            InitializeComponent();

        }



        private void clearALL()
        {
            GroupIDTextEdit.Text = "";
            TBCompanyID.Text = "";
            TBName.Text = "";
            TBNumber.Text = "";
            TBAddress.Text = "";
            TBPhoneNumber.Text = "";
            TBFaxNumber.Text = "";
        }
        private void BranchSelection()
        {
            
        }
        private void Branch_Load(object sender, EventArgs e)
        {

            BranchSelection();
        }

      

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearALL();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GroupIDTextEdit.Text = gridView1.GetFocusedRowCellValue("BranchID").ToString().Trim();
            TBCompanyID.Text = gridView1.GetFocusedRowCellValue("CompanyID").ToString().Trim();
            TBName.Text = gridView1.GetFocusedRowCellValue("Name").ToString().Trim();
            TBNumber.Text = gridView1.GetFocusedRowCellValue("Number").ToString().Trim();
            TBAddress.Text = gridView1.GetFocusedRowCellValue("Address").ToString().Trim();
            TBPhoneNumber.Text = gridView1.GetFocusedRowCellValue("PhoneNumber").ToString().Trim();
            TBFaxNumber.Text = gridView1.GetFocusedRowCellValue("FaxNumber").ToString().Trim();
        }
    }
}
