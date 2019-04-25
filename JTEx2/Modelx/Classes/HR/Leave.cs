namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Leave")]
    public partial class Leave
    {
        [Key]
        public int leave_id { get; set; }

        public int EmployeeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime ApprovalDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime FromDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ToDate { get; set; }

        public byte Days { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }
    }
}
