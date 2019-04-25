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


namespace JTex.Forms.Accounts
{
    public partial class SellersForm : Form
    {
        public SellersForm()
        {
            InitializeComponent();
            //popGrid();
        }
        DataTable dt = new DataTable();
        Modelx.ADOEntityModel amObj = new Modelx.ADOEntityModel();
        Modelx.Supplier sObj = new Modelx.Supplier();
        private void SupplierSelection()
        {
          
        }
        private void SellersForm_Load(object sender, EventArgs e)
        {
            popGrid();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int SupplierID = Convert.ToInt32(SupplierTextE.Text.Trim());
                string Name = NameTextE.Text.Trim();
                string Category = CategoryTextE.Text.Trim();
                string Address = AddressTextE.Text.Trim();
                string ContactPerson = ContactPersonTextE.Text.Trim();
                string PhoneNumber = PhoneNumberTextE.Text.Trim();
                string Email = EmailTextE.Text.Trim();
                using (var myDbEntities = new Modelx.ADOEntityModel())
                {
                    var ninjas = myDbEntities.Database.ExecuteSqlCommand("EXEC SupplierUpdation {0},{1},{2},{3},{4},{5},{6}", SupplierID, Name, Category, Address, ContactPerson, PhoneNumber, Email);
                }
                popGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
           try
            {
                int SupplierID = Convert.ToInt32(SupplierTextE.Text.Trim());
                using (var myDbEntities = new Modelx.ADOEntityModel())
                {
                    var ninjas = myDbEntities.Database.ExecuteSqlCommand("EXEC SupplierDeletion {0}", SupplierID);
                }
                popGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception"+ex);
            }
        }
        public void popGrid()
        {
            using (var myModel = new Modelx.ADOEntityModel())
            {
                gridControl1.DataSource = myModel.Suppliers.ToList();
            }
        }
       
         private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int AccountID = Convert.ToInt32(AccountIDLookUpEdit.Text.Trim());
                string Name = NameTextE.Text.Trim();
                string Category = CategoryTextE.Text.Trim();
                string Address = AddressTextE.Text.Trim();
                string ContactPerson = ContactPersonTextE.Text.Trim();
                string PhoneNumber = PhoneNumberTextE.Text.Trim();
                string Email = EmailTextE.Text.Trim();
                using (var myDbEntities = new Modelx.ADOEntityModel())
                {
                    var ninjas = myDbEntities.Database.ExecuteSqlCommand("EXEC SuppliersCreation {0},{1},{2},{3},{4},{5},{6}", AccountID, Name, Category, Address, ContactPerson, PhoneNumber,Email);                   
                }
                popGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }          
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {       
            try
            {
                SupplierTextE.Text = gridView1.GetFocusedRowCellValue("SupplierID").ToString().Trim();
                NameTextE.Text = gridView1.GetFocusedRowCellValue("Name").ToString().Trim();
                CategoryTextE.Text = gridView1.GetFocusedRowCellValue("Category").ToString().Trim();
                AddressTextE.Text = gridView1.GetFocusedRowCellValue("Address").ToString().Trim();
                ContactPersonTextE.Text = gridView1.GetFocusedRowCellValue("ContactPerson").ToString().Trim();
                PhoneNumberTextE.Text = gridView1.GetFocusedRowCellValue("PhoneNumber").ToString().Trim();
                EmailTextE.Text = gridView1.GetFocusedRowCellValue("Email").ToString().Trim();
            }
            catch(Exception ex)
            {
                //MessageBox.Show(""+ex);
            }
        }
    }
}
