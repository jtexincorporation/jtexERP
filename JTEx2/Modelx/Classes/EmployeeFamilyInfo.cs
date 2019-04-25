namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeFamilyInfo")]
    public partial class EmployeeFamilyInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FatherName { get; set; }

        [StringLength(30)]
        public string FatherProfession { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string MartialStatus { get; set; }

        [StringLength(50)]
        public string WHName { get; set; }

        [StringLength(20)]
        public string CNIC2 { get; set; }

        [StringLength(20)]
        public string EmergencyContactNumber { get; set; }
    }
}
