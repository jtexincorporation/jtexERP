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
    public partial class LeaveForm : Form
    {
        public LeaveForm()
        {
            InitializeComponent();
        }


        private void clearALL()
        {
            GroupIDTextEdit.Text = "";
            TBEmployeeID.Text = "";
            DTPFromDate.Text = "";
            DTODate.Text = "";
            DTPApprovalDate.Text = "";
            TBDescription.Text = "";
        }
        private void IncrementSelection()
        {
          
        }
        private void LeaveForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Leave' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet5.Leave' table. You can move, or remove it, as needed.
            
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GroupIDTextEdit.Text = gridView1.GetFocusedRowCellValue("leave_id").ToString().Trim();
            TBEmployeeID.Text = gridView1.GetFocusedRowCellValue("EmployeeID").ToString().Trim();
            DTPFromDate.Text = gridView1.GetFocusedRowCellValue("FromDate").ToString().Trim();
            DTPToDate.Text = gridView1.GetFocusedRowCellValue("ToDate").ToString().Trim();
            DTPApprovalDate.Text = gridView1.GetFocusedRowCellValue("ApprovalDate").ToString().Trim();
            TBDaysDifference.Text = gridView1.GetFocusedRowCellValue("Days").ToString().Trim();
            TBDescription.Text = gridView1.GetFocusedRowCellValue("Description").ToString().Trim();
        }

        private void TBDays_Enter(object sender, EventArgs e)
        {
           
        }

        private void ButtonAvailableDays_Click(object sender, EventArgs e)
        {
            //Check available days of employee
            
        }

        private void BTNCheckAvailableLeavseInYear_Click(object sender, EventArgs e)
        {
          
            
        }
    }
}
