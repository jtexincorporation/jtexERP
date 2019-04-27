using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTex.Forms.Inventory.Yarn
{
    public partial class YarnMainForm : Form
    {
        public YarnMainForm()
        {
            InitializeComponent();
        }
        Define dfObj;

        private void YarnDefineNavBar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if(dfObj==null)
            {
                dfObj = new Define();
                dfObj.MdiParent = this;
                dfObj.Show();
                dfObj.BringToFront();
                dfObj.FormClosed += DfObj_FormClosed;
            }
            if (dfObj != null)
            {
                dfObj.BringToFront();
            }
            else;
            {
                dfObj.Activate();
            }
        }

        private void DfObj_FormClosed(object sender, FormClosedEventArgs e)
        {
            dfObj = null;
        }
        FormDemand fdObj;
        private void yarnDemandGenerateNavabar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (fdObj == null)
            {
                fdObj = new FormDemand();
                fdObj.MdiParent = this;
                fdObj.Show();
                fdObj.BringToFront();
                fdObj.FormClosed += FdObj_FormClosed;
            }
            if (dfObj != null)
            {
                fdObj.BringToFront();
            }
            else
            {
                fdObj.Activate();
            }
        }

        private void FdObj_FormClosed(object sender, FormClosedEventArgs e)
        {
            fdObj = null;
        }

        FormYarnStore fyObj;
        private void YarnStockNavBar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (fyObj == null)
            {
                fyObj = new FormYarnStore();
                fyObj.MdiParent = this;
                fyObj.Show();
                fyObj.BringToFront();
                fyObj.FormClosed += FyObj_FormClosed;
            }
            if (fyObj != null)
            {
                fyObj.BringToFront();
            }
            else
            {
                fyObj.Activate();
            }
        }

        private void FyObj_FormClosed(object sender, FormClosedEventArgs e)
        {
            fyObj = null;
        }

        private void ViewyarnStockEnteryNavbar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }
    }
}
