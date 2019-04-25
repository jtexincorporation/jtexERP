namespace Modelx
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Modelx.Classes.Accounts;

    public partial class ADOEntityModel : DbContext
    {
        public ADOEntityModel()
            : base("name=ADOEntityModel")
        {
        }

        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Bin> Bins { get; set; }
        public virtual DbSet<Bonu> Bonus { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<GatePass> GatePasses { get; set; }
        public virtual DbSet<GL_Voucher> GL_Voucher { get; set; }
        public virtual DbSet<GL_Voucher_Item_Type> GL_Voucher_Item_Type { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<IncrementSalary> IncrementSalaries { get; set; }
        public virtual DbSet<Leave> Leaves { get; set; }
        public virtual DbSet<LeaveBalance> LeaveBalances { get; set; }
        public virtual DbSet<Level1> Level1 { get; set; }
        public virtual DbSet<Level2> Level2 { get; set; }
        public virtual DbSet<Level3> Level3 { get; set; }
        public virtual DbSet<Level4> Level4 { get; set; }
        public virtual DbSet<Level5> Level5 { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductUnit> ProductUnits { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Subsection> Subsections { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Urdu> Urdus { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<EmployeeFamilyInfo> EmployeeFamilyInfoes { get; set; }
        public virtual DbSet<EmployeeOrgInfo> EmployeeOrgInfoes { get; set; }
        public virtual DbSet<EmployeePersonalDetail> EmployeePersonalDetails { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bank>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Bank>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Bank>()
                .Property(e => e.IBANNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Bank>()
                .Property(e => e.AccountTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Bank>()
                .Property(e => e.SwiftCode)
                .IsUnicode(false);

            modelBuilder.Entity<Bin>()
                .Property(e => e.RackNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Bin>()
                .Property(e => e.RowNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Bin>()
                .Property(e => e.ShelfNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Bonu>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.FaxNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.NTN)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.STN)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Website)
                .IsUnicode(false);

          

            modelBuilder.Entity<Department>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Abbrevation)
                .IsUnicode(false);

            modelBuilder.Entity<Designation>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Designation>()
                .Property(e => e.Abbrevation)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PicturePath)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeLevel)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeType)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.FileStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.JobStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Barcode)
                .IsUnicode(false);

            modelBuilder.Entity<GatePass>()
                .Property(e => e.GPNumber)
                .IsUnicode(false);

            modelBuilder.Entity<GatePass>()
                .Property(e => e.GPCategory)
                .IsUnicode(false);

            modelBuilder.Entity<GatePass>()
                .Property(e => e.DriverName)
                .IsUnicode(false);

            modelBuilder.Entity<GatePass>()
                .Property(e => e.VehicleNumber)
                .IsUnicode(false);

            modelBuilder.Entity<GatePass>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<GL_Voucher>()
                .Property(e => e.VoucherNumber)
                .IsUnicode(false);

            modelBuilder.Entity<GL_Voucher>()
                .Property(e => e.VoucherType)
                .IsUnicode(false);

            modelBuilder.Entity<GL_Voucher>()
                .Property(e => e.Refrence)
                .IsUnicode(false);

            modelBuilder.Entity<GL_Voucher>()
                .Property(e => e.VoucherStatus)
                .IsUnicode(false);

            modelBuilder.Entity<GL_Voucher>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<GL_Voucher_Item_Type>()
                .Property(e => e.Narration)
                .IsUnicode(false);

            modelBuilder.Entity<Group>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Holiday>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<IncrementSalary>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Leave>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Level1>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Level2>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Level3>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Level4>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Level5>()
               .Property(e => e.Name)
               .IsFixedLength()
               .IsUnicode(false);


            modelBuilder.Entity<Product>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.PicturePath)
                .IsUnicode(false);

            modelBuilder.Entity<ProductUnit>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProductUnit>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Section>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Section>()
                .Property(e => e.Abbrevation)
                .IsUnicode(false);

            modelBuilder.Entity<Shift>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Shift>()
                .Property(e => e.StartTime)
                .HasPrecision(3);

            modelBuilder.Entity<Stock>()
                .Property(e => e.EnteryType)
                .IsUnicode(false);

            modelBuilder.Entity<Stock>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<Subsection>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Subsection>()
                .Property(e => e.Abbrevation)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.ContactPerson)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Unit>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Unit>()
                .Property(e => e.Abbrevation)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.AllCode)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeFamilyInfo>()
                .Property(e => e.FatherName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeFamilyInfo>()
                .Property(e => e.FatherProfession)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeFamilyInfo>()
                .Property(e => e.MartialStatus)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeFamilyInfo>()
                .Property(e => e.WHName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeFamilyInfo>()
                .Property(e => e.CNIC2)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeFamilyInfo>()
                .Property(e => e.EmergencyContactNumber)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeePersonalDetail>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeePersonalDetail>()
                .Property(e => e.CNIC)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeePersonalDetail>()
                .Property(e => e.ContactNumber)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeePersonalDetail>()
                .Property(e => e.BloodGroup)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeePersonalDetail>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeePersonalDetail>()
                .Property(e => e.Qualification)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeePersonalDetail>()
                .Property(e => e.Experiance)
                .IsUnicode(false);
        }
    }
}
