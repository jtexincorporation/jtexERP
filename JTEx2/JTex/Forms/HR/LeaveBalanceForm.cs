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
    public partial class LeaveBalanceForm : Form
    {
        public LeaveBalanceForm()
        {
            InitializeComponent();
        }

        private void LeaveBalanceForm_Load(object sender, EventArgs e)
        {

        }


        private void clearALL()
        {
            GroupIDTextEdit.Clear();
            TBEmployeeID.Clear();
            TBNOL.Clear();
        }
        private void BonusSelection()
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GroupIDTextEdit.Text = gridView1.GetFocusedRowCellValue("ID").ToString().Trim();
            TBEmployeeID.Text = gridView1.GetFocusedRowCellValue("EmployeeID").ToString().Trim();
            TBNOL.Text = gridView1.GetFocusedRowCellValue("NOL").ToString().Trim();
        }
    }
}
