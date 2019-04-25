using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BELayer
{
    public class BEL
    {
        public string Control { get; set; }

        public int GroupID { get; set; }
        public string Name { get; set; }

        public int Number { get; set; }

        public int CompanyID { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string ShortName { get; set; }
        public string STN { get; set; }
        public string NTN { get; set; }

        public int BranchID { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }

        public int UnitID { get; set; }
        public string Abbrevation { get; set; }
        public int DepartmentID { get; set; }

        public int SectionID { get; set; }
        public int SubsectionID { get; set; }

        public int BonuseID { get; set; }
        public DateTime currentdate { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }

        public int EmoloyeeID { get; set; }
        public int DesignationID { get; set; }
        public int HolidayID { get; set; }

        public int incrementID { get; set; }
        public int LeaveBalanceID { get; set; }
        public int ShiftID { get; set; }
        public string startTime { get; set; }
        public string EndTime { get; set; }
        public string RestStartTime { get; set; }
        public string RestEndTime { get; set; }
        public string BeforeInTime { get; set; }
        public string AfterOutTime { get; set; }
        public string AfterInTime { get; set; }
        public string BeforeOutTime { get; set; }

        public int LeaveID { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime ApprovalDate { get; set; }
        public Int16 Days { get; set; }
        public Int16 Year { get; set; }

        public Int64 Salary { get; set; }
        public Int64 BasicSalary { get; set; }
        public float HouseRent { get; set; }
        public float UtilityAllowance { get; set; }

        public int LoanID { get; set; }
        public Int16 Partitions { get; set; }
        public int PreviousSalary { get; set; }
        public int RemainingAmount { get; set; }
        public Boolean Clear { get; set; }

        public int TotalTime { get; set; }
        public int AttendanceID { get; set; }




        //ACcounts
        public int Level1ID { get; set; }
        public int Level2ID { get; set; }
        public int Level3ID { get; set; }
        public int Level4ID { get; set; }

        public Int16 GLID { get; set; }
        public int Debit { get; set; }
        public int Credit { get; set; }
        public string Narration { get; set; }

        public Int16 BankID { get; set; }
        public int AccountID { get; set; }
        public string AccountNumber { get; set; }
        public string SwiftCode { get; set; }
        public string AccountTitle { get; set; }
        public string IBANNumber { get; set; }
        public int voucherID { get; set; }

        public string voucherNumber { get; set; }
        public string Remarks { get; set; }
        public string Refrence { get; set; }
        public string VoucherType { get; set; }

        public string Category { get; set; }
        public int CustomerID { get; set; }
        public int SupplierID { get; set; }
        public string Contactperson { get; set; }

        public int GatePassID { get; set; }
        public string GPNumber { get; set; }
        public string DriverName { get; set; }
        public string VehicleNumber { get; set; }
        public int storeID { get; set; }
        public string Location { get; set; }
        public string RackNumber { get; set; }
        public string RowNumber { get; set; }
        public string ShelfNumber { get; set; }
        public int ProductUnit { get; set; }
        public int BinID { get; set; }
        public string EnteryType { get; set; }
        public int Quantity { get; set; }
        public int ProductID { get; set; }
    }
}       
