namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        public int EmployeeSequenceID { get; set; }

        public int EmployeeID { get; set; }

        public int? DepartmentID { get; set; }

        public int? DesignationID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string PicturePath { get; set; }

        [StringLength(10)]
        public string EmployeeLevel { get; set; }

        [StringLength(10)]
        public string EmployeeType { get; set; }

        [StringLength(20)]
        public string FileStatus { get; set; }

        [StringLength(20)]
        public string JobStatus { get; set; }

        public long? Salary { get; set; }

        public double? HouseRent { get; set; }

        public double? UtilityAllowance { get; set; }

        [StringLength(10)]
        public string Barcode { get; set; }

        public bool? OverTimeEntitled { get; set; }

        public bool? Probation { get; set; }
    }
}
