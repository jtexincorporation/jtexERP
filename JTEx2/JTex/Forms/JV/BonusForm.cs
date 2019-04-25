using System;
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
    public partial class BonusForm : Form
    {
        public BonusForm()
        {
            InitializeComponent();
        }

        private void BonusForm_Load(object sender, EventArgs e)
        {

            BonusSelection();
        }

        DataTable dt = new DataTable();

        private void clearALL()
        {
            TBID.Text = "";
            EmployeeIDLookUpEdit.Text = "";
            BonusAmountTextEdit.Text = "";
            DescriptionMemoExEdit.Text = "";
            SalaryTextEdit.Text = "";
        }
        private void BonusSelection()
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
            TBID.Text = gridView1.GetFocusedRowCellValue("BonusID").ToString().Trim();
            EmployeeIDLookUpEdit.Text = gridView1.GetFocusedRowCellValue("EmployeeID").ToString().Trim();
            SalaryTextEdit.Text = gridView1.GetFocusedRowCellValue("Salary").ToString().Trim();
            MonthDateEdit.Text = gridView1.GetFocusedRowCellValue("Date").ToString().Trim();
            BonusAmountTextEdit.Text = gridView1.GetFocusedRowCellValue("Amount").ToString().Trim();
            DescriptionMemoExEdit.Text = gridView1.GetFocusedRowCellValue("Description").ToString().Trim();

        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
