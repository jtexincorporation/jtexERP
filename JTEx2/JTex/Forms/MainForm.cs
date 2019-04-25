using JTex.Forms;
using JTex.Forms.Accounts;
using JTex.Forms.ArTMS;
using JTex.Forms.ArTMS.PPOverView;
using JTex.Forms.HR;
using JTex.Forms.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTex
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }
        GroupForm gf;
        public void NBGroup_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Group Form 
            if (gf == null)
            {

                gf = new GroupForm();
                gf.MdiParent = this;
                gf.Show();
                gf.BringToFront();
                gf.FormClosed += Gf_FormClosed;
            }
            else if (gf != null)
            {
                gf.BringToFront();
            }
            else
            {
                gf.Activate();
            }
        }

     

        private void Gf_FormClosed(object sender, FormClosedEventArgs e)
        {
            gf = null;
        }


        CompanyForm cf;
        private void NBCompany_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Comapny
            if (cf == null)
            {

                cf = new CompanyForm();
                cf.MdiParent = this;
                cf.Show();
                cf.BringToFront();
                cf.FormClosed += Cf_FormClosed;
            }
            else if (cf != null)
            {
                cf.BringToFront();
            }
            else
            {
                cf.Activate();
            }

        }

        private void Cf_FormClosed(object sender, FormClosedEventArgs e)
        {
            cf = null;
        }

        Branch bf;
        private void NBBranch_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Branch
            if (bf == null)
            {
                bf = new Branch();
                bf.MdiParent = this;
                bf.Show();
                bf.BringToFront();
                bf.FormClosed += Bf_FormClosed;
            }
            else if (bf != null)
            {
                bf.BringToFront();
            }
            else
            {
                bf.Activate();
            }
        }

        private void Bf_FormClosed(object sender, FormClosedEventArgs e)
        {
            bf = null;
        }

        GatePassForm uf;
        private void NBUnit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Unit
            if (uf == null)
            {

                uf = new GatePassForm();
                uf.MdiParent = this;
                uf.Show();
                uf.BringToFront();
                uf.FormClosed += Uf_FormClosed;
            }
            else if (uf != null)
            {
                uf.BringToFront();
            }
            else
            {
                uf.Activate();
            }
        }

        private void Uf_FormClosed(object sender, FormClosedEventArgs e)
        {
            uf = null;
        }

        internal void NB_ATMS_Sampling_LinkClicked(object sender, EventArgs e)
        {
            if (sf == null)
            {
                sf = new SectionForm();
                //IsMdiContainer = true;
                xtraTabbedMdiManager1.MdiParent = this;
                sf.Show();
                sf.BringToFront();
                sf.FormClosed += Sf_FormClosed;
            }
            else if (sf != null)
            {
                sf.BringToFront();
            }
            else
            {
                sf.Activate();
            }
        }

        DepartmentFrom df;
        private void NBDepartment_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Department
            if (df == null)
            {
                df = new DepartmentFrom();
                df.MdiParent = this;
                df.Show();
                df.BringToFront();
                df.FormClosed += Df_FormClosed;
            }
            else if (df != null)
            {
                df.BringToFront();
            }
            else
            {
                df.Activate();
            }
        }

        private void Df_FormClosed(object sender, FormClosedEventArgs e)
        {
            df = null;
        }

        SectionForm sf;
        private void NBSection_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Section
            if (sf == null)
            {

                sf = new SectionForm();
                sf.MdiParent = this;
                sf.Show();
                sf.BringToFront();
                sf.FormClosed += Sf_FormClosed;
            }
            else if (sf != null)
            {
                sf.BringToFront();
            }
            else
            {
                sf.Activate();
            }
        }

        private void Sf_FormClosed(object sender, FormClosedEventArgs e)
        {
            sf = null;
        }

        SubsectionForm ssf;
        private void NBSubsection_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (ssf == null)
            {

                ssf = new SubsectionForm();
                ssf.MdiParent = this;
                ssf.Show();
                ssf.BringToFront();
                ssf.FormClosed += Ssf_FormClosed;
            }
            else if (ssf != null)
            {
                ssf.BringToFront();
            }
            else
            {
                ssf.Activate();
            }
        }

        private void Ssf_FormClosed(object sender, FormClosedEventArgs e)
        {
            ssf = null;
        }

        DesignationForm desigf;
        private void NBDesignations_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Designations
            if (desigf == null)
            {
                desigf = new DesignationForm();
                desigf.MdiParent = this;
                desigf.Show();
                desigf.BringToFront();
                desigf.FormClosed += Desigf_FormClosed;
            }
            else if (desigf != null)
            {
                desigf.BringToFront();
            }
            else
            {
                desigf.Activate();
            }
        }

        private void Desigf_FormClosed(object sender, FormClosedEventArgs e)
        {
            desigf = null;
        }

        ShiftForm shiftf;
        private void NBShifts_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //shifts
            if (shiftf == null)
            {
                shiftf = new ShiftForm();
                shiftf.MdiParent = this;
                shiftf.Show();
                shiftf.BringToFront();
                shiftf.FormClosed += Shiftf_FormClosed;
            }
            else if (shiftf != null)
            {
                shiftf.BringToFront();
            }
            else
            {
                shiftf.Activate();
            }
        }

        private void Shiftf_FormClosed(object sender, FormClosedEventArgs e)
        {
            shiftf = null;
        }

        EmployeeForm ef;
        private void NBEmploye_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Employee
            if (ef == null)
            {
                ef = new EmployeeForm();
                ef.MdiParent = this;
                ef.Show();
                ef.BringToFront();
                ef.FormClosed += Ef_FormClosed;
            }
            else if (ef != null)
            {
                ef.BringToFront();
            }
            else
            {
                ef.Activate();
            }
        }

        private void Ef_FormClosed(object sender, FormClosedEventArgs e)
        {
            ef = null;
        }

        LeaveForm lf;
        private void NBLeave_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Leave
            if (lf == null)
            {

                lf = new LeaveForm();
                lf.MdiParent = this;
                lf.Show();
                lf.BringToFront();
                lf.FormClosed += Lf_FormClosed;
            }
            else if (lf != null)
            {
                lf.BringToFront();
            }
            else
            {
                lf.Activate();
            }
        }

        private void Lf_FormClosed(object sender, FormClosedEventArgs e)
        {
            lf = null;
        }

        IncrementForm incf;
        private void NBIncrement_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (incf == null)
            {
                incf = new IncrementForm();
                incf.MdiParent = this;
                incf.Show();
                incf.BringToFront();
                incf.FormClosed += Incf_FormClosed;
            }
            else if (incf != null)
            {
                incf.BringToFront();
            }
            else
            {
                incf.Activate();
            }
        }

        private void Incf_FormClosed(object sender, FormClosedEventArgs e)
        {
            incf = null;
        }

        LeaveBalanceForm lbf;
        private void NBLeaveBalance_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            if (lbf == null)
            {
                lbf = new LeaveBalanceForm();
                lbf.MdiParent = this;
                lbf.Show();
                lbf.BringToFront();
                lbf.FormClosed += Lbf_FormClosed;
            }
            else if (lbf != null)
            {
                lbf.BringToFront();
            }
            else
            {
                lbf.Activate();
            }
        }

        private void Lbf_FormClosed(object sender, FormClosedEventArgs e)
        {
            lbf = null;
        }

        
        private void NBSalary_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Salary form will be here
        }

        BonusForm bonusf;
        private void NBBonus_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //BonusForm
            if (bonusf == null)
            {
                bonusf = new BonusForm();
                bonusf.MdiParent = this;
                bonusf.Show();
                bonusf.BringToFront();
                bonusf.FormClosed += Bonusf_FormClosed;
            }
            else if (bonusf != null)
            {
                bonusf.BringToFront();
            }
            else
            {
                bonusf.Activate();
            }
        }

        private void Bonusf_FormClosed(object sender, FormClosedEventArgs e)
        {
            bonusf = null;
        }

        AttendanceForm attendancef;
        private void NBAttendance_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (attendancef == null)
            {

                attendancef = new AttendanceForm();
                attendancef.MdiParent = this;
                attendancef.Show();
                attendancef.BringToFront();
                attendancef.FormClosed += Attendancef_FormClosed;
            }
            else if (attendancef != null)
            {
                attendancef.BringToFront();
            }
            else
            {
                attendancef.Activate();
            }

        }

        private void Attendancef_FormClosed(object sender, FormClosedEventArgs e)
        {
            attendancef = null;
        }

   
        private void NBHoliday_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
        }

        private void Hf_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        
        private void NBExtraTime_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Extra Time
        }

        Level1Form l1f;

        private void nbLevel1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            // Level 1
            if (l1f == null)
            {

                l1f = new Level1Form();
                l1f.MdiParent = this;
                l1f.Show();
                l1f.BringToFront();
                l1f.FormClosed += L1f_FormClosed;
            }
            else if (l1f != null)
            {
                l1f.BringToFront();
            }
            else
            {
                l1f.Activate();
            }
        }

        private void L1f_FormClosed(object sender, FormClosedEventArgs e)
        {
            l1f = null;
        }

        Level2Form l2f;
        private void NBLevel2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            // Level 2

            if (l2f == null)
            {

                l2f = new Level2Form();
                l2f.MdiParent = this;
                l2f.Show();
                l2f.BringToFront();
                l2f.FormClosed += L2f_FormClosed;
            }
            else if (l2f != null)
            {
                l2f.BringToFront();
            }
            else
            {
                l2f.Activate();
            }
        }

        private void L2f_FormClosed(object sender, FormClosedEventArgs e)
        {
            l2f = null;
        }

        Level3Form l3f;
        private void nbLevel3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            // Level 3

            if (l3f == null)
            {

                l3f = new Level3Form();
                l3f.MdiParent = this;
                l3f.Show();
                l3f.BringToFront();
                l3f.FormClosed += L3f_FormClosed;
            }
            else if (l3f != null)
            {
                l3f.BringToFront();
            }
            else
            {
                l3f.Activate();
            }
        }

        private void L3f_FormClosed(object sender, FormClosedEventArgs e)
        {
            l3f = null;
        }

        Level4Form l4f;

        private void nbLevel4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            // Level 4
            if (l4f == null)
            {

                l4f = new Level4Form();
                l4f.MdiParent = this;
                l4f.Show();
                l4f.BringToFront();
                l4f.FormClosed += L4f_FormClosed;
            }
            else if (l4f != null)
            {
                l4f.BringToFront();
            }
            else
            {
                l4f.Activate();
            }
        }

        private void L4f_FormClosed(object sender, FormClosedEventArgs e)
        {
            l4f = null;
        }

        InvoicesForm gle;
        private void nbGLEnteries_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {// Level 4
            if (gle == null)
            {

                gle = new InvoicesForm();
                gle.MdiParent = this;
                gle.Show();
                gle.BringToFront();
                gle.FormClosed += Gle_FormClosed;
            }
            else if (gle != null)
            {
                gle.BringToFront();
            }
            else
            {
                gle.Activate();
            }

        }

        private void Gle_FormClosed(object sender, FormClosedEventArgs e)
        {
            gle = null;
        }

        
        

        private void Gli_FormClosed(object sender, FormClosedEventArgs e)
        {
            gli = null;
        }
        BankForm bnf;
        private void nbBank_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (bnf == null)
            {

                bnf = new BankForm();
                bnf.MdiParent = this;
                bnf.Show();
                bnf.BringToFront();
                bnf.FormClosed += Bnf_FormClosed;
            }
            else if (bnf != null)
            {
                bnf.BringToFront();
            }
            else
            {
                bnf.Activate();
            }
        }

        private void Bnf_FormClosed(object sender, FormClosedEventArgs e)
        {
            bnf = null;
        }

        SellersForm sef;
        private void nbSuppliers_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            if (sef == null)
            {

                sef = new SellersForm();
                sef.MdiParent = this;
                sef.Show();
                sef.BringToFront();
                sef.FormClosed += Sef_FormClosed;
            }
            else if (sef != null)
            {
                sef.BringToFront();
            }
            else
            {
                sef.Activate();
            }
        }

        private void Sef_FormClosed(object sender, FormClosedEventArgs e)
        {
            sef = null;
        }

        CustomersForm csF;
        private void nbCustomers_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (csF == null)
            {

                csF = new CustomersForm();
                csF.MdiParent = this;
                csF.Show();
                csF.BringToFront();
                csF.FormClosed += CsF_FormClosed;
            }
            else if (csF != null)
            {
                csF.BringToFront();
            }
            else
            {
                csF.Activate();
            }
        }

        private void CsF_FormClosed(object sender, FormClosedEventArgs e)
        {
            csF = null;
        }
        VoucherInventoryForm gli;
        private void nbVoucher_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (gli == null)
            {
                gli = new VoucherInventoryForm();
                gli.MdiParent = this;
                gli.Show();
                gli.BringToFront();
                gli.FormClosed += Gli_FormClosed1;
            }
            else if (gli != null)
            {
                gli.BringToFront();
            }
            else
            {
                gli.Activate();
            }
        }

        private void Gli_FormClosed1(object sender, FormClosedEventArgs e)
        {
            gli = null;
        }

        GatePassForm gpf;

        private void nbGatePass_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (gpf == null)
            {
                gpf = new GatePassForm();
                gpf.MdiParent = this;
                gpf.Show();
                gpf.BringToFront();
                gpf.FormClosed += Gpf_FormClosed;
            }
            else if (gpf != null)
            {
                gpf.BringToFront();
            }
            else
            {
                gpf.Activate();
            }
        }

        private void Gpf_FormClosed(object sender, FormClosedEventArgs e)
        {
            gpf = null;
        }

        StockxForm stf;
        private void nbStock_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (stf == null)
            {
                stf = new StockxForm();
                stf.MdiParent = this;
                stf.Show();
                stf.BringToFront();
                stf.FormClosed += Stf_FormClosed2;
            }
            else if (stf != null)
            {
                stf.BringToFront();
            }
            else
            {
                stf.Activate();
            }
        }

        private void Stf_FormClosed2(object sender, FormClosedEventArgs e)
        {
            stf = null;
        }



        ProductsForm productF;
        private void nbProducts_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (productF == null)
            {
                productF = new ProductsForm();
                productF.MdiParent = this;
                productF.Show();
                productF.BringToFront();
                productF.FormClosed += ProductF_FormClosed;
            }
            else if (productF != null)
            {
                productF.BringToFront();
            }
            else
            {
                productF.Activate();
            }
        }

        private void ProductF_FormClosed(object sender, FormClosedEventArgs e)
        {
            productF = null;
        }

        ProductUnitForm unitF;
        private void nbUnits_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (unitF == null)
            {
                unitF = new ProductUnitForm();
                unitF.MdiParent = this;
                unitF.Show();
                unitF.BringToFront();
                unitF.FormClosed += UnitF_FormClosed;
            }
            else if (unitF != null)
            {
                unitF.BringToFront();
            }
            else
            {
                unitF.Activate();
            }
        }

        private void UnitF_FormClosed(object sender, FormClosedEventArgs e)
        {
            unitF = null; 
        }

        StoresForm storeF;
        private void nbStores_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (storeF == null)
            {
                storeF = new StoresForm();
                storeF.MdiParent = this;
                storeF.Show();
                storeF.BringToFront();
                storeF.FormClosed += StoreF_FormClosed;
            }
            else if (storeF != null)
            {
                storeF.BringToFront();
            }
            else
            {
                storeF.Activate();
            }
        }

        private void StoreF_FormClosed(object sender, FormClosedEventArgs e)
        {
            storeF = null;
        }

        BinsForm binsF;
        private void nbBins_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (binsF == null)
            {
                binsF = new BinsForm();
                binsF.MdiParent = this;
                binsF.Show();
                binsF.BringToFront();
                binsF.FormClosed += BinsF_FormClosed;
            }
            else if (binsF != null)
            {
                binsF.BringToFront();
            }
            else
            {
                binsF.Activate();
            }
        }

        private void BinsF_FormClosed(object sender, FormClosedEventArgs e)
        {
            binsF = null;
        }

        JVEnteriesForm inf;
        private void nbEnteries_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (inf == null)
            {
                inf = new JVEnteriesForm();
                inf.MdiParent = this;
                inf.Show();
                inf.BringToFront();
                inf.FormClosed += Inf_FormClosed1;
            }
            else if (inf != null)
            {
                inf.BringToFront();
            }
            else
            {
                inf.Activate();
            }
        }

        private void Inf_FormClosed1(object sender, FormClosedEventArgs e)
        {
            inf = null;
        }

        private void Inf_FormClosed(object sender, FormClosedEventArgs e)
        {
            inf = null;
        }

        Level5Form l5f;
        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (l5f == null)
            {
                l5f = new Level5Form();
                l5f.MdiParent = this;
                l5f.Show();
                l5f.BringToFront();
                l5f.FormClosed += L5f_FormClosed;
            }
            else if (l5f != null)
            {
                l5f.BringToFront();
            }
            else
            {
                l5f.Activate();
            }
        }

        private void L5f_FormClosed(object sender, FormClosedEventArgs e)
        {
            l5f = null;
        }
        #region PPOverView
        PPOverViewAll pof;
        private void NB_ATMS_ALL_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (pof == null)
            {
                pof = new PPOverViewAll();
                pof.MdiParent = this;
                pof.Show();
                pof.BringToFront();
                pof.FormClosed += Pof_FormClosed;
            }
            else if (pof != null)
            {
                pof.BringToFront();
            }
            else
            {
                pof.Activate();
            }
        }

        private void Pof_FormClosed(object sender, FormClosedEventArgs e)
        {
            pof = null;
        }

        SamplingReportForm spf;
        public void NB_ATMS_Sampling_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (spf == null)
                {
                    spf = new SamplingReportForm();
                    spf.MdiParent = this;
                    spf.Show();
                    spf.BringToFront();
                    spf.FormClosed += Spf_FormClosed;
                }
                else if (spf != null)
                {
                    spf.BringToFront();
                }
                else
                {
                    spf.Activate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }

        private void Spf_FormClosed(object sender, FormClosedEventArgs e)
        {
            spf = null;
        }

        ProductionReportForm prf;
        private void NB_ATMS_Production_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (prf == null)
            {
                prf = new ProductionReportForm();
                prf.MdiParent = this;
                prf.Show();
                prf.BringToFront();
                prf.FormClosed += Prf_FormClosed;
            }
            else if (prf != null)
            {
                prf.BringToFront();
            }
            else
            {
                prf.Activate();
            }
        }

        private void Prf_FormClosed(object sender, FormClosedEventArgs e)
        {
            prf = null;

        }

        CancelReportForm crf;
        private void NB_ATMS_Cancel_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (crf == null)
            {
                crf = new CancelReportForm();
                crf.MdiParent = this;
                crf.Show();
                crf.BringToFront();
                crf.FormClosed += Crf_FormClosed;
            }
            else if (crf != null)
            {
                crf.BringToFront();
            }
            else
            {
                crf.Activate();
            }
        }

        private void Crf_FormClosed(object sender, FormClosedEventArgs e)
        {
            crf = null;
        }

        ShipReportForm sprf;
        private void NB_ATMS_Shipped_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (sprf == null)
            {
                sprf = new ShipReportForm();
                sprf.MdiParent = this;
                sprf.Show();
                sprf.BringToFront();
                sprf.FormClosed += Sprf_FormClosed;
            }
            else if (sprf != null)
            {
                sprf.BringToFront();
            }
            else
            {
                sprf.Activate();
            }
        }

        private void Sprf_FormClosed(object sender, FormClosedEventArgs e)
        {
            sprf = null;
        }

        WareHouseReportForm wrf;
        private void NB_ATMS_Warehouse_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (wrf == null)
            {
                wrf = new WareHouseReportForm();
                wrf.MdiParent = this;
                wrf.Show();
                wrf.BringToFront();
                wrf.FormClosed += Wrf_FormClosed;
            }
            else if (wrf != null)
            {
                wrf.BringToFront();
            }
            else
            {
                wrf.Activate();
            }
        }

        private void Wrf_FormClosed(object sender, FormClosedEventArgs e)
        {
            wrf = null;
        }
        #endregion
        #region ClientsDefine
        ClientForm clf;
        private void NB_ATMS_DefineClients_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (clf == null)
            {
                clf = new ClientForm();
                clf.MdiParent = this;
                clf.Show();
                clf.BringToFront();
                clf.FormClosed += Clf_FormClosed;
            }
            else if (clf != null)
            {
                clf.BringToFront();
            }
            else
            {
                clf.Activate();
            }
        }

        private void Clf_FormClosed(object sender, FormClosedEventArgs e)
        {
            clf = null;
        }


        #endregion
        #region Articles
        ArticlesForm artf;
        public void NB_ATMS_ArticleDefine_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (artf == null)
            {
                artf = new ArticlesForm();
                artf.MdiParent = this;
                artf.Show();
                artf.BringToFront();
                artf.FormClosed += Artf_FormClosed;
            }
            else if (artf != null)
            {
                artf.BringToFront();
            }
            else
            {
                artf.Activate();
            }
        }

        private void Artf_FormClosed(object sender, FormClosedEventArgs e)
        {
            artf = null;
        }
        ArticleList articlLis;
        private void NB_ATMS_ListArticle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (articlLis == null)
            {
                articlLis = new ArticleList();
                articlLis.MdiParent = this;
                articlLis.Show();
                articlLis.BringToFront();
                articlLis.FormClosed += ArticlLis_FormClosed;
            }
            else if (articlLis != null)
            {
                articlLis.BringToFront();
            }
            else
            {
                articlLis.Activate();
            }
        }

        private void ArticlLis_FormClosed(object sender, FormClosedEventArgs e)
        {
            articlLis = null;
        }



        #endregion
        #region DefineATMS
        ColorsForm clrf;
        private void NB_ATMS_COLORS_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (clrf == null)
            {
                clrf = new ColorsForm();
                clrf.MdiParent = this;
                clrf.Show();
                clrf.BringToFront();
                clrf.FormClosed += Clrf_FormClosed1;
            }
            else if (clrf != null)
            {
                clrf.BringToFront();
            }
            else
            {
                clrf.Activate();
            }
        }

        private void Clrf_FormClosed1(object sender, FormClosedEventArgs e)
        {
            clrf = null;
        }

        SizesForm sizeF;
        private void NB_ATMS_SIZE_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (sizeF == null)
            {
                sizeF = new SizesForm();
                sizeF.MdiParent = this;
                sizeF.Show();
                sizeF.BringToFront();
                sizeF.FormClosed += SizeF_FormClosed;
            }
            else if (sizeF != null)
            {
                sizeF.BringToFront();
            }
            else
            {
                sizeF.Activate();
            }
        }

        private void SizeF_FormClosed(object sender, FormClosedEventArgs e)
        {
            sizeF = null;
        }
        GenderForm genderfor;
        private void NB_ATMS_GENDER_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (genderfor == null)
            {
                genderfor = new GenderForm();
                genderfor.MdiParent = this;
                genderfor.Show();
                genderfor.BringToFront();
                genderfor.FormClosed += Genderfor_FormClosed;
            }
            else if (genderfor != null)
            {
                genderfor.BringToFront();
            }
            else
            {
                genderfor.Activate();
            }
        }

        private void Genderfor_FormClosed(object sender, FormClosedEventArgs e)
        {
            genderfor = null;
        }

        CurrencyForm currencyFor;
        private void NB_ATMS_CURRENCY_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (currencyFor == null)
            {
                currencyFor = new CurrencyForm();
                currencyFor.MdiParent = this;
                currencyFor.Show();
                currencyFor.BringToFront();
                currencyFor.FormClosed += CurrencyFor_FormClosed;
            }
            else if (currencyFor != null)
            {
                currencyFor.BringToFront();
            }
            else
            {
                currencyFor.Activate();
            }
        }

        private void CurrencyFor_FormClosed(object sender, FormClosedEventArgs e)
        {
            currencyFor = null;
        }

        BrandForm brandfor;
        private void NB_ATMS_BRAND_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (brandfor == null)
            {
                brandfor = new BrandForm();
                brandfor.MdiParent = this;
                brandfor.Show();
                brandfor.BringToFront();
                brandfor.FormClosed += Brandfor_FormClosed;
            }
            else if (brandfor != null)
            {
                brandfor.BringToFront();
            }
            else
            {
                brandfor.Activate();
            }
        }

        private void Brandfor_FormClosed(object sender, FormClosedEventArgs e)
        {
            brandfor = null;
        }

        SeasonForm seasonFor;
        private void NB_ATMS_SEASON_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (seasonFor == null)
            {
                seasonFor = new SeasonForm();
                seasonFor.MdiParent = this;
                seasonFor.Show();
                seasonFor.BringToFront();
                seasonFor.FormClosed += SeasonFor_FormClosed;
            }
            else if (seasonFor != null)
            {
                seasonFor.BringToFront();
            }
            else
            {
                seasonFor.Activate();
            }
        }

        private void SeasonFor_FormClosed(object sender, FormClosedEventArgs e)
        {
            seasonFor = null;
        }

        StatusCategoryForm stCatf;
        private void NB_ATMS_STATUS_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (stCatf == null)
            {
                stCatf = new StatusCategoryForm();
                stCatf.MdiParent = this;
                stCatf.Show();
                stCatf.BringToFront();
                stCatf.FormClosed += StCatf_FormClosed;
            }
            else if (stCatf != null)
            {
                stCatf.BringToFront();
            }
            else
            {
                stCatf.Activate();
            }
        }

        private void StCatf_FormClosed(object sender, FormClosedEventArgs e)
        {
            stCatf = null;
        }
        #endregion

        PurchaseOrderForm poform;
        public void NB_PO_DEFINE_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (poform == null)
            {
                poform = new PurchaseOrderForm();
                poform.MdiParent = this;
                poform.Show();
                poform.BringToFront();
                poform.FormClosed += Poform_FormClosed;
            }
            else if (poform != null)
            {
                poform.BringToFront();
            }
            else
            {
                poform.Activate();
            }
        }

        private void Poform_FormClosed(object sender, FormClosedEventArgs e)
        {
            poform=null;
        }
        internal void NB_PO_DEFINE_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                if (poform == null)
                {
                    poform = new PurchaseOrderForm();
                    poform.MdiParent= this;
                    poform.Show();
                    poform.BringToFront();
                    poform.FormClosed += Poform_FormClosed;
                }
                else if (poform != null)
                {
                    poform.BringToFront();
                }
                else
                {
                    poform.Activate();
                }

                //NB_PO_DEFINE_LinkClicked(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        StatusUpdateForm stp;
        private void STUpdate_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (stp == null)
            {
                stp = new StatusUpdateForm();
                stp.MdiParent = this;
                stp.Show();
                stp.BringToFront();
                stp.FormClosed += Stp_FormClosed;
            }
            else if (stp != null)
            {
                stp.BringToFront();
            }
            else
            {
                stp.Activate();
            }
        }

        private void Stp_FormClosed(object sender, FormClosedEventArgs e)
        {
            stp = null;
        }
    }
}

