using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Modelx;

namespace JTex.Forms.Accounts
{
    public partial class Level1Form : Form
    {
        public Level1Form()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();      
        ADOEntityModel amObj = new ADOEntityModel();
        Modelx.Level1 lObj = new Modelx.Level1();
        private void Level1Selection()
        {
           
        }
        private bool Validations()
        {
            bool isSuccess = false;
                if (L1_IDTextEdit.Text != "")
                    if (NameTextEdit.Text != "")
                        isSuccess = true;
                    else
                        isSuccess = false;
            return isSuccess;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(Validations())
            {
                lObj.L1_ID = Convert.ToInt32(L1_IDTextEdit.Text.Trim());
                lObj.Name = NameTextEdit.Text.Trim();
                using (var myDbEntities = new ADOEntityModel())
                {
                    myDbEntities.Level1.Add(lObj);
                    myDbEntities.SaveChanges();
                }
                popGrid();
            }
            else
            {
                MessageBox.Show("Please fill data in all fields...");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (Validations())
            {
                lObj.L1_ID = Convert.ToInt32(L1_IDTextEdit.Text.Trim());
                lObj.Name = NameTextEdit.Text.Trim();
                using (var myDbEntities = new ADOEntityModel())
                {
                    myDbEntities.Entry(lObj).State = System.Data.Entity.EntityState.Modified;
                    myDbEntities.SaveChanges();
                }
                popGrid();
            }
            else
            {
                MessageBox.Show("Please fill data in all fields...");
            }
           
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            lObj.L1_ID= Convert.ToInt32(L1_IDTextEdit.Text.Trim());
            if(L1_IDTextEdit.Text!="")
            {
                using (var myDbEntities = new ADOEntityModel())
                {
                    var entery = myDbEntities.Entry(lObj);
                    if (entery.State == System.Data.Entity.EntityState.Detached)
                    {
                        myDbEntities.Level1.Attach(lObj);
                        myDbEntities.Level1.Remove(lObj);
                        myDbEntities.SaveChanges();
                    }
                }
                popGrid();
            }
            else
            {
                MessageBox.Show("Please enter Level 1 code...");
            }
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            
        }
        private void Level1Form_Load(object sender, EventArgs e)
        {
            try
            {
                Popp();
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }   
        }
        
        private void popGrid()
        {
            using (var myModel = new ADOEntityModel())
            {
                
                gridControl1.DataSource = myModel.Level1.ToList(); 
            }
        }
        
        private void Popp()
        {
            gridControl1.DataSource = lObj.GetDepartments();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                L1_IDTextEdit.Text = gridView1.GetFocusedRowCellValue("L1_ID").ToString().Trim();
                NameTextEdit.Text = gridView1.GetFocusedRowCellValue("Name").ToString().Trim();
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }
    }
}
