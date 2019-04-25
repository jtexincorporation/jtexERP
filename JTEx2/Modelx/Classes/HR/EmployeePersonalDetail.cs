namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeePersonalDetail")]
    public partial class EmployeePersonalDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(20)]
        public string CNIC { get; set; }

        [StringLength(20)]
        public string ContactNumber { get; set; }

        [StringLength(3)]
        public string BloodGroup { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime DOB { get; set; }

        [StringLength(20)]
        public string Qualification { get; set; }

        [StringLength(100)]
        public string Experiance { get; set; }
    }
}
