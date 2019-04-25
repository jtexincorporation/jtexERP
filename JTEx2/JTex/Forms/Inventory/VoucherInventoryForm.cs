using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JTex.Forms.Inventory
{
    public partial class VoucherInventoryForm : Form
    {
        public VoucherInventoryForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
           
        }
        private void VoucherSelection()
        {
            
        }
        private void VoucherInventoryForm_Load(object sender, EventArgs e)
        {
            VoucherSelection();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                voucherIDTextEdit.Text = gridView1.GetFocusedRowCellValue("VoucherID").ToString().Trim();
                VoucherNumberTextEdit.Text = gridView1.GetFocusedRowCellValue("VoucherNumber").ToString().Trim();
                VoucherTypeTextEdit.Text = gridView1.GetFocusedRowCellValue("VoucherType").ToString().Trim();
                RefrenceTextEdit.Text = gridView1.GetFocusedRowCellValue("Refrence").ToString().Trim();
                DepartmentIDTextEdit.Text = gridView1.GetFocusedRowCellValue("DepartmentID").ToString().Trim();
                UnitIDTextEdit.Text = gridView1.GetFocusedRowCellValue("UnitID").ToString().Trim();
                BranchIDTextEdit.Text = gridView1.GetFocusedRowCellValue("BranchID").ToString().Trim();
                CompanyIDTextEdit.Text = gridView1.GetFocusedRowCellValue("CompanyID").ToString().Trim();
                RemarksTextEdit.Text = gridView1.GetFocusedRowCellValue("Remarks").ToString().Trim();
            }
            catch (Exception EX)
            {

            }
        }
    }
}
