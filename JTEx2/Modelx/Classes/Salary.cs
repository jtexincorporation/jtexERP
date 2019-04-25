namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Salary")]
    public partial class Salary
    {
        [Key]
        public int s_id { get; set; }

        public int EmployeeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Month { get; set; }

        public int NoOfDays { get; set; }

        [Column("Salary")]
        public long Salary1 { get; set; }

        public int BasicSalary { get; set; }

        public int HouseRent { get; set; }

        public int UtiillityAllowance { get; set; }

        public int Loan { get; set; }

        public int Overtime { get; set; }

        public int Increment { get; set; }

        public int Bonus { get; set; }

        public long NetSalary { get; set; }
    }
}
