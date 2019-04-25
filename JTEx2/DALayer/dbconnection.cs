using BELayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DALayer
{
    public class dbconnection
    {
        static string myconstring = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(myconstring);
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        BEL beObj = new BEL();

        #region Create
        public bool Creation(BEL beObj)
        {
            bool isSuccess = false;
            cmd.Connection = con;
            try
            {
                if (con == null || con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (beObj.Control == "Group")
                {
                    string que = "EXEC GroupCreation @name,@number";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@name", beObj.Name);
                    cmd.Parameters.AddWithValue("@number", beObj.Number);
                }

                else if (beObj.Control == "Company")
                {
                    string que = "EXEC CompanyCreation @GroupID,@name,@ShortName,@NTN,@STN,@Email,@Website";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@GroupID", beObj.GroupID);
                    cmd.Parameters.AddWithValue("@name", beObj.Name);
                    cmd.Parameters.AddWithValue("@ShortName", beObj.ShortName);
                    cmd.Parameters.AddWithValue("@NTN", beObj.NTN);
                    cmd.Parameters.AddWithValue("@STN", beObj.STN);
                    cmd.Parameters.AddWithValue("@Website", beObj.Website);
                    cmd.Parameters.AddWithValue("@Email", beObj.Email);
                }
                else if (beObj.Control == "Branch")
                {
                    string que = "EXEC BranchCreation @CompanyID,@number,@name,@Address,@PhoneNumber,@FaxNumber";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@CompanyID", beObj.CompanyID);
                    cmd.Parameters.AddWithValue("@number", beObj.Number);
                    cmd.Parameters.AddWithValue("@name", beObj.Name);
                    cmd.Parameters.AddWithValue("@Address", beObj.Address);
                    cmd.Parameters.AddWithValue("@PhoneNumber", beObj.PhoneNumber);
                    cmd.Parameters.AddWithValue("@FaxNumber", beObj.FaxNumber);
                }
                else if (beObj.Control == "Unit")
                {
                    string que = "EXEC UnitCreation @BranchID,@number,@name,@Abbrevation";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@BranchID", beObj.BranchID);
                    cmd.Parameters.AddWithValue("@Number", beObj.Number);
                    cmd.Parameters.AddWithValue("@Name", beObj.Name);
                    cmd.Parameters.AddWithValue("@Abbrevation", beObj.Abbrevation);
                }
                else if (beObj.Control == "Department")
                {
                    string que = "EXEC DepartmentCreation @UnitID,@Number,@Name,@Abbrevation";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@UnitID", beObj.UnitID);
                    cmd.Parameters.AddWithValue("@Number", beObj.Number);
                    cmd.Parameters.AddWithValue("@Name", beObj.Name);
                    cmd.Parameters.AddWithValue("@Abbrevation", beObj.Abbrevation);
                }
                else if (beObj.Control == "Section")
                {
                    string que = "EXEC SectionCreate @DepartmentID,@Number,@Name,@Abbrevation";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@DepartmentID", beObj.DepartmentID);
                    cmd.Parameters.AddWithValue("@Number", beObj.Number);
                    cmd.Parameters.AddWithValue("@Name", beObj.Name);
                    cmd.Parameters.AddWithValue("@Abbrevation", beObj.Abbrevation);
                }
                else if (beObj.Control == "Subsection")
                {
                    string que = "EXEC SubsectionCreate @SectionID,@Number,@Name,@Abbrevation";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@SectionID", beObj.SectionID);
                    cmd.Parameters.AddWithValue("@Number", beObj.Number);
                    cmd.Parameters.AddWithValue("@Name", beObj.Name);
                    cmd.Parameters.AddWithValue("@Abbrevation", beObj.Abbrevation);
                }
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                    MessageBox.Show("Fail to insert");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
        public bool CreationHR(BEL beObj)
        {
            bool isSuccess = false;
            cmd.Connection = con;
            try
            {
                if (con == null || con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (beObj.Control == "Bonus")
                {
                    string que = "EXEC BonusCraetion @EmployeeID,@Salary,@Month,@BonusAmount,@Description";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@EmployeeID", beObj.EmoloyeeID);
                    cmd.Parameters.AddWithValue("@Salary", beObj.Salary);
                    cmd.Parameters.AddWithValue("@Month", beObj.currentdate);
                    cmd.Parameters.AddWithValue("@BonusAmount", beObj.Amount);
                    cmd.Parameters.AddWithValue("@Description", beObj.Description);
                }
                else if (beObj.Control == "Designation")
                {
                    string que = "EXEC DesignationCreation @Name,@Number,@Abbrevation";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@Name", beObj.Name);
                    cmd.Parameters.AddWithValue("@Number", beObj.Number);
                    cmd.Parameters.AddWithValue("@Abbrevation", beObj.Abbrevation);

                }
                else if (beObj.Control == "Holiday")
                {
                    string que = "EXEC HolidayCreation @Date,@Description";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@Date", beObj.currentdate);
                    cmd.Parameters.AddWithValue("@Description", beObj.Description);
                }
                else if (beObj.Control == "Increment")
                {
                    string que = "EXEC IncrementCreation @EmployeeID,@Date,@PreviousSalary,@Amount,@Description";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@EmployeeID", beObj.EmoloyeeID);
                    cmd.Parameters.AddWithValue("@Date", beObj.currentdate);
                    cmd.Parameters.AddWithValue("@PreviousSalary", beObj.Salary);
                    cmd.Parameters.AddWithValue("@Amount", beObj.Amount);
                    cmd.Parameters.AddWithValue("@Description", beObj.Description);
                }
                else if (beObj.Control == "Loan")
                {
                    string que = "EXEC LoanCreation @EmployeeID,@Amount,@Partitions,@IssueDate,@RemainingAmount,@Clear";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@EmployeeID", beObj.EmoloyeeID);
                    cmd.Parameters.AddWithValue("@Amount", beObj.Amount);
                    cmd.Parameters.AddWithValue("@Partitions", beObj.Partitions);
                    cmd.Parameters.AddWithValue("@IssueDate", beObj.currentdate);
                    cmd.Parameters.AddWithValue("@RemainingAmount", beObj.RemainingAmount);
                    cmd.Parameters.AddWithValue("@Clear", beObj.Clear);
                }
                else if (beObj.Control == "Leave")
                {
                    string que = "EXEC LeaveCreation @EmployeeID,@ApprovalDate,@FromDate,@ToDate,@Days,@Description";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@EmployeeID", beObj.EmoloyeeID);
                    cmd.Parameters.AddWithValue("@ApprovalDate", beObj.ApprovalDate);
                    cmd.Parameters.AddWithValue("@FromDate", beObj.FromDate);
                    cmd.Parameters.AddWithValue("@ToDate", beObj.ToDate);
                    cmd.Parameters.AddWithValue("@Days", beObj.Days);
                    cmd.Parameters.AddWithValue("@Description", beObj.Description);

                }
                else if (beObj.Control == "LeaveBalance")
                {
                    string que = "EXEC LeaveBalanaceCreation @EmployeeID,@NOL";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@EmployeeID", beObj.EmoloyeeID);
                    cmd.Parameters.AddWithValue("@NOL", beObj.Number);

                }
                else if (beObj.Control == "Attendance")
                {
                    string que = "EXEC AttendanceCreation @EmployeeID,@TimeIn";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@EmployeeID", beObj.EmoloyeeID);
                    cmd.Parameters.AddWithValue("@TimeIn", beObj.currentdate);
                }
                else if (beObj.Control == "Shift")
                {
                    string que = "EXEC ShiftCreation @Name,@Number,@Abbrevation,@StartTime,@EndTime,@RestStartTime,@RestEndTime,@BeforeInTime,@AfterOutTime,@AfterInTime,@BeforeOutTime";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@Name", beObj.Name);
                    cmd.Parameters.AddWithValue("@Number", beObj.Number);
                    cmd.Parameters.AddWithValue("@Abbrevation", beObj.Abbrevation);
                    cmd.Parameters.AddWithValue("@StartTime", beObj.startTime);
                    cmd.Parameters.AddWithValue("@EndTime", beObj.EndTime);
                    cmd.Parameters.AddWithValue("@RestStartTime", beObj.RestStartTime);
                    cmd.Parameters.AddWithValue("@RestEndTime", beObj.RestEndTime);
                    cmd.Parameters.AddWithValue("@BeforeInTime", beObj.BeforeInTime);
                    cmd.Parameters.AddWithValue("@AfterOutTime", beObj.AfterOutTime);
                    cmd.Parameters.AddWithValue("@AfterInTime", beObj.AfterInTime);
                    cmd.Parameters.AddWithValue("@BeforeOutTime", beObj.BeforeOutTime);
                }

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                    MessageBox.Show("Fail to insert");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
        public bool CreationAccounts(BEL beObj)
        {
            bool isSuccess = false;
            cmd.Connection = con;
            try
            {
                if (con == null || con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (beObj.Control == "Level1")
                {
                    string que = "EXEC COALevel1Creation @L1_id,@Name";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@L1_id", beObj.Level1ID);
                    cmd.Parameters.AddWithValue("@Name", beObj.Name);
                }
                else if (beObj.Control == "Level2")
                {
                    string que = "EXEC COALevel2Creation @L2_id,@L1_id,@Name";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@L2_id", beObj.Level2ID);
                    cmd.Parameters.AddWithValue("@L1_id", beObj.Level1ID);
                    cmd.Parameters.AddWithValue("@Name", beObj.Name);

                }
                else if (beObj.Control == "Level3")
                {
                    string que = "EXEC COALevel3Creation @L3_id,@L2_id,@Name";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@L3_id", beObj.Level3ID);
                    cmd.Parameters.AddWithValue("@L2_id", beObj.Level2ID);
                    cmd.Parameters.AddWithValue("@Name", beObj.Name);
                }
                else if (beObj.Control == "Level4")
                {
                    string que = "EXEC COALevel4Creation @L4_id,@L3_id,@Name";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@L4_id", beObj.Level4ID);
                    cmd.Parameters.AddWithValue("@L3_id", beObj.Level3ID);
                    cmd.Parameters.AddWithValue("@Name", beObj.Name);
                }
                else if(beObj.Control=="GL")
                {
                    string que = "EXEC GLCreation @Debit,@Credit,@Amount,@Narration";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@Debit", beObj.Debit);
                    cmd.Parameters.AddWithValue("@Credit", beObj.Credit);
                    cmd.Parameters.AddWithValue("@Amount", beObj.Amount);
                    cmd.Parameters.AddWithValue("@Narration", beObj.Narration);
                    
                }
                else if(beObj.Control=="Voucher")
                {
                    string que = "EXEC VoucherCreation @CompanyID,@BranchID,@UnitID,@DepartmentID,@VoucherNumber,@VoucherType,@Remarks,@Refrence";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@CompanyID", beObj.CompanyID);
                    cmd.Parameters.AddWithValue("@BranchID", beObj.BranchID);
                    cmd.Parameters.AddWithValue("@UnitID", beObj.UnitID);
                    cmd.Parameters.AddWithValue("@DepartmentID", beObj.DepartmentID);
                    cmd.Parameters.AddWithValue("@VoucherNumber", beObj.voucherNumber);
                    cmd.Parameters.AddWithValue("@VoucherType", beObj.VoucherType);
                    cmd.Parameters.AddWithValue("@Remarks", beObj.Remarks);
                    cmd.Parameters.AddWithValue("@Refrence", beObj.Refrence);
                }
                else if(beObj.Control=="Bank")
                {
                    string que = "EXEC BankCreation @AccountID,@Name,@AccountNumber,@IBANNumber,@AccounTitle,@SwiftCode";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@AccountID", beObj.AccountID);
                    cmd.Parameters.AddWithValue("@Name", beObj.Name);
                    cmd.Parameters.AddWithValue("@AccountNumber", beObj.AccountNumber);
                    cmd.Parameters.AddWithValue("@IBANNumber", beObj.IBANNumber);
                    cmd.Parameters.AddWithValue("@AccounTitle", beObj.AccountTitle);
                    cmd.Parameters.AddWithValue("@SwiftCode", beObj.SwiftCode);
                }
                else if(beObj.Control=="Customer")
                {
                    string que = "EXEC CustomerCreation @AccountID,@Name,@Category,@Address,@ContactPerson,@PhoneNumber,@Email";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@AccountID", beObj.AccountID);
                    cmd.Parameters.AddWithValue("@Name", beObj.Name);
                    cmd.Parameters.AddWithValue("@Address", beObj.Address);
                    cmd.Parameters.AddWithValue("@Category", beObj.Category);
                    cmd.Parameters.AddWithValue("@ContactPerson", beObj.Contactperson);
                    cmd.Parameters.AddWithValue("@PhoneNumber", beObj.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Email", beObj.Email);
                }
                else if (beObj.Control == "Supplier")
                {
                    string que = "EXEC SuppliersCreation @AccountID,@Name,Category,@Address,@ContactPerson,@PhoneNumber,@Email";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@AccountID", beObj.AccountID);
                    cmd.Parameters.AddWithValue("@Name", beObj.Name);
                    cmd.Parameters.AddWithValue("@Category", beObj.Category);
                    cmd.Parameters.AddWithValue("@Address", beObj.Address);    
                    cmd.Parameters.AddWithValue("@ContactPerson", beObj.Contactperson);
                    cmd.Parameters.AddWithValue("@PhoneNumber", beObj.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Email", beObj.Email);
                }
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                    MessageBox.Show("Fail to insert");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
        public bool CreationInventory(BEL beObj)
        {
            bool isSuccess = false;
            cmd.Connection = con;
            try
            {
                if (con == null || con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (beObj.Control == "GatePass")
                {
                    string que = "EXEC GatePassCreation @AccountID,@PartyID,@GPNumber,@GPCategory,@DriverName,@VehiclNumber,@Remarks";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@AccountID", beObj.Level4ID);
                    cmd.Parameters.AddWithValue("@PartyID", beObj.SupplierID);
                    cmd.Parameters.AddWithValue("@GPNumber", beObj.GPNumber);
                    cmd.Parameters.AddWithValue("@GPCategory", beObj.Category);
                    cmd.Parameters.AddWithValue("@DriverName", beObj.DriverName);
                    cmd.Parameters.AddWithValue("@VehiclNumber", beObj.VehicleNumber);
                    cmd.Parameters.AddWithValue("@Remarks", beObj.Remarks);
               
                }
                //else if (beObj.Control == "Products")
                //{
                //    string que = "EXEC COALevel2Creation @L2_id,@L1_id,@Name";
                //    cmd = new SqlCommand(que, con);
                //    cmd.Parameters.AddWithValue("@L2_id", beObj.Level2ID);
                //    cmd.Parameters.AddWithValue("@L1_id", beObj.Level1ID);
                //    cmd.Parameters.AddWithValue("@Name", beObj.Name);

                //}
                else if (beObj.Control == "Stores")
                {
                    string que = "EXEC StoreCreation @Name,@Location,@Remarks";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@Name", beObj.Name);
                    cmd.Parameters.AddWithValue("@Location", beObj.Location);
                    cmd.Parameters.AddWithValue("@Remarks", beObj.Remarks);
                }
                else if (beObj.Control == "Bins")
                {
                    string que = "EXEC BinCreation @StoreID,@RackNumber,@RowNumber,@ShelfNumber";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@StoreID", beObj.storeID);
                    cmd.Parameters.AddWithValue("@RackNumber", beObj.RackNumber);
                    cmd.Parameters.AddWithValue("@RowNumber", beObj.RowNumber);
                    cmd.Parameters.AddWithValue("@ShelfNumber", beObj.ShelfNumber);
                }
                else if (beObj.Control == "ProductUnit")
                {
                    string que = "EXEC ProductUnitCreation @Name,@Description";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@Name", beObj.Name);
                    cmd.Parameters.AddWithValue("@Description", beObj.Description);
                  

                }
                else if (beObj.Control == "Stock")
                {
                    string que = "EXEC StockCreation @ProductID,@BinID,@GPID,@EnteryType,@Qty,@Remarks";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@ProductID", beObj.ProductID);
                    cmd.Parameters.AddWithValue("@BinID", beObj.BinID);
                    cmd.Parameters.AddWithValue("@GPID", beObj.GatePassID);
                    cmd.Parameters.AddWithValue("@EnteryType", beObj.EnteryType);
                    cmd.Parameters.AddWithValue("@Qty", beObj.Quantity);
                    cmd.Parameters.AddWithValue("@Remarks", beObj.Remarks);
                }
              
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                    MessageBox.Show("Fail to insert");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
        #endregion

        #region Delete
        public bool Deletion(BEL beObj)
        {
            int rows;
            bool isSuccess = false;
            try
            {
                cmd.Connection = con;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;


                if (beObj.Control == "Group")
                {
                    cmd.CommandText = "GroupDeletion";
                    cmd.Parameters.AddWithValue("@GroupID", beObj.GroupID);
                }
                else if (beObj.Control == "Company")
                {
                    cmd.CommandText = "CompanyDeletion";
                    cmd.Parameters.AddWithValue("@CompanyID", beObj.CompanyID);
                }
                else if (beObj.Control == "Branch")
                {
                    string que = "EXEC BranchDeletion @BranchID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@BranchID", beObj.BranchID);
                }
                else if (beObj.Control == "Unit")
                {
                    string que = "EXEC UnitDeletion @UnitID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@UnitID", beObj.UnitID);
                }
                else if (beObj.Control == "Department")
                {
                    string que = "EXEC DepartmentDeletion @DepartmentID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@DepartmentID", beObj.DepartmentID);
                }
                else if (beObj.Control == "Section")
                {
                    string que = "EXEC SectionDeletion @SectionID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@SectionID", beObj.SectionID);
                }
                else if (beObj.Control == "Subsection")
                {
                    string que = "EXEC SubsectionDeletion @SubsectionID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@SubsectionID", beObj.SubsectionID);
                }

                rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Deleted successfuly....");
                    isSuccess = true;
                }
                else
                {
                    MessageBox.Show("Failed to delete...");
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
            return isSuccess;
        }
        public bool HRDeletion(BEL beObj)
        {
            int rows;
            bool isSuccess = false;
            try
            {
                cmd.Connection = con;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;


                if (beObj.Control == "Bonus")
                {
                    string que = "EXEC BonusDeletion @BonusID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@BonusID", beObj.BonuseID);
                }
                else if (beObj.Control == "Designation")
                {
                    string que = "EXEC DesignationDeletion @DesignationID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@DesignationID", beObj.DesignationID);
                }
                else if (beObj.Control == "Holiday")
                {
                    string que = "EXEC HolidayDeletion @HolidayID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@HolidayID", beObj.HolidayID);

                }
                else if (beObj.Control == "Increment")
                {
                    string que = "EXEC IncrementDeletion @IncrementID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@IncrementID", beObj.incrementID);

                }
                else if (beObj.Control == "Leave")
                {
                    string que= "EXEC LeaveDeletion @LeaveID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@LeaveID", beObj.LeaveID);
                }
                else if(beObj.Control=="Loan")
                {
                    string que = "EXEC LaonDeletion @LoanID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@LoanID", beObj.LoanID);
                }
                else if (beObj.Control == "LeaveBalance")
                {
                   //To be implement

                }
                else if (beObj.Control == "Shift")
                {
                    string que = "EXEC ShiftDeletion @ShiftID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@ShiftID", beObj.ShiftID);
                }


                rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Deleted successfuly....");
                    isSuccess = true;
                }
                else
                {
                    MessageBox.Show("Failed to delete...");
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
            return isSuccess;
        }
        public bool AccountsDeletion(BEL beObj)
        {
            int rows;
            bool isSuccess = false;
            try
            {
                cmd.Connection = con;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;


                if (beObj.Control == "Level1")
                {
                    string que = "EXEC COALevel1Deletion @Level1ID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@Level1ID", beObj.Level1ID);
                }
                else if (beObj.Control == "Level2")
                {
                    string que = "EXEC COALevel2Deletion @L2_id";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@L2_id", beObj.Level2ID);
                }
                else if (beObj.Control == "Level3")
                {
                    string que = "EXEC COALevel3Deletion @L3_id";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@L3_id", beObj.Level3ID);

                }
                else if (beObj.Control == "Level4")
                {
                    string que = "EXEC COALevel4Deletion @L4_id";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@L4_id", beObj.Level4ID);

                }
                else if(beObj.Control=="Bank")
                {
                    string que = "EXEC BankDeletion @BankID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@BankID", beObj.BankID);
                }
                else if(beObj.Control=="Voucher")
                {
                    string que = "EXEC VoucherDeletion @VoucherID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@VoucherID", beObj.voucherID);
                }
                else if (beObj.Control == "Customer")
                {
                    string que = "EXEC CustomerDeletion @CustomerID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@CustomerID", beObj.CustomerID);
                }
                else if (beObj.Control == "Supplier")
                {
                    string que = "EXEC SupplierDeletion @SupplierID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@SupplierID", beObj.SupplierID);
                }
                rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Deleted successfuly....");
                    isSuccess = true;
                }
                else
                {
                    MessageBox.Show("Failed to delete...");
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
            return isSuccess;
        }
        public bool inventoryDeletion(BEL beObj)
        {
            int rows;
            bool isSuccess = false;
            try
            {
                cmd.Connection = con;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;


                if (beObj.Control == "GatePass")
                {
                    cmd.CommandText = "GroupDeletion";
                    cmd.Parameters.AddWithValue("@GroupID", beObj.GroupID);
                }
                else if (beObj.Control == "Products")
                {
                    cmd.CommandText = "CompanyDeletion";
                    cmd.Parameters.AddWithValue("@CompanyID", beObj.CompanyID);
                }
                else if (beObj.Control == "Stores")
                {
                    string que = "EXEC BranchDeletion @BranchID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@BranchID", beObj.BranchID);
                }
                else if (beObj.Control == "Bins")
                {
                    string que = "EXEC UnitDeletion @UnitID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@UnitID", beObj.UnitID);
                }
                else if (beObj.Control == "ProductUnit")
                {
                    string que = "EXEC DepartmentDeletion @DepartmentID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@DepartmentID", beObj.DepartmentID);
                }
                else if (beObj.Control == "Stock")
                {
                    string que = "EXEC SectionDeletion @SectionID";
                    cmd = new SqlCommand(que, con);
                    cmd.Parameters.AddWithValue("@SectionID", beObj.SectionID);
                }


                rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Deleted successfuly....");
                    isSuccess = true;
                }
                else
                {
                    MessageBox.Show("Failed to delete...");
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
            return isSuccess;
        }
        #endregion

        #region Update
        public int Updation(BEL beObj)
        {
            int rows;
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;


            if (beObj.Control == "Group")
            {
                cmd.CommandText = "GroupUpdation";
                cmd.Parameters.AddWithValue("@GroupID", beObj.GroupID);
                cmd.Parameters.AddWithValue("@name", beObj.Name);
                cmd.Parameters.AddWithValue("@number", beObj.Number);
            }
            else if (beObj.Control == "Company")
            {
                cmd.CommandText = "CompanyUpdation";
                cmd.Parameters.AddWithValue("@CompanyID", beObj.CompanyID);
                cmd.Parameters.AddWithValue("@GroupID", beObj.GroupID);
                cmd.Parameters.AddWithValue("@name", beObj.Name);
                cmd.Parameters.AddWithValue("@ShortName", beObj.ShortName);
                cmd.Parameters.AddWithValue("@NTN", beObj.NTN);
                cmd.Parameters.AddWithValue("@STN", beObj.STN);
                cmd.Parameters.AddWithValue("@Website", beObj.Website);
                cmd.Parameters.AddWithValue("@Email", beObj.Email);
            }
            else if (beObj.Control == "Branch")
            {
                cmd.CommandText = "BranchUpdation";
                cmd.Parameters.AddWithValue("@BranchID", beObj.BranchID);
                cmd.Parameters.AddWithValue("@CompanyID", beObj.CompanyID);
                cmd.Parameters.AddWithValue("@Number", beObj.Number);
                cmd.Parameters.AddWithValue("@Name", beObj.Name);
                cmd.Parameters.AddWithValue("@Address", beObj.Address);
                cmd.Parameters.AddWithValue("@PhoneNumber", beObj.PhoneNumber);
                cmd.Parameters.AddWithValue("@FaxNumber", beObj.FaxNumber);
            }
            else if (beObj.Control == "Unit")
            {
                cmd.CommandText = "UnitUpdation";
                cmd.Parameters.AddWithValue("@UnitID", beObj.UnitID);
                cmd.Parameters.AddWithValue("@BranchID", beObj.BranchID);
                cmd.Parameters.AddWithValue("@Number", beObj.Number);
                cmd.Parameters.AddWithValue("@Name", beObj.Name);
                cmd.Parameters.AddWithValue("@Abbrevation", beObj.Abbrevation);
            }
            else if (beObj.Control == "Department")
            {
                cmd.CommandText = "DepartmentUpdation";
                cmd.Parameters.AddWithValue("@DepartmentID", beObj.DepartmentID);
                cmd.Parameters.AddWithValue("@UnitID", beObj.UnitID);
                cmd.Parameters.AddWithValue("@Number", beObj.Number);
                cmd.Parameters.AddWithValue("@Name", beObj.Name);
                cmd.Parameters.AddWithValue("@Abbrevation", beObj.Abbrevation);
            }
            else if (beObj.Control == "Section")
            {
                cmd.CommandText = "SectionUpdation";
                cmd.Parameters.AddWithValue("@SectionID", beObj.SectionID);
                cmd.Parameters.AddWithValue("@DepartmentID", beObj.DepartmentID);
                cmd.Parameters.AddWithValue("@Number", beObj.Number);
                cmd.Parameters.AddWithValue("@Name", beObj.Name);
                cmd.Parameters.AddWithValue("@Abbrevation", beObj.Abbrevation);
            }
            else if (beObj.Control == "Subsection")
            {
                string que = "EXEC SubsectionUpdation @SubsectionID,@SectionID,@Number,@Name,@Abbrevation";
                cmd = new SqlCommand(que, con);
                cmd.Parameters.AddWithValue("@SectionID", beObj.SectionID);
                cmd.Parameters.AddWithValue("@Number", beObj.Number);
                cmd.Parameters.AddWithValue("@Name", beObj.Name);
                cmd.Parameters.AddWithValue("@Abbrevation", beObj.Abbrevation);
                cmd.Parameters.AddWithValue("@SubsectionID", beObj.SubsectionID);

            }
            rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Successfuly updated...");
            }
            else
            {
                MessageBox.Show("Failed to update...");
            }

            return rows;
        }
        public int HRUpdation(BEL beObj)
        {
            int rows;
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;


            if (beObj.Control == "Bonus")
            {
                cmd.CommandText = "BonusUpdation";
                cmd.Parameters.AddWithValue("@BonusID", beObj.BonuseID);
                cmd.Parameters.AddWithValue("@EmployeeID", beObj.EmoloyeeID);
                cmd.Parameters.AddWithValue("@Salary", beObj.Salary);
                cmd.Parameters.AddWithValue("@Month", beObj.currentdate);
                cmd.Parameters.AddWithValue("@BonusAmount", beObj.Amount);
                cmd.Parameters.AddWithValue("@Description", beObj.Description);
            }
            else if (beObj.Control == "Designation")
            {
                cmd.CommandText = "DesignationUpdation";
                cmd.Parameters.AddWithValue("@DesignationID", beObj.DesignationID);
                cmd.Parameters.AddWithValue("@Name", beObj.Name);
                cmd.Parameters.AddWithValue("@Number", beObj.Number);
                cmd.Parameters.AddWithValue("@Abbrevation", beObj.Abbrevation);
            }
            else if (beObj.Control == "Holiday")
            {
                cmd.CommandText = "HolidayUpdation";
                cmd.Parameters.AddWithValue("@HolidayID", beObj.HolidayID);
                cmd.Parameters.AddWithValue("@HolidayDate", beObj.currentdate);
                cmd.Parameters.AddWithValue("@Description", beObj.Description);
            }
            else if (beObj.Control == "Increment")
            {
                cmd.CommandText = "IncrementUpdation";
                cmd.Parameters.AddWithValue("@IncrementID", beObj.incrementID);
                cmd.Parameters.AddWithValue("@EmployeeID", beObj.EmoloyeeID);
                cmd.Parameters.AddWithValue("@Date", beObj.currentdate);
                cmd.Parameters.AddWithValue("@PreviousSalary", beObj.Salary);
                cmd.Parameters.AddWithValue("@Amount", beObj.Amount);
                cmd.Parameters.AddWithValue("@Description", beObj.Description);

            }
            else if (beObj.Control == "Loan")
            {
                cmd.CommandText = "LoanUpdation";
                string que = "EXEC LoanUpdation /*@LoanID,@EmployeeID,@Amount,@Partitions,@IssueDate,@RemainingAmount,@Clear*/";
                //cmd = new SqlCommand(que, con);
                cmd.Parameters.AddWithValue("@LoanID", beObj.LoanID);
                cmd.Parameters.AddWithValue("@EmployeeID", beObj.EmoloyeeID);
                cmd.Parameters.AddWithValue("@Amount", beObj.Amount);
                cmd.Parameters.AddWithValue("@Partitions", beObj.Partitions);
                cmd.Parameters.AddWithValue("@IssueDate", beObj.currentdate);
                cmd.Parameters.AddWithValue("@RemainingAmount", beObj.RemainingAmount);
                cmd.Parameters.AddWithValue("@Clear", beObj.Clear);
            }
            else if (beObj.Control == "Leave")
            {
                cmd.CommandText = "LeaveUpdation";
                cmd.Parameters.AddWithValue("@LeaveID", beObj.LeaveID);
                cmd.Parameters.AddWithValue("@EmployeeID", beObj.EmoloyeeID);
                cmd.Parameters.AddWithValue("@ApprovalDate", beObj.ApprovalDate);
                cmd.Parameters.AddWithValue("@FromDate", beObj.FromDate);
                cmd.Parameters.AddWithValue("@ToDate", beObj.ToDate);
                cmd.Parameters.AddWithValue("@Days", beObj.Days);
                cmd.Parameters.AddWithValue("@Description", beObj.Description);
            }
            else if (beObj.Control == "LeaveBalance")
            {
                cmd.CommandText = "LeaveBalanceUpdation";
                cmd.Parameters.AddWithValue("@LeavebalanceId", beObj.LeaveBalanceID);
                cmd.Parameters.AddWithValue("@EmployeeID", beObj.EmoloyeeID);
                cmd.Parameters.AddWithValue("@NOL", beObj.Number);
            }
            else if (beObj.Control == "Shift")
            {
                cmd.CommandText = "ShiftUpdation";
                cmd.Parameters.AddWithValue("@ShiftID", beObj.ShiftID);
                cmd.Parameters.AddWithValue("@Name", beObj.Name);
                cmd.Parameters.AddWithValue("@Number", beObj.Number);
                cmd.Parameters.AddWithValue("@Abbrevation", beObj.Abbrevation);
                cmd.Parameters.AddWithValue("@StartTime", beObj.startTime);
                cmd.Parameters.AddWithValue("@EndTime", beObj.EndTime);
                cmd.Parameters.AddWithValue("@RestStartTime", beObj.RestStartTime);
                cmd.Parameters.AddWithValue("@RestEndTime", beObj.RestEndTime);
                cmd.Parameters.AddWithValue("@BeforeInTime", beObj.BeforeInTime);
                cmd.Parameters.AddWithValue("@AfterOutTime", beObj.AfterOutTime);
                cmd.Parameters.AddWithValue("@AfterInTime", beObj.AfterInTime);
                cmd.Parameters.AddWithValue("@BeforeOutTime", beObj.BeforeOutTime);
            }
            rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Successfuly updated...");
            }
            else
            {
                MessageBox.Show("Failed to update...");
            }

            return rows;
        }
        public int AccountsUpdation(BEL beObj)
        {
            int rows;
            
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;


            if (beObj.Control == "Level1")
            {
                cmd.CommandText = "COALevel1Updation";
                cmd.Parameters.AddWithValue("@L1_id", beObj.Level1ID);
                cmd.Parameters.AddWithValue("@Name", beObj.Name);
            }
            else if (beObj.Control == "Level2")
            {
                cmd.CommandText = "COALevel2Updation";    
                cmd.Parameters.AddWithValue("@L1_id", beObj.Level1ID);
                cmd.Parameters.AddWithValue("@Name", beObj.Name);
                cmd.Parameters.AddWithValue("@L2_id ", beObj.Level2ID);
            }
            else if (beObj.Control == "Level3")
            {
                cmd.CommandText = "COALevel3Updation";
                cmd.Parameters.AddWithValue("@L2_id", beObj.Level2ID);
                cmd.Parameters.AddWithValue("@L3_id", beObj.Level3ID);
                cmd.Parameters.AddWithValue("@Name", beObj.Name);
            }
            else if (beObj.Control == "Level4")
            {
                cmd.CommandText = "COALevel4Updation";
                cmd.Parameters.AddWithValue("@L4_id ", beObj.Level4ID);
                cmd.Parameters.AddWithValue("@L3_id", beObj.Level3ID);
                cmd.Parameters.AddWithValue("@Name", beObj.Name);
            }
            else if (beObj.Control=="Bank")
            {
                cmd.CommandText = "BankUpdation";
                cmd.Parameters.AddWithValue("@BankID", beObj.BankID);
                cmd.Parameters.AddWithValue("@AccountID", beObj.AccountID);
                cmd.Parameters.AddWithValue("@Name", beObj.Name);
                cmd.Parameters.AddWithValue("@AccountNumber", beObj.AccountNumber);
                cmd.Parameters.AddWithValue("@IBANNumber", beObj.IBANNumber);
                cmd.Parameters.AddWithValue("@AccounTitle", beObj.AccountTitle);
                cmd.Parameters.AddWithValue("@SwiftCode", beObj.SwiftCode);
            }
            else if (beObj.Control == "Voucher")
            {
                cmd.CommandText = "VoucherUpdation";
                cmd.Parameters.AddWithValue("@VoucherID", beObj.voucherID);
                cmd.Parameters.AddWithValue("@VoucherNumber", beObj.voucherNumber);
                cmd.Parameters.AddWithValue("@VoucherType", beObj.VoucherType);
                cmd.Parameters.AddWithValue("@Remarks", beObj.Remarks);
                cmd.Parameters.AddWithValue("@Refrence", beObj.Refrence);
            }
            else if (beObj.Control == "Customer")
            {
                //cmd.CommandText = "CustomerUpdation";
                string que = "EXEC CustomerUpdation @CustomerID,@AccountID,@Name,@Category,@Address,@ContactPerson,@PhoneNumber,@Email";
                cmd = new SqlCommand(que, con);
                cmd.Parameters.AddWithValue("@CustomerID", beObj.CustomerID);
                cmd.Parameters.AddWithValue("@AccountID", beObj.AccountID);
                cmd.Parameters.AddWithValue("@Name", beObj.Name);
                cmd.Parameters.AddWithValue("@Address", beObj.Address);
                cmd.Parameters.AddWithValue("@Category", beObj.Category);
                cmd.Parameters.AddWithValue("@ContactPerson", beObj.Contactperson);
                cmd.Parameters.AddWithValue("@PhoneNumber", beObj.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email", beObj.Email);
            }
            else if (beObj.Control == "Supplier")
            {
                cmd.CommandText = "SupplierUpdation";
                cmd.Parameters.AddWithValue("@SupplierID", beObj.SupplierID);
                cmd.Parameters.AddWithValue("@AccountID", beObj.AccountID);
                cmd.Parameters.AddWithValue("@Name", beObj.Name);
                cmd.Parameters.AddWithValue("@Address", beObj.Address);
                cmd.Parameters.AddWithValue("@Category", beObj.Category);
                cmd.Parameters.AddWithValue("@ContactPerson", beObj.Contactperson);
                cmd.Parameters.AddWithValue("@PhoneNumber", beObj.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email", beObj.Email);
            }
            rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Successfuly updated...");
            }
            else
            {
                MessageBox.Show("Failed to update...");
            }

            return rows;
        }
        
            #endregion

            #region Select
        public DataTable GroupView(BEL beObj)
        {
            if (beObj.Control == "Group")
            {
                string que = "SELECT * FROM vwGroup";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Company")
            {
                string que = "Select * FROM vwCompany";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Branch")
            {
                string que = "Select * FROM vwBranch";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Unit")
            {
                string que = "Select * FROM vwUnit";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Department")
            {
                string que = "Select * FROM vwDepartment";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Section")
            {
                string que = "Select * FROM vwSection";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Subsection")
            {
                string que = "Select * FROM vwSubsection";
                cmd = new SqlCommand(que, con);
            }
            adp = new SqlDataAdapter(cmd);
            if (con == null || con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public DataTable HRView(BEL beObj)
        {
            if (beObj.Control == "Bonus")
            {
                string que = "SELECT * FROM vwBonus";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Designation")
            {
                string que = "SELECT * FROM vwDesignation";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Holiday")
            {
                string que = "SELECT * FROM vwHoliday";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Increment")
            {
                string que = "EXEC vwEmployeeForIncrement";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Leave")
            {
                string que = "SELECT * FROM vwLeave";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "LeaveBalance")
            {
                string que = "SELECT * FROM vwLeaveBalance";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Shift")
            {
                string que = "SELECT * FROM vwShifts";
                cmd = new SqlCommand(que, con);
            }
            else if(beObj.Control=="Loan")
            {
                string que = "SELECT * FROM vwLoan";
                cmd = new SqlCommand(que, con);
            }
            adp = new SqlDataAdapter(cmd);
            if (con == null || con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public DataTable AccountsView(BEL beObj)
        {
            if (beObj.Control == "Level1")
            {
                string que = "SELECT * FROM vwLevel1";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Level2")
            {
                string que = "SELECT * FROM vwLevel2";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Level3")
            {
                string que = "SELECT * FROM vwLevel3";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Level4")
            {
                string que = "SELECT * FROM vwLevel4";
                cmd = new SqlCommand(que, con);
            }
            else if(beObj.Control=="GL")
            {
                string que = "SELECT * FROM vwGL";
                cmd = new SqlCommand(que, con);
            }
            else if(beObj.Control=="Bank")
            {
                string que = "SELECT * FROM vwBanks";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Voucher")
            {
                string que = "SELECT * FROM vwVoucher";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Customer")
            {
                string que = "SELECT * FROM vwCustomer";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Supplier")
            {
                string que = "SELECT * FROM vwSupplier";
                cmd = new SqlCommand(que, con);
            }
            adp = new SqlDataAdapter(cmd);
            if (con == null || con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public DataTable InventoryView(BEL beObj)
        {
            if (beObj.Control == "GatePass")
            {
                string que = "SELECT * FROM vwGatePass";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Products")
            {
                string que = "SELECT * FROM vwProducts1";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Stores")
            {
                string que = "SELECT * FROM vwStores";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Bins")
            {
                string que = "SELECT * FROM vwBins";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "ProductUnit")
            {
                string que = "SELECT * FROM vwProductUnit";
                cmd = new SqlCommand(que, con);
            }
            else if (beObj.Control == "Stock")
            {
                string que = "SELECT * FROM vwStock";
                cmd = new SqlCommand(que, con);
            }
        
            adp = new SqlDataAdapter(cmd);
            if (con == null || con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        #endregion

        #region Constraints
        public int ConstraintAvailableDays(BEL beObj)
        {
            int avail;
            string que = "EXEC ConstraintAvailableDays @EmployeeID";
            cmd = new SqlCommand(que, con);
            cmd.Parameters.AddWithValue("@EmployeeID", beObj.EmoloyeeID);
            adp = new SqlDataAdapter(cmd);
            if (con == null || con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            avail = (int)cmd.ExecuteScalar();
            return avail;
        }
        public int AvailableDaysInLeaveBalance(BEL beObj)
        {
            int avail=0;
            string que = "EXEC AvailableLeavesInLeaveBalance @EmployeeID,@Year";
            cmd = new SqlCommand(que, con);
            cmd.Parameters.AddWithValue("@EmployeeID", beObj.EmoloyeeID);
            cmd.Parameters.AddWithValue("@Year", beObj.Year);
            adp = new SqlDataAdapter(cmd);
            if (con == null || con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                avail = Convert.ToInt32(cmd.ExecuteScalar());

                return avail;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception"+ex);
            }
            finally
            {

            }
            return avail;
        }
        public bool UpdateDaysinLeaveBalance(BEL beObj)
        {
            bool isSuccess = false;
            cmd.Connection = con;
            try
            {
                if (con == null || con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string que = "EXEC UpdateLeaveBalance @EmployeeID,@Year,@NOL";
                cmd = new SqlCommand(que, con);
                cmd.Parameters.AddWithValue("@EmployeeID", beObj.EmoloyeeID);
                cmd.Parameters.AddWithValue("@Year", beObj.Year);
                cmd.Parameters.AddWithValue("@NOL", beObj.Days);

                int rows = cmd.ExecuteNonQuery();
                //if (rows > 0)
                //{
                //    isSuccess = true;
                //}
                //else
                //{
                //    isSuccess = false;
                //    MessageBox.Show("Fail to insert");
                //}
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error"+ex);
            }
            finally
            {
                if(con.State==ConnectionState.Open)
                {
                    con.Close();
                }
                
            }
            return isSuccess;
        }
        public bool UpdateEmployeSalary(BEL beObj)
        {
            bool isSuccess = false;
            cmd.Connection = con;
            try
            {
                if (con == null || con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string que = "EXEC UpdateSalaryInEmployee @EmployeeID,@Salary,@HouseRent,@UtulityAllowance";
                cmd = new SqlCommand(que, con);
                cmd.Parameters.AddWithValue("@EmployeeID", beObj.EmoloyeeID);
                cmd.Parameters.AddWithValue("@Salary", beObj.Salary);
                cmd.Parameters.AddWithValue("@HouseRent", beObj.HouseRent);
                cmd.Parameters.AddWithValue("@UtulityAllowance", beObj.UtilityAllowance);

                int rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
            return isSuccess;
        }
        public bool CheckAttendanceExist(BEL beObj)
        {
            bool isSuccess = false;
            try
            {

                string sql = "EXEC CheckAttendanceExist @EmployeeID";
                cmd = new SqlCommand(sql, con);
                adp = new SqlDataAdapter(cmd);
                dt = new DataTable();
                if (con == null || con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.AddWithValue("@EmployeeID", beObj.EmoloyeeID);
                adp.Fill(dt);
                if (dt.Rows.Count.ToString() =="1")
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }

            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();

            }
            return isSuccess;
        }
        public DataTable EmployeeAttendanceView(BEL beObj)
        {
            if (con == null || con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string que = "EXEC GetAttendanceRecord '"+beObj.EmoloyeeID+"'";
            cmd = new SqlCommand(que, con);
            adp = new SqlDataAdapter(cmd);          
            dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public bool EmployeUpdateTimeOutAttendance(BEL beObj)
        {
            bool isSuccess = false;
            cmd.Connection = con;
            try
            {
                if (con == null || con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string que = "EXEC UpdateTimeOutinAttendance @ID,@TimeOut,@TotalTime";
                cmd = new SqlCommand(que, con);
                cmd.Parameters.AddWithValue("@ID", beObj.AttendanceID);
                cmd.Parameters.AddWithValue("@TimeOut", beObj.currentdate);
                cmd.Parameters.AddWithValue("@TotalTime", beObj.TotalTime);

                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    return isSuccess = true;
                }
                else
                {
                    return isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
            return isSuccess;
        }
        #endregion
    }
}

